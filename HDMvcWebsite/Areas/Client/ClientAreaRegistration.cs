using System.Web.Mvc;

namespace HDMvcWebsite.Areas.Client
{
    public class ClientAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Client";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Client_Default",
                "Client/{controller}/{action}/{Id}",
                new { controller = "Home", action = "Index", Id = UrlParameter.Optional });
        }
    }
}
