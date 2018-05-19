using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Tests.Models
{

    public class Order
    {
        public string Partner { get; set; }
        public string OrderID { get; set; }
        public string TypeOfOrder { get; set; }
        public string SubmittedBy { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public object ContactFirstName { get; set; }
        public object ContactLastName { get; set; }
        public object ContactTitle { get; set; }
        public object ContactPhone { get; set; }
        public object ContactMobile { get; set; }
        public object ContactEmail { get; set; }
        public object ExposureID { get; set; }
        public object UDAC { get; set; }
        public object RelatedOrder { get; set; }
        public List<LineItem> LineItems { get; set; }
    }   
}
