//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunStokUygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_urun()
        {
            this.tbl_satıs = new HashSet<tbl_satıs>();
        }
    
        public int urunıd { get; set; }
        public string urunad { get; set; }
        public string urunmarka { get; set; }
        public Nullable<short> stok { get; set; }
        public Nullable<decimal> fıyat { get; set; }
        public Nullable<bool> durum { get; set; }
        public Nullable<int> kategorı { get; set; }
    
        public virtual tbl_kategori tbl_kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_satıs> tbl_satıs { get; set; }
    }
}
