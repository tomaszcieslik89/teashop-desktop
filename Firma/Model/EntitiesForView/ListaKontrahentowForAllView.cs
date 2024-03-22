namespace Firma.Model.EntitiesForView
{
    public class ListaKontrahentowForAllView
    {
        public int IdKontrahenta { get; set; }
        public string KontrahentAdres{ get; set; }
        public string KontrahentAdresKraj{ get; set; }
        public string KontrahentRodzajDokumentow{ get; set; }
        public decimal? KontrahentRabat{ get; set; }
        public string KontrahentDanePersonalne{ get; set; }
        public string KontrahentNip { get; set; }
        public string KontrahentNazwa { get; set; }
        public int IdDanePersonalne { get; set; }
        public string KodPocztowyDane { get; set; }
    }
}
