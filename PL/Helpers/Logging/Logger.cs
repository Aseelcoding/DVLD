using System;
using System.IO;
using System.Text;

namespace PL.Helpers.Logging
{
    public class Logger
    {
        private static readonly string LogDirectory =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "DVLD",
                "Logs"
            );

        private static readonly object LockObject = new object();

        public static void Write(Exception ex)
        {
            try
            {
                if (ex == null)
                    return;

                lock (LockObject)
                {
                    if (!Directory.Exists(LogDirectory))
                    {
                        Directory.CreateDirectory(LogDirectory);
                    }

                    string fileName =
                        "Log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

                    string filePath =
                        Path.Combine(LogDirectory, fileName);

                    string logEntry =
                        "========================================\r\n" +
                        "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n" +
                        "Exception Type: " + ex.GetType().FullName + "\r\n" +
                        "Message: " + ex.Message + "\r\n" +
                        "Details:\r\n" + ex.ToString() + "\r\n" +
                        "========================================\r\n\r\n";

                    File.AppendAllText(
                        filePath,
                        logEntry,
                        Encoding.UTF8
                    );
                }
            }
            catch
            {
                // Prevent logging failures from crashing the application.
            }
        }
    }
}