//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Otag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Otag()
        {
            this.tbl_Rezerv = new HashSet<tbl_Rezerv>();
        }
    
        public int Id { get; set; }
        public string OtagNomre { get; set; }
        public Nullable<int> Musteri_sayi { get; set; }
        public Nullable<int> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Rezerv> tbl_Rezerv { get; set; }
    }
}
