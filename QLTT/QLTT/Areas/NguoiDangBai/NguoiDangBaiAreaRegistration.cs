using System.Web.Mvc;

namespace QLTT.Areas.NguoiDangBai
{
    public class NguoiDangBaiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NguoiDangBai";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NguoiDangBai_default",
                "NguoiDangBai/{controller}/{action}/{id}",
                new { action = "Index", controller="Home",id = UrlParameter.Optional }
            );
        }
    }
}