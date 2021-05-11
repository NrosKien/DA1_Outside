using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTT.Areas.NguoiDangBai.Models;
using System.IO;
using System.Data.Entity.Validation;

namespace QLTT.Areas.NguoiDangBai.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: NguoiDangBai/FileUpload

           /*
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(tintucclass news)
        {
            try {
                using (WebTinTucEntities4 entity = new WebTinTucEntities4())
                {
                    var tintuc = new TINTUC
                    {
                        MaTinTuc = news.MaTinTuc,
                        MaTheLoai = news.MaTheLoai,
                        MaLoaiTin = news.MaLoaiTin,
                        TieuDe = news.TieuDe,
                        MoTa = news.MoTa,
                        LinkFile = SaveToPhysicalLocation(news.LinkFile),
                        TacGia = news.TacGia,
                        TrangThai = news.TrangThai,
                        NgayDang = DateTime.Now
                    };
                    entity.TINTUCs.Add(tintuc);
                    entity.SaveChanges();
                }
                return View(news);
                
            }
          
                catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        


        /// <summary>  
        /// Save Posted File in Physical path and return saved path to store in a database  
        /// </summary>  
        /// <param name="file"></param>  
        /// <returns></returns>  
        private string SaveToPhysicalLocation(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                file.SaveAs(path);
                return path;
            }
            return string.Empty;
        }
        */
    }
}
