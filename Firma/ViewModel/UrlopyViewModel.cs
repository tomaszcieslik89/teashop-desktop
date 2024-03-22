using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Firma.ViewModel
{
    public class UrlopyViewModel : WszystkieViewModel<UrlopyForAllView>
    {
        #region Constructor
        public UrlopyViewModel()
       : base("Urlopy")
        {
        }
        #endregion
        private UrlopyForAllView _WybranyUrlop;

        public UrlopyForAllView WybranyUrlop
        {
            get { return _WybranyUrlop; }

            set
            {
                _WybranyUrlop = value;
            }
        }
        #region sort and find

        public override void sort()
        {
            if (SortField == "Nazwisko")
                List = new ObservableCollection<UrlopyForAllView>
                    (List.OrderBy(item => item.NazwiskoU));
            if (SortField == "Wymiar etatu rosnąco")
                List = new ObservableCollection<UrlopyForAllView>
                    (List.OrderBy(item => item.WymiarEtatuU));
            if (SortField == "Wymiar etatu malejąco")
                List = new ObservableCollection<UrlopyForAllView>
                    (List.OrderByDescending(item => item.WymiarEtatuU));

        }

        public override List<string> getComboboxSortList()
        {
            return new List<string>
                {"Wymiar etatu rosnąco", "Wymiar etatu malejąco",};
        }

        public override void find()
        {
            load();
            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<UrlopyForAllView>(List.Where(item =>
                    item.NazwiskoU != null && item.NazwiskoU.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Imię")
            {
                List = new ObservableCollection<UrlopyForAllView>(List.Where(item =>
                    item.ImieU != null && item.ImieU.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Telefon")
            {
                List = new ObservableCollection<UrlopyForAllView>(List.Where(item =>
                    item.TelefonU != null && item.TelefonU.ToString().StartsWith(FindTextBox)
                ));
            }

            if (FindField == "E-mail")
            {
                List = new ObservableCollection<UrlopyForAllView>(List.Where(item =>
                    item.EmailU != null && item.EmailU.ToString().StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Stanowisko")
            {
                List = new ObservableCollection<UrlopyForAllView>(List.Where(item =>
                    item.StanowiskoU != null && item.StanowiskoU.ToString().StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Nazwisko", "Imię", "Telefon", "E-mail", "Stanowisko" };
        }
        #endregion
        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<UrlopyForAllView>
            (

                from urlop in teaShopEntities.Urlop
                where urlop.CzyAktywny == true
                select new UrlopyForAllView
                {
                    IdUrlopu = urlop.IdUrlopu,
                    WykorzystanoU = urlop.WykorzystanoU,
                    DodatkoweDniUrlopu = urlop.DodatkoweDniUrlopu,
                    DataRozpUrlopuU = urlop.DataRozpUrlopuU,
                    RodzajUrlopuU = urlop.RodzajUrlopuU,
                    RodzajUmowyU = urlop.RodzajUmowyU,
                    WymiarEtatuU = urlop.WymiarEtatuU,
                    LimitUrlopuU = urlop.LimitUrlopuU,
                    NazwaPracownikU = urlop.NazwaPracownikU,
                    ImieU = urlop.ImieU,
                    DrugieImieU = urlop.DrugieImieU,
                    NazwiskoU = urlop.NazwiskoU,
                    NazwiskoRodMatU = urlop.NazwiskoRodMatU,
                    ImieOjcaU = urlop.ImieOjcaU,
                    ImieMatkiU = urlop.ImieMatkiU,
                    MiejscowoscU = urlop.MiejscowoscU,
                    DataUrodzeniaU = urlop.DataUrodzeniaU,
                    KrajU = urlop.KrajU,
                    PowiatU = urlop.PowiatU,
                    GminaU = urlop.GminaU,
                    NrPaszportuU = urlop.NrPaszportuU,
                    UlicaU = urlop.UlicaU,
                    NrDomuU = urlop.NrDomuU,
                    NrLokaluU = urlop.NrLokaluU,
                    TelefonU = urlop.TelefonU,
                    EmailU = urlop.EmailU,
                    WojewodzctwoU = urlop.WojewodzctwoU,
                    DataZakonczeniaUrlopu = urlop.DataZakonczeniaUrlopu,
                    StanowiskoU = urlop.StanowiskoU,
                }
                );
        }
        public override void minus()
        {
            if (_WybranyUrlop != null)
            {
                var pozycja = teaShopEntities.Urlop.Find(_WybranyUrlop.IdUrlopu);
                pozycja.CzyAktywny = false;
                teaShopEntities.SaveChanges();
                load();
            }
        }
    }
}
#endregion
