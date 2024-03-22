using System;
using System.Collections.Generic;
using System.Linq;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;

namespace Firma.ViewModel
{
    public class ListaTowarowViewModel : WszystkieViewBaseZDedykowanymFiltrowaniem<TowarForAllView>
    {
        #region Constructor
        private bool czyZamknac;
        public ListaTowarowViewModel(bool czyZamknac)
            : base("Lista towarów")
        {
            this.czyZamknac = czyZamknac;
        }
        #endregion
        private TowarForAllView _WybranyTowar;

        public TowarForAllView WybranyTowar
        {
            get { return _WybranyTowar; }

            set
            {
                _WybranyTowar = value;
                if (czyZamknac)
                {
                    Messenger.Default.Send(_WybranyTowar);
                    // Zamykanie zakładki Kontrahenci
                    OnRequestClose();
                }
            }
        }
        #region sort and find

        public override void sort()
        {
            if (SortField == "Nazwa")
            {
                List = new ObservableCollection<TowarForAllView>(List.OrderBy(item => item.Nazwa));
            }
            else if (SortField == "Ilość rosnąco")
            {
                List = new ObservableCollection<TowarForAllView>(List.OrderBy(item => item.Ilosc));
            }
            else if (SortField == "Ilość malejąco")
            {
                List = new ObservableCollection<TowarForAllView>(List.OrderByDescending(item => item.Ilosc));
            }
            else if (SortField == "Cena rosnąco")
            {
                List = new ObservableCollection<TowarForAllView>(List.OrderBy(item => item.CenaNetto));
            }
            else if (SortField == "Cena malejąco")
            {
                List = new ObservableCollection<TowarForAllView>(List.OrderByDescending(item => item.CenaNetto));
            }
            else if (SortField == "Cena netto od do")
            {
                if (decimal.TryParse(CenaOd, out decimal minValue) && decimal.TryParse(CenaDo, out decimal maxValue))
                {
                    List = new ObservableCollection<TowarForAllView>(List.Where(item =>
                        item.CenaNetto >= minValue && item.CenaNetto <= maxValue
                    ).OrderBy(item => item.CenaNetto)); 
                }
            }
        }
        public override List<string> getComboboxSortList()
        {
            return new List<string>
            {
                "Nazwa", "Ilość rosnąco", "Ilość malejąco", "Cena rosnąco", "Cena malejąco" 
            };
        }
        public override void find()
        {
            load();
            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<TowarForAllView>(List.Where(item =>
                    item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }
            if (FindField == "Ilość")
            {
                List = new ObservableCollection<TowarForAllView>(List.Where(item =>
                    item.Ilosc != null && item.Ilosc.ToString().StartsWith(FindTextBox)
                ));
            }
            if(FindField == "Cena")
            {
                decimal.TryParse(CenaOd, out decimal minValue);
                decimal.TryParse(CenaDo, out decimal maxValue);
                List = new ObservableCollection<TowarForAllView>(List.Where(item =>
                   item.CenaNetto >= minValue && item.CenaNetto <= maxValue
               ));
            }
        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwa", "Ilość", "Cena" };
        }

        #endregion

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<TowarForAllView>(
                from towar in teaShopEntities.Towar
                where towar.CzyAktywny == true
                select new TowarForAllView
                {
                    IdTowaru = towar.IdTowaru,
                    CenaNetto = towar.CenaNetto,
                    CenaBrutto = towar.CenaBrutto,
                    JednostkaMiary = towar.JednostkaMiary,
                    Marza = towar.Marza,
                    StawkaVatZakupu = towar.StawkaVatZakupu,
                    StawkaVatSprzedazy = towar.StawkaVatSprzedazy,
                    KodEan = towar.KodEan,
                    Nazwa = towar.Nazwa,
                    Ilosc = towar.Ilosc,
                    ProducentT = towar.ProducentT,
                    MarkaT = towar.MarkaT,
                    KategoriaTowaruT = towar.KategoriaTowaruT,
                    Opis = towar.Opis,
                    Kod = towar.Kod,
                }
            );
        }
        public override void minus()
        {
            if (_WybranyTowar != null)
            {
                var pozycja = teaShopEntities.Towar.Find(_WybranyTowar.IdTowaru);
                pozycja.CzyAktywny = false;
                teaShopEntities.SaveChanges();
                load();
            }
        }
        #endregion
    }
}
