using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppGPTB2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}