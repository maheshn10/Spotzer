using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Net.Http;
using Spotzer.Tests.Models;
using NUnit.Framework;
using Spotzer.Tests.Helpers;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using System.Net;

namespace Spotzer.Tests.Steps
{
    [Binding]
    public sealed class PlaceOrderSteps
    {
        private HttpResponseMessage _responseContent;
        private Order _order = new Order();
        private LineItem _lineItem = new LineItem();
        private WebsiteDetails _websiteDetails = new WebsiteDetails();
        private AdWordCampaign _adWordCampaign = new AdWordCampaign();

        [Given(@"I create a new Order")]
        public void GivenICreateANewOrder(Table table)
        {
            table.FillInstance(_order);
            var client = new HttpClient();
            var postData = StepHelpers.SetPostData<Order>(_order);
            HttpContent content = new FormUrlEncodedContent(postData);
            _responseContent = client.PostAsync("http://localhost:8089/api/PlaceOrder", content).Result;
            //ScenarioContext.Current.Pending();
        }

        [Given(@"The Line Item Exist")]
        public void GivenTheLineItemExist(Table table)
        {            
            table.FillInstance(_lineItem);
        }

        [Given(@"The WebsiteDetails Exist")]
        public void GivenTheWebsiteDetailsExist(Table table)
        {
            table.FillInstance(_websiteDetails);
        }

        [Given(@"The AdWordCampaign Exist")]
        public void GivenTheAdWordCampaignExist(Table table)
        {
            table.FillInstance(_adWordCampaign);
        }

        [Given(@"ModelState is correct")]
        public void GivenModelStateIsCorrect()
        {
            Assert.That(() => !string.IsNullOrEmpty(_order.Partner));
            Assert.That(() => !string.IsNullOrEmpty(_order.OrderID));
            Assert.That(() => !string.IsNullOrEmpty(_order.TypeOfOrder));
            Assert.That(() => !string.IsNullOrEmpty(_order.SubmittedBy));
            Assert.That(() => !string.IsNullOrEmpty(_order.CompanyID));
            Assert.That(() => !string.IsNullOrEmpty(_order.CompanyName));
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the system should return order success message")]
        public void ThenTheSystemShouldReturnOrderSuccessMessage()
        {
            //Task<string> result = _responseContent.Content.ReadAsStringAsync();
            //var _resultstring = new JavaScriptSerializer().Serialize(_responseContent.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(_responseContent.StatusCode, HttpStatusCode.Created);
        }

    }
}
