using System;

namespace Firma.Model.EntitiesForView
{
    public class ListaDokumentowForAllView
    {
        public int IdDokumentuSprzedazy { get; set; }
        public DateTime? DokumentTerminPlatnosci { get; set; }
        public DateTime? DokumentDataWystawienia { get; set; }
        public string DokumentSposobuPlatnosciNazwa { get; set; }   
        public string DokumentNumerDokumentu { get; set; }                              
        public string NIP { get; set; }
        public string DokumentDodatkoweNazwa { get; set; }
        public string DokumentDodatkoweDodatkowe { get; set; }
        public string DokumentDodatkoweUwagi { get; set; }
        public int? DokumentPozycjaDokumentu { get; set; }
        //test
        public string DokumentRodzajDokumentu { get; set; }
        public string DokumentDodatkoweImie { get; set; }
        public string DokumentDodatkoweNazwisko { get; set; }
        public string DokumentDodatkoweEmail{ get; set; }
        public decimal? DokumentDodatkoweRabat{ get; set; }
        public decimal? IloscTowaru{ get; set; }
        public string NazwaTowaru{ get; set; }

    }
}



