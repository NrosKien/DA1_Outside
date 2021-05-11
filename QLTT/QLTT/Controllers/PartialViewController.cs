using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTT.Models;

namespace QLTT.Controllers
{
    public class PartialViewController : Controller
    {
        TTEntities db = new TTEntities();
        // GET: PartialView
        public ActionResult _Carousel()
        {
            var query = from t in db.TINTUCs
                        where t.MaLoaiTin == "LT2"
                        select t;
            return PartialView(query.Take(3));
        }
        public ActionResult _TinTucSidebar()
        {
            var query = from t in db.TINTUCs
                        where (DateTime.Now.Day - t.Ngay_TinTuc.Value.Day) <= 7
                        select t;
            return PartialView(query.Take(3));
        }
        public ActionResult _TinTucFooter()
        {
            return PartialView(db.TINTUCs.ToList().Take(3));
        }
        public ActionResult _MucLuc()
        {
            var query = db.THELOAIs.ToList();
            return PartialView(query);
        }
        public ActionResult _TheLoaiSidebar ()
        {
            var query = db.THELOAIs.ToList();
            return PartialView(query);
        }
        public ActionResult _TinTucTheoTheLoai ()
        {
            var query = db.TINTUCs.ToList();
            return PartialView(query.Take(3));
        }
    }
}