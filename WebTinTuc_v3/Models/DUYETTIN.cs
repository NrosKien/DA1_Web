//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebTinTuc_v3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DUYETTIN
    {
        public string MaDuyetTin { get; set; }
        public System.DateTime ThoiGianDuyet { get; set; }
        public int MaTinTuc { get; set; }
    
        public virtual TINTUC TINTUC { get; set; }
    }
}
