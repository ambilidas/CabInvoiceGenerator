using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    //Class for custom exception handling
    public class CabInvoiceException : Exception
    {
        //Enum for exception type
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID

        }
        ExceptionType type;

        //Parameter constructor for setting exception and throwing exception
        public CabInvoiceException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }

    }
}
