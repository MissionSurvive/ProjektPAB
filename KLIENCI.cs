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
    
    public partial class KLIENCI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KLIENCI()
        {
            this.HISTORIA_ZAMOWIENIA = new HashSet<HISTORIA_ZAMOWIENIA>();
            this.ZAMOWIENIA = new HashSet<ZAMOWIENIA>();
            this.KONTA_KLIENTOW1 = new HashSet<KONTA_KLIENTOW>();
        }
    
        public decimal ID_KLIENT { get; set; }
        public Nullable<decimal> iD_KON_KLIENT { get; set; }
        public string IMIE_KLIENT { get; set; }
        public string NAZWISKO_KLIENT { get; set; }
        public string PESEL_KLIENT { get; set; }
        public string TELEFON_KLIENT { get; set; }
        public string FAX { get; set; }
        public Nullable<decimal> NIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIA_ZAMOWIENIA> HISTORIA_ZAMOWIENIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZAMOWIENIA> ZAMOWIENIA { get; set; }
        public virtual KONTA_KLIENTOW KONTA_KLIENTOW { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KONTA_KLIENTOW> KONTA_KLIENTOW1 { get; set; }
    }
}
