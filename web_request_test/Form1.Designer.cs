namespace web_request_test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_post_data = new System.Windows.Forms.TextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_method = new System.Windows.Forms.TextBox();
            this.tb_header_ext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_timeout = new System.Windows.Forms.TextBox();
            this.tb_wb1 = new System.Windows.Forms.TextBox();
            this.ck_tb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(536, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(608, 293);
            this.webBrowser1.TabIndex = 2;
            // 
            // tb_post_data
            // 
            this.tb_post_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_post_data.Location = new System.Drawing.Point(12, 314);
            this.tb_post_data.Multiline = true;
            this.tb_post_data.Name = "tb_post_data";
            this.tb_post_data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_post_data.Size = new System.Drawing.Size(231, 111);
            this.tb_post_data.TabIndex = 1;
            this.tb_post_data.Text = "POST DATA";
            // 
            // tb_url
            // 
            this.tb_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_url.Location = new System.Drawing.Point(314, 314);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(306, 21);
            this.tb_url.TabIndex = 3;
            this.tb_url.Text = "http://";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "url:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "method:";
            // 
            // tb_method
            // 
            this.tb_method.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_method.Location = new System.Drawing.Point(314, 391);
            this.tb_method.Name = "tb_method";
            this.tb_method.Size = new System.Drawing.Size(72, 21);
            this.tb_method.TabIndex = 5;
            this.tb_method.Text = "POST";
            // 
            // tb_header_ext
            // 
            this.tb_header_ext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_header_ext.Location = new System.Drawing.Point(314, 355);
            this.tb_header_ext.Name = "tb_header_ext";
            this.tb_header_ext.Size = new System.Drawing.Size(306, 21);
            this.tb_header_ext.TabIndex = 3;
            this.tb_header_ext.Text = "AAA: BBB";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "headers\r\next data:";
            // 
            // lb_info
            // 
            this.lb_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(261, 430);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(29, 12);
            this.lb_info.TabIndex = 7;
            this.lb_info.Text = "就绪";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "timeout\r\n(ms):";
            // 
            // tb_timeout
            // 
            this.tb_timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_timeout.Location = new System.Drawing.Point(458, 391);
            this.tb_timeout.Name = "tb_timeout";
            this.tb_timeout.Size = new System.Drawing.Size(72, 21);
            this.tb_timeout.TabIndex = 8;
            this.tb_timeout.Text = "60000";
            // 
            // tb_wb1
            // 
            this.tb_wb1.Location = new System.Drawing.Point(12, 12);
            this.tb_wb1.Multiline = true;
            this.tb_wb1.Name = "tb_wb1";
            this.tb_wb1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_wb1.Size = new System.Drawing.Size(608, 293);
            this.tb_wb1.TabIndex = 10;
            // 
            // ck_tb
            // 
            this.ck_tb.AutoSize = true;
            this.ck_tb.Location = new System.Drawing.Point(546, 389);
            this.ck_tb.Name = "ck_tb";
            this.ck_tb.Size = new System.Drawing.Size(84, 16);
            this.ck_tb.TabIndex = 11;
            this.ck_tb.Text = "显示为文本";
            this.ck_tb.UseVisualStyleBackColor = true;
            this.ck_tb.CheckedChanged += new System.EventHandler(this.ck_tb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 451);
            this.Controls.Add(this.ck_tb);
            this.Controls.Add(this.tb_wb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_timeout);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_method);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_header_ext);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tb_post_data);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Restful Http调试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_post_data;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_method;
        private System.Windows.Forms.TextBox tb_header_ext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_timeout;
        private System.Windows.Forms.TextBox tb_wb1;
        private System.Windows.Forms.CheckBox ck_tb;
    }
}

