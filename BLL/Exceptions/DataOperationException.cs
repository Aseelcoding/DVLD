using System;

namespace BLL.Exceptions
{
    public class DataOperationException : Exception
    {
        public DataOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}