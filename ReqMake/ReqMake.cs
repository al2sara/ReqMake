using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReqMake
{
    public partial class ReqMake : Form
    {
        public ReqMake()
        {
            InitializeComponent();
        }

        private void ReqMake_Load(object sender, EventArgs e)
        {
            // To not leave our combobox blank. It causes a crash if you leave them blank. You can also handle that exception, but this way is better and cleaner.
            comboProxyType.SelectedIndex = 0;
            comboMethod.SelectedIndex = 0;
        }

        // Define our make_request class.
        make_request req = new make_request();
        void setup()
        {
            // Defining all variables to send our request.
            string[] header_content = txtReqHeaders.Text.Split('\n');
            int method = comboMethod.SelectedIndex;
            string reqBody = txtReqBody.Text;
            string url = txtUrl.Text;
            string proxy;
            if (chkProxy.Checked)
                proxy = txtProxy.Text;
            else
                proxy = "proxyless";
            int proxyType = comboProxyType.SelectedIndex;
            string contentType = textContentType.Text;
            // Sending request through our make_request class.
            req.send_request(method, url, reqBody, header_content, proxy, proxyType, contentType);

        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            // We clear our listbox and textbox first, because we don't want to mix up our responses.
            lstRespHeaders.Items.Clear();
            txtRespBody.Clear();
            // Call the setup function.
            setup();
        }

        private void comboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if GET or OPTIONS method selected, if not, it enables the "Request Body" textbox.
            if (comboMethod.SelectedIndex == 0)
                txtReqBody.Enabled = false;
            else if (comboMethod.SelectedIndex == 5)
                txtReqBody.Enabled = false;
            else
                txtReqBody.Enabled = true;

        }

        private void chkProxy_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if our proxy checkbox is checked or not, if so, it enables proxy textbox and type combobox.
            if (chkProxy.Checked)
            {
                txtProxy.Enabled = true;
                comboProxyType.Enabled = true;
            }
            else
            {
                txtProxy.Enabled = false;
                comboProxyType.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Watermark label, donations are appreciated <3 1NK38gvbcwoFf3adBAQ4n8GR7dYPkP2KSt
            System.Diagnostics.Process.Start("https://altugsara.com");
        }
    }
}