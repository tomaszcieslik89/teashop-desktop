using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firma.Model.Entities;
using Firma.Helpers;
using System.Windows.Input;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System.Collections.ObjectModel;


namespace Firma.ViewModel
{
    public class ListaPracownikowViewModel : WszystkieViewModel<PracownikForAllView>//bo wszystkie ViewModel obsługujące zakładki bd dziedziczyc po WorkspaceViewModel
    {
        #region Constructor
        public ListaPracownikowViewModel()
        : base("Lista pracowników")//base wywoła konsturuktow WszystkieViewModel
        {
        }
        #endregion





        private PracownikForAllView _WybranyListaPracownikow;

        public PracownikForAllView WybranyListaPracownikow
        {
            get { return _WybranyListaPracownikow; }

            set
            {
                _WybranyListaPracownikow = value;
            }
        }





        #region sort and find

        public override void sort()
        {
            if (SortField == "Stawka rosnąco")
                List = new ObservableCollection<PracownikForAllView>
                    (List.OrderBy(item => item.StawkaP));
            if (SortField == "Stawka malejąco")
                List = new ObservableCollection<PracownikForAllView>
                    (List.OrderByDescending(item => item.StawkaP));

            if (SortField == "Data rozp. pracy")
                List = new ObservableCollection<PracownikForAllView>
                    (List.OrderBy(item => item.DataRozpPracyP));
            if (SortField == "Data zatrudnienia")
                List = new ObservableCollection<PracownikForAllView>
                    (List.OrderBy(item => item.DataZatrudnieniaP));

        }

        public override List<string> getComboboxSortList()
        {
            return new List<string>
                { "Stawka rosnąco", "Stawka malejąco", "Data rozp. pracy rosnąco", "Data zatrudnienia rosnąco"  };
        }

        public override void find()
        {
            load(); // za każdym razem się ładuje i filtruje
            if (FindField == "Email")
            {
                List = new ObservableCollection<PracownikForAllView>(List.Where(item =>
                    item.EmailP != null && item.EmailP.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }

            if (FindField == "Kraj")
            {
                List = new ObservableCollection<PracownikForAllView>(List.Where(item =>
                    item.KrajP != null && item.KrajP.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }

            if (FindField == "Imię")
            {
                List = new ObservableCollection<PracownikForAllView>(List.Where(item =>
                    item.ImieP != null && item.ImieP.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }

            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<PracownikForAllView>(List.Where(item =>
                    item.NazwiskoP != null && item.NazwiskoP.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }
            if (FindField == "Telefon")
            {
                List = new ObservableCollection<PracownikForAllView>(List.Where(item =>
                    item.TelefonP != null && item.TelefonP.StartsWith(FindTextBox, StringComparison.OrdinalIgnoreCase)//OrdinalIgnoreCase ignoruje małe i duze litery
                ));
            }


        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "Email", "Kraj", "Imię", "Nazwisko", "Telefon", };
        }

        #endregion



        #region Helpers
        //nadpisana
        public override void load()
        {
            //
            List = new ObservableCollection<PracownikForAllView>
            (
                //Linq => odpowiednik C# (obiektowy) SQL (konstrukcja c# inicjalizator)
                from pracownik in teaShopEntities.Pracownik//from dokumentSprzedazy in teaShopEntities.IdAdresu i zrobić entitiforview adres
                where pracownik.CzyAktywny == true//wyswietla tylko aktywne
                select new PracownikForAllView
                {

                    IdPracownika = pracownik.IdPracownika,
                    ImieP = pracownik.ImieP,
                    DrugieImieP = pracownik.DrugieImieP,
                    NazwiskoP = pracownik.NazwiskoP,
                    NazwiskoRodoweP = pracownik.NazwiskoRodoweP,
                    ImieOjcaP = pracownik.ImieOjcaP,
                    ImieMatkiP = pracownik.ImieMatkiP,
                    NrPaszportuP = pracownik.NrPaszportuP,
                    PESELP = pracownik.PESELP,
                    TelefonP = pracownik.TelefonP,
                    EmailP = pracownik.EmailP,
                    DataUrodzeniaP = pracownik.DataUrodzeniaP,
                    PowiatP = pracownik.PowiatP,
                    MiejscowoscP = pracownik.MiejscowoscP,
                    UlicaP = pracownik.UlicaP,
                    GminaP = pracownik.GminaP,
                    KodPocztowyP = pracownik.KodPocztowyP,
                    NrDomuP = pracownik.NrDomuP,
                    NrLokaluP = pracownik.NrLokaluP,
                    DataRozpPracyP = pracownik.DataRozpPracyP,
                    DataZatrudnieniaP = pracownik.DataZatrudnieniaP,
                    DataZwolnieniaP = pracownik.DataZwolnieniaP,
                    WymiarEtatuP = pracownik.WymiarEtatuP,
                    StawkaP = pracownik.StawkaP,
                    LimitUrlopuP = pracownik.LimitUrlopuP,
                    DodatkoweDniUrlopuP = pracownik.DodatkoweDniUrlopuP,
                    WykorzystanoP = pracownik.WykorzystanoP,
                    PozostaloP = pracownik.PozostaloP,
                    KrajP = pracownik.KrajP,
                    PlecP = pracownik.PlecP,
                    WojewodzctwoP = pracownik.WojewodzctwoP,
                    RodzajUmowyP = pracownik.RodzajUmowyP,
                    RodzajZatrudnieniaP = pracownik.RodzajZatrudnieniaP,
                    StanowiskoP = pracownik.StanowiskoP

                }
                );
        }

        public override void minus()
        {
            if (_WybranyListaPracownikow != null)
            {
                var pozycja = teaShopEntities.Pracownik.Find(_WybranyListaPracownikow.IdPracownika);
                pozycja.CzyAktywny = false;
                teaShopEntities.SaveChanges();
                load();
            }
        }
    }
}
#endregion
