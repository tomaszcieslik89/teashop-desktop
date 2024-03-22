using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using Firma.Helpers;
using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System.Data.Entity;
using System.Windows;

namespace Firma.ViewModel
{
    public class NowyParagonViewModel : JedenViewModel<DokumentSprzedazy>/*Paragon*/
    {
        #region Konstruktor
        private List<int> towary;
        public NowyParagonViewModel()
            : base("Paragon")
        {
            item = new DokumentSprzedazy();
            Messenger.Default.Register<KontrahentForView>(this, getWybranyKontrahent);
            Messenger.Default.Register<TowarForAllView>(this, getWybranyTowar);
            towary = new List<int>();
        }
        #endregion
        #region Properties

        public DateTime? DataWystawienia
        {
            get { return item.DataWystawienia; }
            set
            {
                if (item.DataWystawienia != value)
                {
                    item.DataWystawienia = value;
                    base.OnPropertyChanged(() => DataWystawienia);
                }
            }
        }

        public DateTime? TerminPlatnosci
        {
            get { return item.TerminPlatnosci; }
            set
            {
                if (item.TerminPlatnosci != value)
                {
                    item.TerminPlatnosci = value;
                    base.OnPropertyChanged(() => TerminPlatnosci);
                }
            }
        }


        public int? IdKontrahenta
        {
            get { return item.IdKontrahenta; }
            set
            {
                if (item.IdKontrahenta != value)
                {
                    item.IdKontrahenta = value;
                    base.OnPropertyChanged(() => IdKontrahenta);
                }
            }
        }

        public string NumerDokumentu
        {
            get { return item.NumerDokumentu; }
            set
            {
                if (item.NumerDokumentu != value)
                {
                    item.NumerDokumentu = value;
                    base.OnPropertyChanged(() => NumerDokumentu);
                }
            }
        }

        public int? PozycjaDokumentu
        {
            get { return item.PozycjaDokumentu; }
            set
            {
                if (item.PozycjaDokumentu != value)
                {
                    item.PozycjaDokumentu = value;
                    base.OnPropertyChanged(() => PozycjaDokumentu);
                }
            }
        }

        private string _DokumentDodatkoweUwagi;

        public string DokumentDodatkoweUwagi
        {
            get
            {
                return _DokumentDodatkoweUwagi;
            }
            set
            {
                if (_DokumentDodatkoweUwagi != value)
                {
                    _DokumentDodatkoweUwagi = value;
                    base.OnPropertyChanged(() => DokumentDodatkoweUwagi);
                }
            }
        }

        public int? IdSposobuPlatnosci
        {
            get { return item.IdSposobuPlatnosci; }
            set
            {
                if (item.IdSposobuPlatnosci != value)
                {
                    item.IdSposobuPlatnosci = value;
                    base.OnPropertyChanged(() => IdSposobuPlatnosci);
                }
            }
        }
        //PRIVATE
        private string _KontrahentRodzajDokumentow;

        public string KontrahentRodzajDokumentow
        {
            get
            {
                return _KontrahentRodzajDokumentow;
            }
            set
            {
                if (_KontrahentRodzajDokumentow != value)
                {
                    _KontrahentRodzajDokumentow = value;
                    base.OnPropertyChanged(() => KontrahentRodzajDokumentow);
                }
            }
        }

        private string _KontrahentNip;

        public string KontrahentNip
        {
            get
            {
                return _KontrahentNip;
            }
            set
            {
                if (_KontrahentNip != value)
                {
                    _KontrahentNip = value;
                    base.OnPropertyChanged(() => KontrahentNip);
                }
            }
        }

        private string _KontrahentNazwa;

        public string KontrahentNazwa
        {
            get
            {
                return _KontrahentNazwa;
            }
            set
            {
                if (_KontrahentNazwa != value)
                {
                    _KontrahentNazwa = value;
                    base.OnPropertyChanged(() => _KontrahentNazwa);
                }
            }
        }

        private string _KontrahentDanePersonalne;

        public string KontrahentDanePersonalne
        {
            get
            {
                return KontrahentDanePersonalne;
            }
            set
            {
                if (_KontrahentDanePersonalne != value)
                {
                    _KontrahentDanePersonalne = value;
                    base.OnPropertyChanged(() => KontrahentDanePersonalne);
                }
            }
        }

