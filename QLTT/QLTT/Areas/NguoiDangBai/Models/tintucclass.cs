using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLTT.Areas.NguoiDangBai.Models
{
    public class tintucclass
    {
        public int MaTinTuc
        {
            get;
            set;
        }
        public string TieuDe
        {
            get;
            set;
        }
        public string MaTheLoai
        {
            get;
            set;
        }
        public string MaLoaiTin
        {
            get;
            set;
        }
        public string MoTa
        {
            get;
            set;
        }
        public string TacGia
        {
            get;
            set;
        }
        public string TrangThai
        {
            get;
            set;
        }
        public HttpPostedFileBase LinkFile
        {
            get;
            set;
        }
    }
}