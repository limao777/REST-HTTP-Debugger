/**
 * REST-HTTP-Debugger
 * @author limao (limao777@126.com)
 * @license BSD 3-Clause, http://opensource.org/licenses/BSD-3-Clause
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace web_request_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string WebRequest(string method, string url, string postData)
        {
            HttpWebRequest webRequest = null;
            StreamWriter requestWriter = null;
            string responseData = "";

            webRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
            webRequest.Method = method.ToString();
            webRequest.ServicePoint.Expect100Continue = false;
            webRequest.UserAgent  = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.93 Safari/537.36";
            if (tb_timeout.Text != "" && tb_timeout.Text != "0")
            {
                webRequest.Timeout = Convert.ToInt32(tb_timeout.Text);
            }

            if (tb_header_ext.Text != "")
            {
                webRequest.Headers.Add(tb_header_ext.Text);
            }

            if (method == "POST" || method == "PUT")
            {
                if (method == "PUT")
                {
                    webRequest.ContentType = "text/xml";
                    webRequest.Method = "PUT";
                }
                else
                    webRequest.ContentType = "application/x-www-form-urlencoded";
                //webRequest.ContentType = "multipart/form-data";

                //POST the data.
                requestWriter = new StreamWriter(webRequest.GetRequestStream());
                try
                {
                    requestWriter.Write(postData);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    requestWriter.Close();
                    requestWriter = null;
                }
            }

            responseData = WebResponseGet(webRequest);

            webRequest = null;

            return responseData;

        }

        public string WebResponseGet(HttpWebRequest webRequest)
        {
            StreamReader responseReader = null;
            string responseData = "";

            try
            {
                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                responseData = responseReader.ReadToEnd();


                webRequest.GetResponse().GetResponseStream().Close();
                responseReader.Close();
                responseReader = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {               
                
            }

            return responseData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_info.Text = "开始……";

            Thread th_request;
            th_request = new Thread((ThreadStart)delegate()
            {
                do_th_request();
            });
            th_request.Start();

            lb_info.Text = "处理中……";
        }

        private void do_th_request()
        {



                string res = WebRequest(tb_method.Text, tb_url.Text, tb_post_data.Text);
                //       textBox1.Text = res;


                webBrowser1.ScriptErrorsSuppressed = true; //关闭脚本错误提示
                webBrowser1.DocumentText = res;

                //webBrowser1.Document.Write(res);
                webBrowser1.Refresh();
                this.Invoke((MethodInvoker)delegate()
                {
                    tb_wb1.Text = res + "";
                    lb_info.Text = "完成!";
                });

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (ck_tb.Checked == true)
            {
                tb_wb1.Visible = true;
            }
            else {
                tb_wb1.Visible = false;
            }
            if (File.Exists("env.ini")) {
                StreamReader br = new StreamReader("env.ini");
                try
                {
                    tb_url.Text = br.ReadLine();
                    tb_header_ext.Text = br.ReadLine();
                    tb_method.Text = br.ReadLine();
                    tb_timeout.Text = br.ReadLine();
                    tb_post_data.Text = br.ReadLine();

                }
                catch { }
                finally
                {
                    br.Close();
                    br.Dispose();
                }
            }
        }

        private void ck_tb_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_tb.Checked == true)
            {
                tb_wb1.Visible = true;
            }
            else
            {
                tb_wb1.Visible = false;
            }
        }







    }
}
