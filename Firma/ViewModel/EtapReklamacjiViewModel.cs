using System;
using System.Collections.Generic;
using System.Linq;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System.Collections.ObjectModel;

namespace Firma.ViewModel
{
    public class EtapReklamacjiViewModel : WszystkieViewModel<ReklamacjeForAllView>
    {
        #region Constructor

        public EtapReklamacjiViewModel()
            : base("Etap reklamacji")
        {
        }
        #endregion
        private ReklamacjeForAllView _WybranyEtapReklamacji;

        public ReklamacjeForAllView WybranyEtapReklamacji
        {
            get { return _WybranyEtapReklamacji; }

            set
            {
                _WybranyEtapReklamacji = value;
            }
        }

        #region sort and find

        public override void sort()
        {
            if (SortField == "Ilość rosnąco")
                List = new ObservableCollection<ReklamacjeForAllView>
                    (List.OrderBy(item => item.IloscR));
            if (SortField == "Ilość malejąco")
                List = new ObservableCollection<ReklamacjeForAllView>
                    (List.OrderByDescending(item => item.IloscR));

            if (SortField == "Data zakupu")
                List = new ObservableCollection<ReklamacjeForAllView>
                    (List.OrderBy(item => item.DataZakupu));
            if (SortField == "Gwarancja do")
                List = new ObservableCollection<ReklamacjeForAllView>
                    (List.OrderBy(item => item.DataGwarancjiDo));
        }

        public override List<string> getComboboxSortList()
        {
            return new List<string>
                {"Ilość rosnąco", "Ilość malejąco", "Data zakupu", "Gwarancja do" };
        }

        public override void find()
        {
            load(); // za każdym razem się ładuje i filtruje
            if (FindField == "Dostawca")
            {
                List = new ObservableCollection<ReklamacjeForAllView>(List.Where(item =>
                    item.DostawcaR != null && item.DostawcaR.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }

            if (FindField == "Produkt")
            {
                List = new ObservableCollection<ReklamacjeForAllView>(List.Where(item =>
                    item.TowaryR != null && item.TowaryR.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<ReklamacjeForAllView>(List.Where(item =>
                    item.NazwiskoR != null && item.NazwiskoR.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

            if (FindField == "Imię")
            {
                List = new ObservableCollection<ReklamacjeForAllView>(List.Where(item =>
                    item.ImieR != null && item.ImieR.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)
                ));
            }

        }
        public override void minus()
        {
            if (_WybranyEtapReklamacji != null)
            {
                var pozycja = teaShopEntities.Reklamacje.Find(_WybranyEtapReklamacji.IdReklamacji);
                pozycja.CzyAktywny = false;
                teaShopEntities.SaveChanges();
                load();
            }
        }
        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Dostawca", "Produkt", "Nazwisko", "Imię" };
        }
        #endregion
        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<ReklamacjeForAllView>
            (
                from reklamacje in teaShopEntities.Reklamacje
                where reklamacje.CzyAktywny == true              
                select new ReklamacjeForAllView
                {
                    IdReklamacji = reklamacje.IdReklamacji,
                    ImieR = reklamacje.ImieR,
                    NazwiskoR = reklamacje.NazwiskoR,
                    MiejscowoscR = reklamacje.MiejscowoscR,
                    KodPocztowyR = reklamacje.KodPocztowyR,
                    UlicaR = reklamacje.UlicaR,
                    NrDomuR = reklamacje.NrDomuR,
                    NrLokaluR = reklamacje.NrLokaluR,
                    PESELR = reklamacje.PESELR,
                    TowaryR = reklamacje.TowaryR,
                    DostawcaR = reklamacje.DostawcaR,
                    IloscR = reklamacje.IloscR,
                    JednostkaR = reklamacje.JednostkaR,
                    DokumentR = reklamacje.DokumentR,
                    OpisR = reklamacje.OpisR,
                    TelefonR = reklamacje.TelefonR,
                    EmailR = reklamacje.EmailR,
                    DataZakupu = reklamacje.DataZakupu,
                    DataPowstaniaWady = reklamacje.DataPowstaniaWady,
                    DataGwarancjiDo = reklamacje.DataGwarancjiDo,
                }
            );
        }
    }
}
#endregion
