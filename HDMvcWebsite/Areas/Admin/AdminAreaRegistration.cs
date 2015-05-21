using System.Web.Mvc;

namespace HDMvcWebsite.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_Default",
                "Admin/{controller}/{action}/{Id}",
                new { controller = "ManageAccount", action = "Login", Id = UrlParameter.Optional },
                new[] { "HDMvcWebsite.Areas.Admin.Controllers" }
            );

        }
    }
}
