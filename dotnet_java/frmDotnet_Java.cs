using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dotnet_java
{
    public partial class frmDotnet_Java : Form
    {
        public frmDotnet_Java()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "\"c:\\Program Files\\Java\\jdk-19\\bin\\java.exe\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.WorkingDirectory = Application.StartupPath;
            startInfo.Arguments = $"duycop {textBox1.Text} {textBox2.Text}";
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    while (!exeProcess.StandardOutput.EndOfStream)
                    {
                        string line = exeProcess.StandardOutput.ReadLine();
                        // do something with line
                        txtKQ.AppendText(line + "\r\n");
                    }
                }
            }
            catch(Exception ex)
            {
                txtKQ.AppendText($"ERROR: {ex.Message}");
            }
        }
    }
}
