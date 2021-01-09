
namespace ReqMake
{
    partial class ReqMake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReqMake));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtRespBody = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstRespHeaders = new System.Windows.Forms.ListView();
            this.clmnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnReq = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtReqHeaders = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtReqBody = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkProxy = new System.Windows.Forms.CheckBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.comboProxyType = new System.Windows.Forms.ComboBox();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textContentType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(47, 21);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(710, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // txtRespBody
            // 
            this.txtRespBody.Location = new System.Drawing.Point(445, 373);
            this.txtRespBody.Multiline = true;
            this.txtRespBody.Name = "txtRespBody";
            this.txtRespBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRespBody.Size = new System.Drawing.Size(366, 374);
            this.txtRespBody.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(432, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 421);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(134, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Response Body";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lstRespHeaders);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(35, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 421);
            this.panel2.TabIndex = 10;
            // 
            // lstRespHeaders
            // 
            this.lstRespHeaders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRespHeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnHeader,
            this.clmnValue});
            this.lstRespHeaders.FullRowSelect = true;
            this.lstRespHeaders.GridLines = true;
            this.lstRespHeaders.HideSelection = false;
            this.lstRespHeaders.LabelEdit = true;
            this.lstRespHeaders.Location = new System.Drawing.Point(13, 36);
            this.lstRespHeaders.Name = "lstRespHeaders";
            this.lstRespHeaders.Size = new System.Drawing.Size(365, 374);
            this.lstRespHeaders.TabIndex = 1;
            this.lstRespHeaders.UseCompatibleStateImageBehavior = false;
            this.lstRespHeaders.View = System.Windows.Forms.View.Details;
            // 
            // clmnHeader
            // 
            this.clmnHeader.Text = "Header";
            this.clmnHeader.Width = 180;
            // 
            // clmnValue
            // 
            this.clmnValue.Text = "Value";
            this.clmnValue.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(127, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Response Headers";
            // 
            // btnReq
            // 
            this.btnReq.Location = new System.Drawing.Point(761, 19);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(62, 23);
            this.btnReq.TabIndex = 11;
            this.btnReq.Text = "Make";
            this.btnReq.UseVisualStyleBackColor = true;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.txtReqHeaders);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(35, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 216);
            this.panel3.TabIndex = 12;
            // 
            // txtReqHeaders
            // 
            this.txtReqHeaders.Location = new System.Drawing.Point(12, 34);
            this.txtReqHeaders.Multiline = true;
            this.txtReqHeaders.Name = "txtReqHeaders";
            this.txtReqHeaders.Size = new System.Drawing.Size(366, 167);
            this.txtReqHeaders.TabIndex = 13;
            this.txtReqHeaders.Text = "Accept: */*\r\nUser-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/53" +
    "7.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(134, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Request Headers";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.txtReqBody);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(432, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 216);
            this.panel4.TabIndex = 13;
            // 
            // txtReqBody
            // 
            this.txtReqBody.Enabled = false;
            this.txtReqBody.Location = new System.Drawing.Point(12, 34);
            this.txtReqBody.Multiline = true;
            this.txtReqBody.Name = "txtReqBody";
            this.txtReqBody.Size = new System.Drawing.Size(366, 167);
            this.txtReqBody.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(134, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Request Body";
            // 
            // chkProxy
            // 
            this.chkProxy.AutoSize = true;
            this.chkProxy.Location = new System.Drawing.Point(49, 56);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(74, 17);
            this.chkProxy.TabIndex = 14;
            this.chkProxy.Text = "Use Proxy";
            this.chkProxy.UseVisualStyleBackColor = true;
            this.chkProxy.CheckedChanged += new System.EventHandler(this.chkProxy_CheckedChanged);
            // 
            // txtProxy
            // 
            this.txtProxy.Enabled = false;
            this.txtProxy.Location = new System.Drawing.Point(128, 54);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(159, 20);
            this.txtProxy.TabIndex = 15;
            this.txtProxy.Text = "127.0.0.1:443";
            // 
            // comboProxyType
            // 
            this.comboProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProxyType.Enabled = false;
            this.comboProxyType.FormattingEnabled = true;
            this.comboProxyType.Items.AddRange(new object[] {
            "HTTP/S",
            "SOCKS4",
            "SOCKS5"});
            this.comboProxyType.Location = new System.Drawing.Point(293, 54);
            this.comboProxyType.Name = "comboProxyType";
            this.comboProxyType.Size = new System.Drawing.Size(98, 21);
            this.comboProxyType.TabIndex = 16;
            // 
            // comboMethod
            // 
            this.comboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "PATCH",
            "DELETE",
            "OPTIONS"});
            this.comboMethod.Location = new System.Drawing.Point(451, 54);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(159, 21);
            this.comboMethod.TabIndex = 17;
            this.comboMethod.SelectedIndexChanged += new System.EventHandler(this.comboMethod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Content Type";
            // 
            // textContentType
            // 
            this.textContentType.Location = new System.Drawing.Point(696, 54);
            this.textContentType.Name = "textContentType";
            this.textContentType.Size = new System.Drawing.Size(126, 20);
            this.textContentType.TabIndex = 20;
            this.textContentType.Text = "application/x-www-form-urlencoded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 766);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "made with ♥ by al2";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ReqMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 787);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textContentType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboMethod);
            this.Controls.Add(this.comboProxyType);
            this.Controls.Add(this.txtProxy);
            this.Controls.Add(this.chkProxy);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRespBody);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReqMake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReqMake";
            this.Load += new System.EventHandler(this.ReqMake_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader clmnHeader;
        private System.Windows.Forms.ColumnHeader clmnValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtReqHeaders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReqBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkProxy;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.ComboBox comboProxyType;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textContentType;
        public System.Windows.Forms.ListView lstRespHeaders;
        public System.Windows.Forms.TextBox txtRespBody;
        private System.Windows.Forms.Label label8;
    }
}

