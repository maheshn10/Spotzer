//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spotzer.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_order
    {
        public int ID { get; set; }
        public string Partner { get; set; }
        public string OrderID { get; set; }
        public string TypeOfOrder { get; set; }
        public string SubmittedBy { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string ExposureID { get; set; }
        public string UDAC { get; set; }
        public string RelatedOrder { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
