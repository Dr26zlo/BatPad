using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

internal class Starter
{
    [STAThread]
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}