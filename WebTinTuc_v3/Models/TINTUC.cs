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
    
    public partial class TINTUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINTUC()
        {
            this.DANGTINTUCs = new HashSet<DANGTINTUC>();
            this.DUYETTINs = new HashSet<DUYETTIN>();
            this.HINHs = new HashSet<HINH>();
            this.SUATINs = new HashSet<SUATIN>();
            this.TUKHOAs = new HashSet<TUKHOA>();
        }
    
        public int MaTinTuc { get; set; }
        public string TieuDe { get; set; }
        public string MaTheLoai { get; set; }
        public string MaLoaiTin { get; set; }
        public string LinkFile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGTINTUC> DANGTINTUCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DUYETTIN> DUYETTINs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HINH> HINHs { get; set; }
        public virtual LOAITIN LOAITIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUATIN> SUATINs { get; set; }
        public virtual THELOAI THELOAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUKHOA> TUKHOAs { get; set; }
    }
}
