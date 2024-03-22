using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Firma.Model.EntitiesForView
{//dbo.Towar            nazwa TowarForAllView (lista towarów)       ZMIENIC FOR ALL!!
    public class TowarForView
    {//? - oznacza decimal lub null
        public int? IdTowaru { get; set; }
        public decimal? CenaNetto { get; set; }
        public decimal? CenaBrutto { get; set; }
        public string JednostkaMiary { get; set; }
        public decimal? Marza { get; set; }
        public decimal? StawkaVatZakupu { get; set; }
        public decimal? StawkaVatSprzedazy { get; set; }
        public string Kod { get; set; }
        public string KodEan { get; set; }
        public string Nazwa { get; set; }
        public decimal? Ilosc { get; set; }
        //klucze obce ZROBIĘ W COMBOBOXIE
        //public string ProducentNazwa { get; set; }
        //public decimal? ProducentGwarancja { get; set; }
        //public string DodatkoweOpis { get; set; }
        //public string RodzajDokumentuDokument { get; set; }
        //public string TypKontrahentaAdres { get; set; }
        ////public string TypKontrahentaRodzajDokumentu { get; set; }//wypisać inne
        //public string KategoriaTowaruNazwa { get; set; }
        //public string MarkaNazwa { get; set; }
        //public bool? CzyAktywny { get; set; }
    }
}
