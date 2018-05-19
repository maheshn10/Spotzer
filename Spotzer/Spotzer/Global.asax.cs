using AutoMapper;
using Spotzer.Data;
using Spotzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Spotzer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Order, tbl_order>();
                cfg.CreateMap<LineItem, tbl_lineitem>();
                cfg.CreateMap<WebsiteDetails, tbl_websitedetails>();
                cfg.CreateMap<AdWordCampaign, tbl_adwordcampaign>();
            });
        }
    }
}
