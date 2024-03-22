using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Firma.ViewModel
{
    public class UzytkownicyViewModel : WszystkieViewModel<DaneLogowaniaForAllView>
    {
        #region Constructor
        public UzytkownicyViewModel()
       : base("Uzytkownicy")
        {
        }
        #endregion

        private DaneLogowaniaForAllView _WybranyUzytkownik;

        public DaneLogowaniaForAllView WybranyUzytkownik
        {
            get { return _WybranyUzytkownik; }
            set
            {
                _WybranyUzytkownik = value;
            }
        }

        #region sort and find

        public override void sort()
        {
            if (SortField == "Nazwa")
                List = new ObservableCollection<DaneLogowaniaForAllView>
                    (List.OrderBy(item => item.NazwaUzytkownika));
            if (SortField == "Data utworzenia rosnąco")
                List = new ObservableCollection<DaneLogowaniaForAllView>
                    (List.OrderBy(item => item.DataUtworzenia));
            if (SortField == "Data utworzenia malejąco")
                List = new ObservableCollection<DaneLogowaniaForAllView>
                    (List.OrderByDescending(item => item.DataUtworzenia));

        }
        public override List<string> getComboboxSortList()
        {
            return new List<string>
                { "Nazwa", "Data utworzenia rosnąco", "Data utworzenia malejąco",};
        }

        public override void find()
        {
            load(); // za każdym razem się ładuje i filtruje
            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<DaneLogowaniaForAllView>(List.Where(item =>
                    item.NazwaUzytkownika != null && item.NazwaUzytkownika.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa" };
        }
        #endregion
        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<DaneLogowaniaForAllView>
            (
                from daneLogowania in teaShopEntities.DaneLogowania
                where daneLogowania.CzyAktywny == true//wyswietla tylko aktywne
                select new DaneLogowaniaForAllView
                {
                    IdDaneLogowania = daneLogowania.IdDaneLogowania,
                    NazwaUzytkownika = daneLogowania.NazwaUzytkownika,
                    HasloUzytkownika = daneLogowania.HasloUzytkownika,
                    DataUtworzenia = daneLogowania.DataUtworzenia,
                    CzyAktywny = daneLogowania.CzyAktywny,
                }
                );
        }
        public override void minus()
        {
            if (_WybranyUzytkownik != null)
            {
                var pozycja = teaShopEntities.DaneLogowania.Find(_WybranyUzytkownik.IdDaneLogowania);
                teaShopEntities.DaneLogowania.Remove(pozycja);
                teaShopEntities.SaveChanges();
                load();
            }
        }
    }
}
#endregion