        private string _KontrahentAdres;

        public string KontrahentAdres
        {
            get
            {
                return _KontrahentAdres;
            }
            set
            {
                if (_KontrahentAdres != value)
                {
                    _KontrahentAdres = value;
                    base.OnPropertyChanged(() => KontrahentAdres);
                }
            }
        }

        private string _IdRodzajuDokumentow;

        public string IdRodzajuDokumentow
        {
            get
            {
                return _IdRodzajuDokumentow;
            }
            set
            {
                if (_IdRodzajuDokumentow != value)
                {
                    _IdRodzajuDokumentow = value;
                    base.OnPropertyChanged(() => IdRodzajuDokumentow);
                }
            }
        }
        public IQueryable<KeyAndValue> KontrahenciComboboxItems
        {
            get
            {
                return
                (
                    from kontrahent in teaShopEntities.Kontrahent
                    where kontrahent.CzyAktywny == true
                    select new KeyAndValue  
                    {
                        Key = kontrahent.IdKontrahenta,
                        Value = kontrahent.DanePersonalne.ImieDane + " " + kontrahent.DanePersonalne.NazwiskoDane + " Nazwa firmy: " + kontrahent.DanePersonalne.NazwaDane + " NIP: " + kontrahent.DanePersonalne.NIPDane + " REGON: " + kontrahent.DanePersonalne.REGONDane + " Telefon: " + kontrahent.DanePersonalne.TelefonDane
                    }
                ).ToList().AsQueryable();
            }
        }

        public IQueryable<KeyAndValue> TowaryComboboxItems
        {
            get
            {
                return
                (
                    from towar in teaShopEntities.Towar
                    where towar.CzyAktywny == true
                    select new KeyAndValue
                    {
                        Key = towar.IdTowaru,
                        Value = towar.Nazwa
                    }
                ).ToList().AsQueryable();
            }
        }

        public IQueryable<Rabat> RabatComboboxItems
        {
            get
            {
                return
                (
                    from rabat in teaShopEntities.Rabat
                    where rabat.CzyAktywny == true
                    select rabat
                ).ToList().AsQueryable();
            }
        }

        public IQueryable<SposobPlatnosci> SposobyPlatnosciComboboxItems
        {
            get
            {
                return
                (
                    from sposobPlatnosci in teaShopEntities.SposobPlatnosci
                    where sposobPlatnosci.CzyAktywny == true
                    select sposobPlatnosci
                ).ToList().AsQueryable();
            }
        }

        public bool? CzyAktywny
        {
            get { return item.CzyAktywny; }
            set
            {
                if (item.CzyAktywny != value)
                {
                    item.CzyAktywny = value;
                    base.OnPropertyChanged(() => CzyAktywny);
                }
            }
        }
        #endregion

        #region Command
        private BaseCommand _WybierzKontrahenta;
        public ICommand WybierzKontrahenta
        {
            get
            {
                if (_WybierzKontrahenta == null)
                {
                    _WybierzKontrahenta = new BaseCommand(() => ZakladkaWybierzKontrahenta());
                }
                return _WybierzKontrahenta;
            }
        }

        private BaseCommand _WybierzTowar;
        public ICommand WybierzTowar
        {
            get
            {
                if (_WybierzTowar == null)
                {
                    _WybierzTowar = new BaseCommand(() => ZakladkaWybierzTowar());
                }
                return _WybierzTowar;
            }
        }


        public int? IdRabatu
        {
            get { return item.IdRabatu; }
            set
            {
                if (item.IdRabatu != value)
                {
                    item.IdRabatu = value;
                    base.OnPropertyChanged(() => IdRabatu);
                }
            }
        }



        private string _KontrahentImie;

        public string KontrahentImie
        {
            get
            {
                return _KontrahentImie;
            }
            set
            {
                if (_KontrahentImie != value)
                {
                    _KontrahentImie = value;
                    base.OnPropertyChanged(() => KontrahentImie);
                }
            }
        }

        private string _KontrahentNazwisko;

        public string KontrahentNazwisko
        {
            get
            {
                return _KontrahentNazwisko;
            }
            set
            {
                if (_KontrahentNazwisko != value)
                {
                    _KontrahentNazwisko = value;
                    base.OnPropertyChanged(() => KontrahentNazwisko);
                }
            }
        }

