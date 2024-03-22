using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class ListaDokumentowViewModel : WszystkieViewModel<ListaDokumentowForAllView>
    {
        #region Constructor
        public ListaDokumentowViewModel()
            : base("Lista dokumentów")
        {
        }
        #endregion
        private ListaDokumentowForAllView _WybranyDokument;
        public  ListaDokumentowForAllView WybranyDokument
        {
            get { return _WybranyDokument; }

            set
            {
                _WybranyDokument = value;
            }
        }

        #region sort and find
        public override void sort()
        {
            if (SortField == "Data wystawienia")
                List = new ObservableCollection<ListaDokumentowForAllView>
                    (List.OrderBy(item => item.DokumentDataWystawienia));
           
            if (SortField == "Termin płatności")
                List = new ObservableCollection<ListaDokumentowForAllView>
                    (List.OrderBy(item => item.DokumentTerminPlatnosci));

            if (SortField == "Rabat")
                List = new ObservableCollection<ListaDokumentowForAllView>
                    (List.OrderBy(item => item.DokumentDodatkoweRabat));

        }

        public override List<string> getComboboxSortList()
        {
            return new List<string>
                { "Data wystawienia", "Termin płatności", "Rabat"};
        }

        public override void find()
        {
            load();             if (FindField == "Sposób płatności")
            {
                List = new ObservableCollection<ListaDokumentowForAllView>(List.Where(item =>
                    item.DokumentSposobuPlatnosciNazwa != null && item.DokumentSposobuPlatnosciNazwa.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "NIP")
            {
                List = new ObservableCollection<ListaDokumentowForAllView>(List.Where(item =>
                    item.NIP != null && item.NIP.ToString().StartsWith(FindTextBox)
                ));
            }

            if (FindField == "Uwagi/Opis")
            {
                List = new ObservableCollection<ListaDokumentowForAllView>(List.Where(item =>
                    item.DokumentDodatkoweUwagi != null && item.DokumentDodatkoweUwagi.ToString().StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "E-mail")
            {
                List = new ObservableCollection<ListaDokumentowForAllView>(List.Where(item =>
                    item.DokumentDodatkoweEmail != null && item.DokumentDodatkoweEmail.ToString().StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<ListaDokumentowForAllView>(List.Where(item =>
                    item.DokumentDodatkoweNazwisko != null && item.DokumentDodatkoweNazwisko.ToString().StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Imię")
            {
                List = new ObservableCollection<ListaDokumentowForAllView>(List.Where(item =>
                    item.DokumentDodatkoweImie != null && item.DokumentDodatkoweImie.ToString().StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "NIP", "Sposób płatności", "Uwagi/Opis", "E-mail", "Nazwisko", "Imię"};
        }

        #endregion
                #region Helpers
        public override void load()
        {
            List = new ObservableCollection<ListaDokumentowForAllView>
            (
                
                from dokumentSprzedazy in teaShopEntities.DokumentSprzedazy
                where dokumentSprzedazy.CzyAktywny == true
                select new ListaDokumentowForAllView
                {
                    IdDokumentuSprzedazy = dokumentSprzedazy.IdDokumentuSprzedazy,
                    DokumentSposobuPlatnosciNazwa = dokumentSprzedazy.SposobPlatnosci.NazwaSposobuPlatnosci,
                    DokumentTerminPlatnosci = dokumentSprzedazy.TerminPlatnosci,
                    DokumentDataWystawienia = dokumentSprzedazy.DataWystawienia,       
                    DokumentDodatkoweUwagi = dokumentSprzedazy.Dodatkowe.Opis,
                    DokumentRodzajDokumentu = dokumentSprzedazy.RodzajDokumentu.Dokument,
                    DokumentNumerDokumentu = dokumentSprzedazy.NumerDokumentu,
                    DokumentPozycjaDokumentu = dokumentSprzedazy.PozycjaDokumentu,
                    NIP = dokumentSprzedazy.Kontrahent.DanePersonalne.NIPDane,
                    DokumentDodatkoweNazwa= dokumentSprzedazy.Kontrahent.DanePersonalne.NazwaDane,
                    DokumentDodatkoweImie = dokumentSprzedazy.Kontrahent.DanePersonalne.ImieDane,
                    DokumentDodatkoweNazwisko = dokumentSprzedazy.Kontrahent.DanePersonalne.NazwiskoDane,
                    DokumentDodatkoweEmail = dokumentSprzedazy.Kontrahent.DanePersonalne.EmailDane,
                    DokumentDodatkoweRabat = dokumentSprzedazy.Rabat.Procent,
                }
                );
        }

        public override void minus()
        {
            if (_WybranyDokument != null)
            {
                var pozycja = teaShopEntities.DokumentSprzedazy.Find(_WybranyDokument.IdDokumentuSprzedazy);
                pozycja.CzyAktywny = false;
                teaShopEntities.SaveChanges();
                load();
            }
        }
    }
}
#endregion
