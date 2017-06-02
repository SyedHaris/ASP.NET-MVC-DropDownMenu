using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;

namespace DropDownTest
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);;
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Add", id = UrlParameter.Optional });
        }
        
    }
}