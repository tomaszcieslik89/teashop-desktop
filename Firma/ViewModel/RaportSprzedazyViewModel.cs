using Firma.Helpers;
using Firma.Model.BusinessLogic;
using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class RaportSprzedazyViewModel : WorkspaceViewModel
    {
        #region Constructor
        public RaportSprzedazyViewModel()
        {
            base.DisplayName = "Raport sprzedazy";
            teaShopEntities = new TeaShopEntities();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
            Utarg = 0;
        }
        #endregion
        #region Fields and properties
        private TeaShopEntities teaShopEntities;
        private DateTime _DataOd;
        public DateTime DataOd
        {
            get
            {
                return _DataOd;
            }
            set
            {
                if (_DataOd != value)
                {
                    _DataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }
        private DateTime _DataDo;
        public DateTime DataDo
        {
            get
            {
                return _DataDo;
            }
            set
            {
                if (_DataDo != value)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }
        private int _IdTowaru;
        public int IdTowaru
        {
            get
            {
                return _IdTowaru;
            }
            set
            {
                if (_IdTowaru != value)
                {
                    _IdTowaru = value;
                    OnPropertyChanged(() => IdTowaru);
                }
            }
        }
        private decimal? _Utarg;
        public decimal? Utarg
        {
            get
            {
                return _Utarg;
            }
            set
            {
                if (_Utarg != value)
                {
                    _Utarg = value;
                    OnPropertyChanged(() => Utarg);
                }
            }
        }

        private decimal? _UtargFaktura;
        public decimal? UtargFaktura
        {
            get
            {
                return _UtargFaktura;
            }
            set
            {
                if (_UtargFaktura != value)
                {
                    _UtargFaktura = value;
                    OnPropertyChanged(() => UtargFaktura);
                }
            }
        }

        private decimal? _UtargParagon;
        public decimal? UtargParagon
        {
            get
            {
                return _UtargParagon;
            }
            set
            {
                if (_UtargParagon != value)
                {
                    _UtargParagon = value;
                    OnPropertyChanged(() => UtargParagon);
                }
            }
        }

        private decimal? _StanMagazynowy;
        public decimal? StanMagazynowy
        {
            get
            {
                return _StanMagazynowy;
            }
            set
            {
                if (_StanMagazynowy != value)
                {
                    _StanMagazynowy = value;
                    OnPropertyChanged(() => StanMagazynowy);
                }
            }
        }

        private decimal? _StanMagazynowyProducenta;
        public decimal? StanMagazynowyProducenta
        {
            get
            {
                return _StanMagazynowyProducenta;
            }
            set
            {
                if (_StanMagazynowyProducenta != value)
                {
                    _StanMagazynowyProducenta = value;
                    OnPropertyChanged(() => StanMagazynowyProducenta);
                }
            }
        }


        private List<MalaIloscTowaruModel> _MalaIloscTowaru;
        public List<MalaIloscTowaruModel> MalaIloscTowaru
        {
            get
            {
                return _MalaIloscTowaru;
            }
            set
            {
                if (_MalaIloscTowaru != value)
                {
                    _MalaIloscTowaru = value;
                    OnPropertyChanged(() => MalaIloscTowaru);
                }
            }
        }



        private int _IdTowaruMagazynu;
        public int IdTowaruMagazynu
        {
            get
            {
                return _IdTowaruMagazynu;
            }
            set
            {
                if (_IdTowaruMagazynu != value)
                {
                    _IdTowaruMagazynu = value;
                    OnPropertyChanged(() => IdTowaruMagazynu);
                }
            }
        }

        private int _IdProducentRaport;
        public int IdProducentRaport
        {
            get
            {
                return _IdProducentRaport;
            }
            set
            {
                if (_IdProducentRaport != value)
                {
                    _IdProducentRaport = value;
                    OnPropertyChanged(() => _IdProducentRaport);
                }
            }
        }
        public IQueryable<KeyAndValue> TowaryComboBoxItems
        {
            get
            {
                return new TowarB(teaShopEntities).GetTowaryKeyAndValue();
            }
        }
        public IQueryable<KeyAndValue> ProducentComboBoxItems
        {
            get
            {
                return new TowarB(teaShopEntities).GetProducentKeyAndValue();
            }
        }
        #endregion
        #region Command
        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                    _ObliczCommand = new BaseCommand(() => obliczUtargClick());
                return _ObliczCommand;
            }
        }

        private BaseCommand _ObliczStanMagazynowyCommand;

        public ICommand ObliczStanMagazynowyCommand
        {
            get
            {
                if (_ObliczStanMagazynowyCommand == null)
                    _ObliczStanMagazynowyCommand = new BaseCommand(() => obliczStanMagazynowyClick());
                return _ObliczStanMagazynowyCommand;
            }
        }


        private BaseCommand _ObliczStanMagazynowyProducentCommand;

        public ICommand ObliczStanMagazynowyProducentCommand
        {
            get
            {
                if (_ObliczStanMagazynowyProducentCommand == null)
                    _ObliczStanMagazynowyProducentCommand = new BaseCommand(() => obliczStanMagazynowyProducentClick());
                return _ObliczStanMagazynowyProducentCommand;
            }
        }
        private BaseCommand _WyswietlMalaIloscTowaruCommand;

        public ICommand WyswietlMalaIloscTowaruCommand
        {
            get
            {
                if (_WyswietlMalaIloscTowaruCommand == null)
                    _WyswietlMalaIloscTowaruCommand = new BaseCommand(() => wyswietlMalaIloscTowaruClick());
                return _WyswietlMalaIloscTowaruCommand;
            }
        }
        #endregion
        #region Helpers
        private void obliczUtargClick()
        {
            UtargB utargB = new UtargB(teaShopEntities);
            Utarg = utargB.UtargOkresTowar(IdTowaru, DataOd, DataDo);
            UtargFaktura = utargB.UtargRodzajDokumentu(IdTowaru, DataOd, DataDo, 2);
            UtargParagon = utargB.UtargRodzajDokumentu(IdTowaru, DataOd, DataDo, 1);

        }
        private void obliczStanMagazynowyClick()
        {
            StanyMagazynoweB stanyMagazynoweB = new StanyMagazynoweB(teaShopEntities);
            StanMagazynowy = stanyMagazynoweB.ObliczStanMagazynowy(IdTowaruMagazynu);
        }
        private void obliczStanMagazynowyProducentClick()
        {
            StanyMagazynoweB stanyMagazynoweB = new StanyMagazynoweB(teaShopEntities);
            StanMagazynowyProducenta = stanyMagazynoweB.ObliczStanMagazynowyProducentClick(IdProducentRaport);
        }
        private void wyswietlMalaIloscTowaruClick()
        {
            StanyMagazynoweB stanyMagazynoweB = new StanyMagazynoweB(teaShopEntities);
            MalaIloscTowaru = stanyMagazynoweB.wyswietlMalaIloscTowaruClick();
        }
        #endregion
    }
}