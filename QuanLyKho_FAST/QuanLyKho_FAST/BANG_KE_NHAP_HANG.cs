//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho_FAST
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANG_KE_NHAP_HANG
    {
        public string MA_BK { get; set; }
        public Nullable<System.DateTime> NGAY_KE { get; set; }
        public string MA_HH { get; set; }
        public string MA_NCC { get; set; }
        public Nullable<int> SO_LUONG { get; set; }
        public Nullable<int> DON_GIA { get; set; }
        public Nullable<int> TIEN { get; set; }
        public string GHI_CHU { get; set; }
        public Nullable<bool> TRANG_THAI { get; set; }
    
        public virtual HANG_HOA HANG_HOA { get; set; }
        public virtual NHA_CUNG_CAP NHA_CUNG_CAP { get; set; }
    }
}
