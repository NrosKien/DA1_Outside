//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DUYETTIN
    {
        public int MaDuyetTin { get; set; }
        public Nullable<System.DateTime> NgayDuyet { get; set; }
        public Nullable<int> MaDangTin { get; set; }
        public string TrangThai { get; set; }
        public System.DateTime NgayDuocDang { get; set; }
    
        public virtual DANGTIN DANGTIN { get; set; }
    }
}
