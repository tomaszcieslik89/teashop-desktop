﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TeaShopEntities : DbContext
    {
        public TeaShopEntities()
            : base("name=TeaShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<CMSAktualnosc> CMSAktualnosc { get; set; }
        public virtual DbSet<CMSParametr> CMSParametr { get; set; }
        public virtual DbSet<CMSStrona> CMSStrona { get; set; }
        public virtual DbSet<DaneLogowania> DaneLogowania { get; set; }
        public virtual DbSet<DanePersonalne> DanePersonalne { get; set; }
        public virtual DbSet<Dodatkowe> Dodatkowe { get; set; }
        public virtual DbSet<DokumentSprzedazy> DokumentSprzedazy { get; set; }
        public virtual DbSet<DokumentSprzedazyTowar> DokumentSprzedazyTowar { get; set; }
        public virtual DbSet<KategoriaTowaru> KategoriaTowaru { get; set; }
        public virtual DbSet<Kontrahent> Kontrahent { get; set; }
        public virtual DbSet<KoszykTemp> KoszykTemp { get; set; }
        public virtual DbSet<Kraj> Kraj { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<PlanUrlopu> PlanUrlopu { get; set; }
        public virtual DbSet<PlatnoscBlikiem> PlatnoscBlikiem { get; set; }
        public virtual DbSet<PlatnoscDoDostawcy> PlatnoscDoDostawcy { get; set; }
        public virtual DbSet<PlatnoscGotowka> PlatnoscGotowka { get; set; }
        public virtual DbSet<Platnosci> Platnosci { get; set; }
        public virtual DbSet<PlatnoscKarta> PlatnoscKarta { get; set; }
        public virtual DbSet<PlatnoscOdKontrahenta> PlatnoscOdKontrahenta { get; set; }
        public virtual DbSet<PlatnoscPrzelewem> PlatnoscPrzelewem { get; set; }
        public virtual DbSet<Plec> Plec { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Producent> Producent { get; set; }
        public virtual DbSet<Rabat> Rabat { get; set; }
        public virtual DbSet<Reklamacje> Reklamacje { get; set; }
        public virtual DbSet<RodzajDokumentu> RodzajDokumentu { get; set; }
        public virtual DbSet<RodzajUmowy> RodzajUmowy { get; set; }
        public virtual DbSet<RodzajWolnego> RodzajWolnego { get; set; }
        public virtual DbSet<RodzajZatrudnienia> RodzajZatrudnienia { get; set; }
        public virtual DbSet<SklepElementKoszyka> SklepElementKoszyka { get; set; }
        public virtual DbSet<SklepRodzaj> SklepRodzaj { get; set; }
        public virtual DbSet<SklepTowar> SklepTowar { get; set; }
        public virtual DbSet<SortowanieDokumentow> SortowanieDokumentow { get; set; }
        public virtual DbSet<SortowaniePracownikow> SortowaniePracownikow { get; set; }
        public virtual DbSet<SortowanieReklamacji> SortowanieReklamacji { get; set; }
        public virtual DbSet<SortowanieTowaru> SortowanieTowaru { get; set; }
        public virtual DbSet<SortowanieUrlopow> SortowanieUrlopow { get; set; }
        public virtual DbSet<SortowanieUzytkownikow> SortowanieUzytkownikow { get; set; }
        public virtual DbSet<SposobPlatnosci> SposobPlatnosci { get; set; }
        public virtual DbSet<StanowiskoPracownika> StanowiskoPracownika { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SzczegolyTowaru> SzczegolyTowaru { get; set; }
        public virtual DbSet<Towar> Towar { get; set; }
        public virtual DbSet<TypKontrahenta> TypKontrahenta { get; set; }
        public virtual DbSet<Urlop> Urlop { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<VAT> VAT { get; set; }
        public virtual DbSet<Wojewodzctwo> Wojewodzctwo { get; set; }
        public virtual DbSet<Wynagrodzenie> Wynagrodzenie { get; set; }
        public virtual DbSet<ZadanieReklamujacego> ZadanieReklamujacego { get; set; }
        public virtual DbSet<ZakresWyszukiwaniaDaty> ZakresWyszukiwaniaDaty { get; set; }
        public virtual DbSet<ZakupTowaru> ZakupTowaru { get; set; }
        public virtual DbSet<Zatrudnienie> Zatrudnienie { get; set; }
    }
}