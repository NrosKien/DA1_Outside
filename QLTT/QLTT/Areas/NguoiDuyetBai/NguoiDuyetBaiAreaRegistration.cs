using System.Web.Mvc;

namespace QLTT.Areas.NguoiDuyetBai
{
    public class NguoiDuyetBaiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NguoiDuyetBai";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NguoiDuyetBai_default",
                "NguoiDuyetBai/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}