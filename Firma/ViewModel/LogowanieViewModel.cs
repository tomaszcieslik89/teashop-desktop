using Firma.Model.Entities;
using System.Linq;
using System.Windows;

namespace Firma.ViewModel
{
    internal class LogowanieViewModel : BaseViewModel 
    {
        private TeaShopEntities teaShopEntities;

        public LogowanieViewModel()
        {
            this.teaShopEntities = new TeaShopEntities();
        }
        public bool Logowanie(string Login, string Haslo)
        {
            var Uzytkownik = teaShopEntities.DaneLogowania.Where(x => x.NazwaUzytkownika == Login).FirstOrDefault();
            if (Uzytkownik != null)
            {
                if (Haslo != Uzytkownik.HasloUzytkownika)
                {
                    MessageBox.Show("Niepoprawne hasło");
                    return false;
                }
                else if (Login != Uzytkownik.NazwaUzytkownika)
                {
                    MessageBox.Show("Niepoprawna nazwa użytkownika.");
                    return false;
                }
                else
                    return true;

            }
            MessageBox.Show("Użytkownik nie znaleziony.");
            return false;
        }
    }
}
