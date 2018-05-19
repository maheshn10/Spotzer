using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Tests.Models
{
    public class LineItem
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductType { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public WebsiteDetails WebsiteDetails { get; set; }
        public AdWordCampaign AdWordCampaign { get; set; }
    }
}
