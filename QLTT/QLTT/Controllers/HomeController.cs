using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTT.Models;

namespace QLTT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        TTEntities db = new TTEntities();
        public ActionResult Index(string theLoai)
        {
            if (theLoai == null)
            {
                var tinTucList = db.TINTUCs.OrderByDescending(x => (DateTime.Now.Day - x.Ngay_TinTuc.Value.Day) <= 7);
                return View(tinTucList);
            }
            else
            {
                var tinTucList = db.TINTUCs.OrderByDescending(x => (DateTime.Now.Day - x.Ngay_TinTuc.Value.Day) <= 7).Where(x => x.MaTheLoai == theLoai);
                return View(tinTucList);
            }
            //return View(db.TINTUCs.ToList());
        }
        public ActionResult ChiTiet(int? id)
        {
            return View(db.TINTUCs.Where(s => s.MaTinTuc == id).FirstOrDefault());
        }
        //----------------------------------------The loai--------------------------------------
        public ActionResult Single()
        {
            return View();
        }
        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult TheGioi()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL1"));
        }
        public ActionResult ChinhTri()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL2"));
        }
        public ActionResult TheThao()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL3"));
        }
        public ActionResult GiaiTri()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL4"));
        }
        public ActionResult SucKhoe()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL5"));
        }
        public ActionResult KhoaHoc_CongNghe()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL6"));
        }
        public ActionResult Esports()
        {
            return View(db.TINTUCs.ToList().Where(s => s.MaTheLoai == "TL7"));
        }
        //----------------------------------------The loai--------------------------------------
    }
}