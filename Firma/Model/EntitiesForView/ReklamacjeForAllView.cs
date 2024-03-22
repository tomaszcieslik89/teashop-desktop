using System;

namespace Firma.Model.EntitiesForView
{
    public class ReklamacjeForAllView
    {
        public int IdReklamacji { get; set; }
        public string ImieR { get; set; }
        public string NazwiskoR { get; set; }
        public string MiejscowoscR { get; set; }
        public string KodPocztowyR { get; set; }
        public string UlicaR { get; set; }
        public string NrLokaluR { get; set; }
        public string NrDomuR { get; set; }
        public string PESELR { get; set; }
        public string TowaryR { get; set; }
        public string DostawcaR { get; set; }
        public string IloscR { get; set; }
        public string JednostkaR { get; set; }
        public string DokumentR { get; set; }
        public string OpisR { get; set; }
        public string TelefonR { get; set; }
        public string EmailR { get; set; }
        public DateTime? DataZakupu { get; set; }
        public DateTime? DataPowstaniaWady { get; set; }
        public DateTime? DataGwarancjiDo { get; set; }
    }
}
