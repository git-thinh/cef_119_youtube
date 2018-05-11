using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cef_119
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             
            if (!CEF.Initialize(new Settings()))
            {
                if (Environment.GetCommandLineArgs().Contains("--type=renderer"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    return;
                }
            } 
            Application.Run(new BrowserForm());
        }
    }
}
