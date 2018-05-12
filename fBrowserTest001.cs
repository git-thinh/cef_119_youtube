using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace cef_119
{
    public partial class fBrowserTest001 : Form, IRequestHandler
    {
        private readonly WebView web_view;
        //const string url = "https://www.google.com/maps";
        //const string url = "http://web20office.com/crm/demo/system/login.php?r=/crm/demo";
        //const string url = "file:///G:/_EL/Document/data_el2/book/84-cau-truc-va-cau-vi-du-thong-dung-trong-tieng-anh-giao-tiep.pdf";
        //const string url = "https://get.adobe.com/flashplayer/";
        //const string url = "http://localhost:56066/htmlcss2-master/jwplayer/readme.html";
        const string url = "http://demo.filedeo.stream/drive/";

        public fBrowserTest001()
        {
            InitializeComponent();
            web_view = new WebView(url, new BrowserSettings());
            web_view.Dock = DockStyle.Fill;
            web_view.RequestHandler = this;
            this.Controls.Add(web_view);
            this.WindowState = FormWindowState.Maximized;
            this.Text = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: x86", CEF.ChromiumVersion, CEF.CefVersion, CEF.CefSharpVersion);
        }

        #region IRequestHandler Members

        bool IRequestHandler.OnBeforeBrowse(IWebBrowser browser, IRequest request, NavigationType naigationvType, bool isRedirect)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeBrowse");
            return false;
        }

        bool IRequestHandler.OnBeforeResourceLoad(IWebBrowser browser, IRequestResponse requestResponse)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeResourceLoad");
            IRequest request = requestResponse.Request;

            ////if (request.Url.EndsWith("header.png"))
            ////{
            ////    MemoryStream stream = new System.IO.MemoryStream();

            ////    FileStream file = new FileStream(@"C:\tmp\header.png", FileMode.Open, FileAccess.Read, FileShare.Read);
            ////    byte[] bytes = new byte[file.Length];
            ////    file.Read(bytes, 0, (int)file.Length);
            ////    stream.Write(bytes, 0, (int)file.Length);
            ////    file.Close();

            ////    requestResponse.RespondWith(stream, "image/png");
            ////}


            string url = request.Url.ToLower();
            MemoryStream stream;
            byte[] bytes;
            switch (url)
            {
                case "http://i.ytimg.com/crossdomain.xml":
                    stream = new MemoryStream();
                    bytes = System.Text.ASCIIEncoding.UTF8.GetBytes("");
                    stream.Write(bytes, 0, bytes.Length);
                    requestResponse.RespondWith(stream, "image/jpeg");

                    break;
                case "http://www.youtube.com/apiplayer":
                    stream = new System.IO.MemoryStream();
                    bytes = System.Text.ASCIIEncoding.UTF8.GetBytes("");
                    stream.Write(bytes, 0, bytes.Length);
                    requestResponse.RespondWith(stream, "text/html; charset=utf-8");
                    break;
            }


            return false;
        }

        void IRequestHandler.OnResourceResponse(IWebBrowser browser, string url, int status, string statusText, string mimeType, WebHeaderCollection headers)
        {
            System.Diagnostics.Debug.WriteLine("OnResourceResponse");
        }

        #endregion
    }
}

