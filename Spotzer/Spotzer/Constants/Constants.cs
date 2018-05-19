using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Constants
{
    public class Constants
    {
    }

    /// <summary>
    /// Custom output status code on calling the API methods
    /// </summary>
    public struct StatusCode
    {
        public const int kSuccessDefault = 200;
        public const int kSuccessInserted = 201;

        public const int kErrorDefault = 300;
        public const int kErrorOrderExists = 301;
    }

    /// <summary>
    /// Custom output status message on calling the API methods
    /// </summary>
    public struct StatusMessage
    {        
        public const string Inserted = @"Inserted Successfully.";
        public const string OrderExist = @"Order Exists.";
        public const string Error = @"Error.";
        public const string EmptyString = @"";
    }
}