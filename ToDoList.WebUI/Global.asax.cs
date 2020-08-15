using Core.Utilities.MVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ToDoList.Business.DependencyResolvers.Ninject;

namespace ToDoList.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));

            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
