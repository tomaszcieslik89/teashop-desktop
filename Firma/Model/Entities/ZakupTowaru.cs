//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firma.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZakupTowaru
    {
        public int IdZakupuTowaru { get; set; }
        public Nullable<int> IdDokumentuSprzedazy { get; set; }
        public Nullable<int> IdDodatkowe { get; set; }
        public Nullable<int> IdKontrahenta { get; set; }
        public Nullable<int> IdTowaru { get; set; }
        public Nullable<int> IdRabatu { get; set; }
        public Nullable<int> IdSposobuPlatnosci { get; set; }
        public Nullable<int> IdRodzajuDokumentow { get; set; }
        public Nullable<int> IdPlatnosci { get; set; }
        public Nullable<int> IdSzczegolyTowaru { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
    
        public virtual Dodatkowe Dodatkowe { get; set; }
        public virtual DokumentSprzedazy DokumentSprzedazy { get; set; }
        public virtual Kontrahent Kontrahent { get; set; }
        public virtual Platnosci Platnosci { get; set; }
        public virtual Rabat Rabat { get; set; }
        public virtual RodzajDokumentu RodzajDokumentu { get; set; }
        public virtual SposobPlatnosci SposobPlatnosci { get; set; }
        public virtual SzczegolyTowaru SzczegolyTowaru { get; set; }
        public virtual Towar Towar { get; set; }
    }
}
