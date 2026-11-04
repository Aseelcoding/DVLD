using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Helpers.Logging;

namespace PL.Helpers
{
    public static class GlobalExceptionHandler
    {
        public static void Register()
        {
            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException
            );

            Application.ThreadException +=
                Application_ThreadException;

            AppDomain.CurrentDomain.UnhandledException +=
                CurrentDomain_UnhandledException;

            TaskScheduler.UnobservedTaskException +=
                TaskScheduler_UnobservedTaskException;
        }

        private static void Application_ThreadException(
            object sender,
            System.Threading.ThreadExceptionEventArgs e)
        {
            ErrorHandler.Show(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(
            object sender,
            UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;

            if (ex != null)
            {
                Logger.Write(ex);
            }
            else
            {
                Logger.Write(
                    new Exception("An unknown unhandled exception occurred.")
                );
            }
        }

        private static void TaskScheduler_UnobservedTaskException(
            object sender,
            UnobservedTaskExceptionEventArgs e)
        {
            Logger.Write(e.Exception);
            e.SetObserved();
        }
    }
}