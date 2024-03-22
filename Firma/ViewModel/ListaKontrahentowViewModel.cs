using System;
using System.Collections.Generic;
using System.Linq;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;

namespace Firma.ViewModel
{
    class ListaKontrahentowViewModel : WszystkieViewModel <KontrahentForView>
    {
        private bool czyZamknac;
        #region Constructor
        public ListaKontrahentowViewModel(bool czyZamknac)
            : base("Lista kontrahentów")
        {
            this.czyZamknac = czyZamknac;
        }
        #endregion
        private KontrahentForView _WybranyKontrahent2;

        public KontrahentForView WybranyKontrahent2
        {
            get { return _WybranyKontrahent2; }

            set
            {
                _WybranyKontrahent2 = value;
                if(czyZamknac)
                {
                    Messenger.Default.Send(_WybranyKontrahent2);
                    OnRequestClose();
                }
            }
        }
        #region sort and find

        public override void sort()
        {
            if (SortField == "Nazwa")
                List = new ObservableCollection<KontrahentForView>(
                    List.OrderBy(item => item.NazwaDane));


            if (SortField == "E-mail")
                List = new ObservableCollection<KontrahentForView>
                    (List.OrderBy(item => item.EmailDane));


            if (SortField == "Stał rabat malejąco")
                List = new ObservableCollection<KontrahentForView>
                    (List.OrderByDescending(item => item.RabatDane));

            if (SortField == "Stał rabat rosnąco")
                List = new ObservableCollection<KontrahentForView>
                    (List.OrderBy(item => item.RabatDane));
            
        }

        public override List<string> getComboboxSortList()
        {
            return new List<string>
                { "Nazwa", "E-mail", "Stał rabat malejąco", "Stał rabat rosnąco" };
        }

        public override void find()
        {
            load(); 
            if (FindField == "Opis")
            {
                List = new ObservableCollection<KontrahentForView>(List.Where(item =>
                    item.UwagiDane != null && item.UwagiDane.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Telefon")
            {
                List = new ObservableCollection<KontrahentForView>(List.Where(item =>
                    item.TelefonDane != null && item.TelefonDane.ToString().StartsWith(FindTextBox)
                ));
            }

            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<KontrahentForView>(List.Where(item =>
                    item.NazwaDane != null && item.NazwaDane.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "NIP")
            {
                List = new ObservableCollection<KontrahentForView>(List.Where(item =>
                    item.NIPDane != null && item.NIPDane.StartsWith(FindTextBox)
                ));
            }

            if (FindField == "REGON")
            {
                List = new ObservableCollection<KontrahentForView>(List.Where(item =>
                    item.REGONDane != null && item.REGONDane.StartsWith(FindTextBox)
                ));
            }

            if (FindField == "Kraj")
            {
                List = new ObservableCollection<KontrahentForView>(List.Where(item =>
                    item.Kraj != null && item.Kraj.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Opis", "Telefon", "Nazwa", "NIP", "REGON" , "Kraj" };
        }

        #endregion
        #region Properties
        #endregion

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<KontrahentForView>
            (
                from kontrahent in teaShopEntities.Kontrahent
                where kontrahent.CzyAktywny == true
                select new KontrahentForView
                {
                    IdDanePersonalne = kontrahent.IdDanePersonalne,
                    KodDane = kontrahent.DanePersonalne.KodDane,
                    EmailDane = kontrahent.DanePersonalne.EmailDane,
                    ImieDane = kontrahent.DanePersonalne.ImieDane,
                    NazwiskoDane = kontrahent.DanePersonalne.NazwiskoDane,
                    TelefonDane = kontrahent.DanePersonalne.TelefonDane,
                    REGONDane = kontrahent.DanePersonalne.REGONDane,
                    NIPDane = kontrahent.DanePersonalne.NIPDane,
                    MiejscowoscDane = kontrahent.DanePersonalne.MiejscowoscDane,
                    UlicaDane = kontrahent.DanePersonalne.UlicaDane,
                    NrDomuDane = kontrahent.DanePersonalne.NrDomuDane,
                    NrLokaluDane = kontrahent.DanePersonalne.NrLokaluDane,
                    UwagiDane = kontrahent.DanePersonalne.UwagiDane,
                    RabatDane = kontrahent.DanePersonalne.RabatDane,
                    NazwaDane = kontrahent.DanePersonalne.NazwaDane,
                    BankDane = kontrahent.DanePersonalne.BankDane,
                    RachunekNrDane = kontrahent.DanePersonalne.RachunekNrDane,
                    Wojewodztwo = kontrahent.DanePersonalne.Wojewodztwo,
                    Kraj = kontrahent.DanePersonalne.Kraj,
                    FormaPlatnosciDane = kontrahent.DanePersonalne.FormaPlatnosciDane,
                    KodPocztowyDane = kontrahent.DanePersonalne.KodPocztowyDane,
                    Plec = kontrahent.DanePersonalne.Plec,
                    IdKontrahenta = kontrahent.IdKontrahenta,
                }
                );
        }
        public override void minus()
        {
            if (_WybranyKontrahent2 != null)
            {
                var pozycja = teaShopEntities.Kontrahent.Where(x => x.IdKontrahenta == _WybranyKontrahent2.IdKontrahenta).FirstOrDefault();
                pozycja.CzyAktywny = false;
                teaShopEntities.SaveChanges();
                load();
            }
        }
    }
}
#endregion
