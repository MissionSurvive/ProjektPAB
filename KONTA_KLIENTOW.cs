//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental
{
    using System;
    using System.Collections.Generic;
    
    public partial class KONTA_KLIENTOW
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KONTA_KLIENTOW()
        {
            this.KLIENCI = new HashSet<KLIENCI>();
        }
    
        public decimal iD_KON_KLIENT { get; set; }
        public decimal ID_ROLA { get; set; }
        public decimal ID_KLIENT { get; set; }
        public string NAZWA_KLIENT { get; set; }
        public string HASLO_KLIENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KLIENCI> KLIENCI { get; set; }
        public virtual KLIENCI KLIENCI1 { get; set; }
        public virtual ROLE ROLE { get; set; }
    }
}
