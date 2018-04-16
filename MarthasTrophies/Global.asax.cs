using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace MarthasTrophies
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            //System.Data.Entity.Database.SetInitializer(new MarthasTrophies.Models.);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
