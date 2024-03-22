using Firma.Model.Entities;
using Firma.ViewModel.Abstract;

namespace Firma.ViewModel
{
    public class NowyTowarViewModel : JedenViewModel<Towar>
    {
        #region Constructor
        public NowyTowarViewModel()
            : base("Towary")
        {
            item = new Towar();
        }
        #endregion
        #region Properties 
        public decimal? CenaNetto
        {
            get
            {
                return item.CenaNetto;
            }
            set
            {
                if (item.CenaNetto != value)
                {
                    item.CenaNetto = value;
                    base.OnPropertyChanged(() => CenaNetto);
                }
            }
        }

        public decimal? CenaBrutto
        {
            get
            {
                return item.CenaBrutto;
            }
            set
            {
                if (item.CenaBrutto != value)
                {
                    item.CenaBrutto = value;
                    base.OnPropertyChanged(() => item.CenaBrutto);
                }
            }
        }

        public string JednostkaMiary
        {
            get
            {
                return item.JednostkaMiary;
            }
            set
            {
                if (item.JednostkaMiary != value)
                {
                    item.JednostkaMiary = value;
                    base.OnPropertyChanged(() => item.JednostkaMiary);
                }
            }
        }

        public decimal? Marza
        {
            get
            {
                return item.Marza;
            }
            set
            {
                if (item.Marza != value)
                {
                    item.Marza = value;
                    base.OnPropertyChanged(() => item.Marza);
                }
            }
        }

        public decimal? StawkaVatZakupu
        {
            get
            {
                return item.StawkaVatZakupu;
            }
            set
            {
                if (item.StawkaVatZakupu != value)
                {
                    item.StawkaVatZakupu = value;
                    base.OnPropertyChanged(() => item.StawkaVatZakupu);
                }
            }
        }

        public decimal? StawkaVatSprzedazy
        {
            get
            {
                return item.StawkaVatSprzedazy;
            }
            set
            {
                if (item.StawkaVatSprzedazy != value)
                {
                    item.StawkaVatSprzedazy = value;
                    base.OnPropertyChanged(() => item.StawkaVatSprzedazy);
                }
            }
        }

        public string Kod
        {
            get
            {
                return item.Kod;
            }
            set
            {
                if (item.Kod != value)
                {
                    item.Kod = value;
                    base.OnPropertyChanged(() => item.Kod);
                }
            }
        }

        public string KodEan
        {
            get
            {
                return item.KodEan;
            }
            set
            {
                if (item.KodEan != value)
                {
                    item.KodEan = value;
                    base.OnPropertyChanged(() => item.KodEan);
                }
            }
        }

        public string Nazwa
        {
            get
            {
                return item.Nazwa;
            }
            set
            {
                if (item.Nazwa != value)
                {
                    item.Nazwa = value;
                    base.OnPropertyChanged(() => item.Nazwa);
                }
            }
        }

        public decimal? Ilosc
        {
            get
            {
                return item.Ilosc;
            }
            set
            {
                if (item.Ilosc != value)
                {
                    item.Ilosc = value;
                    base.OnPropertyChanged(() => item.Ilosc);
                }
            }
        }

        public int? IdProducenta
        {
            get
            {
                return item.IdProducenta;
            }
            set
            {
                if (item.IdProducenta != value)
                {
                    item.IdProducenta = value;
                    base.OnPropertyChanged(() => item.IdProducenta);
                }
            }
        }

        private string _TowarDodatkowe;

        public string TowarDodatkowe
        {
            get
            {
                return _TowarDodatkowe;
            }
            set
            {
                if (_TowarDodatkowe != value)
                {
                    _TowarDodatkowe = value;
                    base.OnPropertyChanged(() => TowarDodatkowe);
                }
            }
        }

        public string Opis
        {
            get
            {
                return item.Opis;
            }
            set
            {
                if (item.Opis != value)
                {
                    item.Opis = value;
                    base.OnPropertyChanged(() => item.Opis);
                }
            }
        }

        public int? idTypKontrahenta
        {
            get
            {
                return item.idTypKontrahenta;
            }
            set
            {
                if (item.idTypKontrahenta != value)
                {
                    item.idTypKontrahenta = value;
                    base.OnPropertyChanged(() => item.idTypKontrahenta);
                }
            }
        }

        public string MarkaT
        {
            get
            {
                return item.MarkaT;
            }
            set
            {
                if (item.MarkaT != value)
                {
                    item.MarkaT = value;
                    base.OnPropertyChanged(() => MarkaT);
                }
            }
        }


        public string ProducentT
        {
            get
            {
                return item.ProducentT;
            }
            set
            {
                if (item.ProducentT != value)
                {
                    item.ProducentT = value;
                    base.OnPropertyChanged(() => ProducentT);
                }
            }
        }


        public string KategoriaTowaruT
        {
            get
            {
                return item.KategoriaTowaruT;
            }
            set
            {
                if (item.KategoriaTowaruT != value)
                {
                    item.KategoriaTowaruT = value;
                    base.OnPropertyChanged(() => KategoriaTowaruT);
                }
            }
        }

        public int IdTowaru
        {
            get
            {
                return item.IdTowaru;
            }
            set
            {
                if (item.IdTowaru != value)
                {
                    item.IdTowaru = value;
                    base.OnPropertyChanged(() => IdTowaru);
                }
            }
        }

        #endregion
        #region Helpers

        public override void Save()
        {
            item.CzyAktywny = true;
            teaShopEntities.Towar.Add(item);
            teaShopEntities.SaveChanges();
        }
        #endregion
    }
}
