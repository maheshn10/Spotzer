using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Models
{
    public class Status
    {
        /// <summary>
        /// Refer Spotzer.Constants.StatusCode
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// The message will vary in furture. Please use the Code for conditional operations. Refer Spotzer.Constants.StatusMessage
        /// </summary>
        public string Message { get; set; }
    }
}