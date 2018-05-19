using Spotzer.Business;
using Spotzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spotzer.Controllers
{
    public class PlaceOrderController : ApiController
    {
        /// <summary>
        /// This API is used to place the order for different type of products like website, paid search, etc.
        /// </summary>
        /// <param name="Order">This will have the placement details and the list of products of the order like Partner, OrderID, TypeOfOrder, etc. as an object</param>
        /// <returns></returns>
        public Status Post([FromBody]Order Order)
        {
            return OrderManager.PlaceOrder(Order);
        }
    }
}
