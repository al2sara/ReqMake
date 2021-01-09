using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
namespace ReqMake
{
    class make_request
    {

        // Our function for setting up the headers.
        public void request_headers(string[] headers, HttpRequest req)
        {
            // Getting the header from headers array
            foreach (string i in headers)
            {
                // Splits the header. (header[0] = header key, header[1] = header value)
                string[] header = i.Split(':');
                // Removes the blank char at our header value.
                header[1] = header[1].Remove(0, 1);
                // Add the header to our request.
                req.AddHeader(header[0], header[1]);
            }
        }

        // Our function to send request.
        public void send_request(int method, string url, string body, string[] headers, string proxy, int proxyType, string contentType)
        {
            // Error handling.
            try
            {
                // Creates a dictionary for our response headers.
                Dictionary<string, string>.Enumerator dict_headers = new Dictionary<string, string>.Enumerator();
                // Helps us to access our form components.
                ReqMake mainForm = (ReqMake)Application.OpenForms[0];
                // Create a request.
                using (HttpRequest req = new HttpRequest())
                {
                    // Ignore protocol errors such as internal server error.
                    req.IgnoreProtocolErrors = true;
                    // Proxy manager, if our proxy string provided as "proxyless", then it will use no proxies.
                    if (proxy == "proxyless")
                        req.Proxy = null;
                    else
                    {
                        switch (proxyType)
                        {
                            case 1:
                                req.Proxy = HttpProxyClient.Parse(proxy);
                                break;
                            case 2:
                                req.Proxy = Socks4ProxyClient.Parse(proxy);
                                break;
                            case 3:
                                req.Proxy = Socks5ProxyClient.Parse(proxy);
                                break;
                        }
                    }
                    // Calls our header function to add headers.
                    request_headers(headers, req);
                    // Create a HttpResponse.
                    HttpResponse resp = null;
                    // We use "switch" statement to identify which Request Method that's going to be used. After that, we send a request and save it to HttpResponse that we created.
                    switch (method)
                    {
                        case 0:
                            resp = req.Get(url);
                            break;
                        case 1:
                            resp = req.Post(url, body, contentType);
                            break;
                        case 2:
                            resp = req.Put(url, body, contentType);
                            break;
                        case 3:
                            resp = req.Patch(url, body, contentType);
                            break;
                        case 4:
                            resp = req.Delete(url, body, contentType);
                            break;
                        case 5:
                            resp = req.Options(url);
                            break;
                    }
                    // We add our response headers into our dictionary that we created before.
                    dict_headers = resp.EnumerateHeaders();
                    // Getting the temp string out of our response headers dictionary.
                    string temp = dict_headers.Current.ToString();
                    // Then we move onto next to make our while loop work.
                    dict_headers.MoveNext();
                    mainForm.txtRespBody.AppendText("RECEIVED HEADERS: \r\n");
                    // This while loop helps us to iterate between headers and add them into our listview that we created on our form.
                    // EXPLANATION: This code will loop until current header is same with temp header which means when our dictionary looped through all headers and started looping again.
                    while (temp != dict_headers.Current.ToString())
                    {
                        // Create a listviewitem for our header value - keys.
                        ListViewItem lvi = new ListViewItem(dict_headers.Current.Key);
                        lvi.SubItems.Add(dict_headers.Current.Value);
                        mainForm.lstRespHeaders.Items.Add(lvi);
                        // Append our headers to our response body.
                        mainForm.txtRespBody.AppendText(dict_headers.Current.Key + ": " + dict_headers.Current.Value + "\r\n");
                        // Move onto next header, and loop.
                        dict_headers.MoveNext();
                    }
                    // Output our request to response body.
                    mainForm.txtRespBody.AppendText("\r\nRECEIVED BODY: \r\n");
                    mainForm.txtRespBody.AppendText(resp.ToString());
                    MessageBox.Show("Request successfuly sent.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}