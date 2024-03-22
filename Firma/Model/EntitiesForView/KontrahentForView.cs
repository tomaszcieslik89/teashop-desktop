namespace Firma.Model.EntitiesForView
{
    public class KontrahentForView
    {
        public int IdKontrahenta { get; set; }
        public int? IdDanePersonalne { get; set; }
        public string KodDane { get; set; }
        public string EmailDane { get; set; }
        public string ImieDane { get; set; }
        public string NazwiskoDane { get; set; }
        public string REGONDane { get; set; }
        public string TelefonDane { get; set; }
        public string NIPDane { get; set; }
        public string KodPocztowyDane { get; set; }
        public string UlicaDane { get; set; }
        public string NrDomuDane { get; set; }
        public string NrLokaluDane { get; set; }
        public string UwagiDane { get; set; }
        public string NazwaDane { get; set; }
        public string RachunekNrDane { get; set; }
        public string BankDane { get; set; }

        public string Wojewodztwo { get; set; }
        public string Kraj { get; set; }
        public string Plec { get; set; }
        public string FormaPlatnosciDane { get; set; }
        public decimal? RabatDane { get; set; }
        public string MiejscowoscDane { get; set; }
    }
}
