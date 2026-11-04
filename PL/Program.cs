using PL.Helpers;
using System;
using System.Windows.Forms;

namespace PL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalExceptionHandler.Register();

            Application.Run(new frmMain());
        }
    }
}