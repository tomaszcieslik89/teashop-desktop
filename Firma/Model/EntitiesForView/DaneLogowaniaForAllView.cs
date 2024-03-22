using System;
namespace Firma.Model.EntitiesForView
{
    public class DaneLogowaniaForAllView
    {
        public int IdDaneLogowania { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string HasloUzytkownika { get; set; }
        public DateTime? DataUtworzenia { get; set; }
        public bool? CzyAktywny { get; set; }
    }
}

