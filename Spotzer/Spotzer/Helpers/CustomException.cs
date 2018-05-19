using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Helpers
{
    public class CustomException : System.Exception
    {
        public int ErrorCode = Constants.StatusCode.kErrorDefault;

        public CustomException()
            : base()
        {
        }

        public CustomException(string message, int code)
            : base(message)
        {
            this.ErrorCode = code;
        }
        public CustomException(string message, Exception inner, int code)
            : base(message, inner)
        {
            this.ErrorCode = code;
        }
    }
}