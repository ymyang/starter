using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace starter
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = Path.Combine(Application.StartupPath, "yliyun.exe");

            string arg = Path.Combine(Application.StartupPath, "app.nw");
            foreach (string str in args)
            {
                arg = arg + " " + str;
            }
            proc.StartInfo.Arguments = arg;
            // proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            proc.Start();
        }
    }
}
