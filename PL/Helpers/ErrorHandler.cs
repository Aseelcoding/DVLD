using System;
using System.Windows.Forms;
using P_Exceptions;
using PL.Helpers.Logging;

namespace PL.Helpers
{
    public static class ErrorHandler
    {
        public static void Show(Exception ex, string title = "DVLD")
        {
            if (ex == null)
                return;

            if (ex is ValidationException ||
                ex is BusinessRuleException)
            {
                MessageBox.Show(
                    ex.Message,
                    title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else if (ex is DataOperationException)
            {
                Logger.Write(ex);

                MessageBox.Show(
                    ex.Message,
                    title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                Logger.Write(ex);

                MessageBox.Show(
                    "An unexpected error occurred. " +
                    "The details have been saved to the log file.",
                    title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}