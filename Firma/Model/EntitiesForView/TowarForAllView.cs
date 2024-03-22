namespace Firma.Model.EntitiesForView
{
    public class TowarForAllView
    {
        public int IdTowaru { get; set; }
        public decimal? CenaNetto { get; set; }
        public decimal? CenaBrutto { get; set; }
        public string JednostkaMiary { get; set; }
        public decimal? Marza { get; set; }
        public decimal? StawkaVatZakupu { get; set; } 
        public decimal? StawkaVatSprzedazy { get; set; }      
        public string KodEan { get; set; }
        public string Nazwa { get; set; }
        public decimal? Ilosc { get; set; }
        public string Opis { get; set; }
        public string ProducentT { get; set; }//producent polska chiny etc
        public string MarkaT { get; set; }//lipton,tetley
        public string KategoriaTowaruT { get; set; }//herbata czarna, zółta
        public string Kod { get; set; }
    }
}
