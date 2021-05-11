using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTT.Areas.NguoiDangBai.Models;
using PagedList;


namespace QLTT.Areas.NguoiDangBai.Controllers
{
    public class ListFileHistoryController : Controller
    {
        /*
         
        // GET: NguoiDangBai/ListFileHistory
        //private WebTinTucEntities4 db = new WebTinTucEntities4();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListHistory(int? page)
        {
            // 1. Tham số int? dùng để thể hiện null và kiểu int
            // page có thể có giá trị là null và kiểu int.

            // 2. Nếu page = null thì đặt lại là 1.
            if (page == null) page = 1;

            // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
            // theo LinkID mới có thể phân trang.
            var links = (from l in db.TINTUCs
                         select l).OrderBy(x => x.MaTinTuc);

            // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
            int pageSize = 3;

            // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            int pageNumber = (page ?? 1);

            // 5. Trả về các Link được phân trang theo kích thước và số trang.
            return View(links.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Searchlist(string searchstring)
        {
            var links = from l in db.TINTUCs
                        select l;

            if (!String.IsNullOrEmpty(searchstring))
            {
                links = links.Where(s => s.TieuDe.Contains(searchstring));
            }

            return View(links);
        }
        */
    }
}