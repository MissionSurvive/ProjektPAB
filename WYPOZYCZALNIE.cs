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
    
    public partial class WYPOZYCZALNIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WYPOZYCZALNIE()
        {
            this.SAMOCHODY = new HashSet<SAMOCHODY>();
            this.PRACOWNICY = new HashSet<PRACOWNICY>();
            this.ZAMOWIENIA = new HashSet<ZAMOWIENIA>();
        }
    
        public decimal ID_WYPOZYCZALNIA { get; set; }
        public string MIASTO { get; set; }
        public string ADRES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAMOCHODY> SAMOCHODY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRACOWNICY> PRACOWNICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZAMOWIENIA> ZAMOWIENIA { get; set; }
    }
}