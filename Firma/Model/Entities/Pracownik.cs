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
    
    public partial class Pracownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownik()
        {
            this.PlanUrlopu = new HashSet<PlanUrlopu>();
            this.Wynagrodzenie = new HashSet<Wynagrodzenie>();
        }
    
        public int IdPracownika { get; set; }
        public Nullable<decimal> IdWynagrodzenie { get; set; }
        public Nullable<int> IdDanePersonalne { get; set; }
        public Nullable<int> IdAdresu { get; set; }
        public Nullable<int> IdBanku { get; set; }
        public Nullable<int> IdStanowiskoPracownika { get; set; }
        public Nullable<int> IdUrlopu { get; set; }
        public Nullable<int> IdZatrudnienia { get; set; }
        public Nullable<int> IdPlci { get; set; }
        public Nullable<int> IdUzytkownika { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
        public string ImieP { get; set; }
        public string DrugieImieP { get; set; }
        public string NazwiskoP { get; set; }
        public string NazwiskoRodoweP { get; set; }
        public string ImieOjcaP { get; set; }
        public string ImieMatkiP { get; set; }
        public string NrPaszportuP { get; set; }
        public Nullable<decimal> PESELP { get; set; }
        public string TelefonP { get; set; }
        public string EmailP { get; set; }
        public Nullable<System.DateTime> DataUrodzeniaP { get; set; }
        public string PowiatP { get; set; }
        public string MiejscowoscP { get; set; }
        public string UlicaP { get; set; }
        public string GminaP { get; set; }
        public string KodPocztowyP { get; set; }
        public string NrDomuP { get; set; }
        public string NrLokaluP { get; set; }
        public Nullable<System.DateTime> DataZatrudnieniaP { get; set; }
        public Nullable<System.DateTime> DataRozpPracyP { get; set; }
        public Nullable<System.DateTime> DataZwolnieniaP { get; set; }
        public string WymiarEtatuP { get; set; }
        public Nullable<decimal> StawkaP { get; set; }
        public Nullable<decimal> LimitUrlopuP { get; set; }
        public Nullable<decimal> DodatkoweDniUrlopuP { get; set; }
        public Nullable<decimal> WykorzystanoP { get; set; }
        public Nullable<decimal> PozostaloP { get; set; }
        public string KrajP { get; set; }
        public string PlecP { get; set; }
        public string WojewodzctwoP { get; set; }
        public string RodzajUmowyP { get; set; }
        public string RodzajZatrudnieniaP { get; set; }
        public string StanowiskoP { get; set; }
    
        public virtual Adres Adres { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual DanePersonalne DanePersonalne { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanUrlopu> PlanUrlopu { get; set; }
        public virtual Plec Plec { get; set; }
        public virtual StanowiskoPracownika StanowiskoPracownika { get; set; }
        public virtual Urlop Urlop { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }
        public virtual Zatrudnienie Zatrudnienie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wynagrodzenie> Wynagrodzenie { get; set; }
    }
}