        private string _KontrahentREGON;

        public string KontrahentREGON
        {
            get
            {
                return _KontrahentREGON;
            }
            set
            {
                if (_KontrahentREGON != value)
                {
                    _KontrahentREGON = value;
                    base.OnPropertyChanged(() => KontrahentREGON);
                }
            }
        }

        private string _KontrahentEmail;

        public string KontrahentEmail
        {
            get
            {
                return _KontrahentEmail;
            }
            set
            {
                if (_KontrahentEmail != value)
                {
                    _KontrahentEmail = value;
                    base.OnPropertyChanged(() => KontrahentEmail);
                }
            }
        }


        private decimal? _KontrahentRabat;

        public decimal? KontrahentRabat
        {
            get
            {
                return _KontrahentRabat;
            }
            set
            {
                if (_KontrahentRabat != value)
                {
                    _KontrahentRabat = value;
                    base.OnPropertyChanged(() => KontrahentRabat);
                }
            }
        }

        private string _KontrahentTelefon;

        public string KontrahentTelefon
        {
            get
            {
                return _KontrahentTelefon;
            }
            set
            {
                if (_KontrahentTelefon != value)
                {
                    _KontrahentTelefon = value;
                    base.OnPropertyChanged(() => KontrahentTelefon);
                }
            }
        }

        private string _NazwaTowaru;

        public string NazwaTowaru
        {
            get
            {
                return _NazwaTowaru;
            }
            set
            {
                _NazwaTowaru = _NazwaTowaru + value;
                base.OnPropertyChanged(() => NazwaTowaru);
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            bool czyWyjscZfunkcji = false;
            foreach (var itemTowar in towary)
            {
                var towar = teaShopEntities.Towar.Find(itemTowar);
                if (towar.Ilosc == 0)
                {
                    czyWyjscZfunkcji = true;
                    MessageBox.Show("Niewystarczajaca ilość towaru na magazynie." + towar.Nazwa);
                    break;
                }
            }
            if (czyWyjscZfunkcji)
                return;
            Dodatkowe dodatkowe = new Dodatkowe()
            {
                Opis = DokumentDodatkoweUwagi,
                CzyAktywny = true
            };
            teaShopEntities.Dodatkowe.Add(dodatkowe);
            item.CzyAktywny = true;
            item.IdDodatkowe = dodatkowe.IdDodatkowe;
            item.IdRodzajuDokumentow = 1;//zapisze jako Paragon
            teaShopEntities.DokumentSprzedazy.Add(item);

            foreach (var itemTowar in towary)
            {
                DokumentSprzedazyTowar towar = new DokumentSprzedazyTowar()
                {
                    IdTowar = itemTowar,
                    IdDokumentSprzedazy = item.IdDokumentuSprzedazy,
                    Ilosc = 1,
                };
                teaShopEntities.DokumentSprzedazyTowar.Add(towar);
                var towarOdejmowanie = teaShopEntities.Towar.Find(itemTowar);
                towarOdejmowanie.Ilosc -= 1;

            }
            teaShopEntities.SaveChanges();

        }
        private void ZakladkaWybierzKontrahenta()
        {
            Messenger.Default.Send("WybierzKontrahenta");
        }
        private void ZakladkaWybierzTowar()
        {
            Messenger.Default.Send("WybierzTowar");
        }

        private void getWybranyKontrahent(KontrahentForView kontrahent)
        {
            IdKontrahenta = kontrahent.IdKontrahenta;
            KontrahentNip = kontrahent.NIPDane;
            KontrahentNazwa = kontrahent.NazwaDane;

            KontrahentImie = kontrahent.ImieDane;
            KontrahentNazwisko = kontrahent.NazwiskoDane;
            KontrahentREGON = kontrahent.REGONDane;
            KontrahentRabat = kontrahent.RabatDane;
            KontrahentEmail = kontrahent.EmailDane;
            KontrahentTelefon = kontrahent.TelefonDane;
        }
        private void getWybranyTowar(TowarForAllView towar)
        {
            towary.Add(towar.IdTowaru);
            NazwaTowaru = towar.MarkaT + " " + towar.Nazwa + "\n";
        }
        #endregion
    }
}
