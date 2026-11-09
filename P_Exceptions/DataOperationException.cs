using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Exceptions
{
    public class DataOperationException : Exception
    {
        public DataOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
