using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
    public class NowyKontrahentViewModel : JedenViewModel<DanePersonalne>
    {
        #region Constructor
        public NowyKontrahentViewModel()        
            : base("Nowy kontrahent")
        {
            item = new DanePersonalne();
        }
        #endregion
        #region Properties 

        public int IdDanePersonalne
        {
            get
            {
                return item.IdDanePersonalne;
            }
            set
            {
                if (item.IdDanePersonalne != value)
                {
                    item.IdDanePersonalne = value;
                    base.OnPropertyChanged(() => IdDanePersonalne);
                }
            }
        }

        public string Wojewodztwo
        {
            get
            {
                return item.Wojewodztwo;
            }
            set
            {
                if (item.Wojewodztwo != value)
                {
                    item.Wojewodztwo = value;
                    base.OnPropertyChanged(() => Wojewodztwo);
                }
            }
        }

        public string KodDane
        {
            get
            {
                return item.KodDane;
            }
            set
            {
                if (item.KodDane != value)
                {
                    item.KodDane = value;
                    base.OnPropertyChanged(() => KodDane);
                }
            }
        }
         public string KodPocztowyDane
        {
            get
            {
                return item.KodPocztowyDane;
            }
            set
            {
                if (item.KodPocztowyDane != value)
                {
                    item.KodPocztowyDane = value;
                    base.OnPropertyChanged(() => KodPocztowyDane);
                }
            }
        }

        public string EmailDane
        {
            get
            {
                return item.EmailDane;
            }
            set
            {
                if (item.EmailDane != value)
                {
                    item.EmailDane = value;
                    base.OnPropertyChanged(() => EmailDane);
                }
            }
        }

        public string ImieDane
        {
            get
            {
                return item.ImieDane;
            }
            set
            {
                if (item.ImieDane != value)
                {
                    item.ImieDane = value;
                    base.OnPropertyChanged(() => ImieDane);
                }
            }
        }

        public string NazwiskoDane
        {
            get
            {
                return item.NazwiskoDane;
            }
            set
            {
                if (item.NazwiskoDane != value)
                {
                    item.NazwiskoDane = value;
                    base.OnPropertyChanged(() => NazwiskoDane);
                }
            }
        }

        public string TelefonDane
        {
            get
            {
                return item.TelefonDane;
            }
            set
            {
                if (item.TelefonDane != value)
                {
                    item.TelefonDane = value;
                    base.OnPropertyChanged(() => TelefonDane);
                }
            }
        }

        public string REGONDane
        {
            get
            {
                return item.REGONDane;
            }
            set
            {
                if (item.REGONDane != value)
                {
                    item.REGONDane = value;
                    base.OnPropertyChanged(() => REGONDane);
                }
            }
        }

        public string MiejscowoscDane
        {
            get
            {
                return item.MiejscowoscDane;
            }
            set
            {
                if (item.MiejscowoscDane != value)
                {
                    item.MiejscowoscDane = value;
                    base.OnPropertyChanged(() => MiejscowoscDane);
                }
            }
        }



        public string UlicaDane
        {
            get
            {
                return item.UlicaDane;
            }
            set
            {
                if (item.UlicaDane != value)
                {
                    item.UlicaDane = value;
                    base.OnPropertyChanged(() => UlicaDane);
                }
            }
        }

        public string NrDomuDane
        {
            get
            {
                return item.NrDomuDane;
            }
            set
            {
                if (item.NrDomuDane != value)
                {
                    item.NrDomuDane = value;
                    base.OnPropertyChanged(() => NrDomuDane);
                }
            }
        }

        public string NrLokaluDane
        {
            get
            {
                return item.NrLokaluDane;
            }
            set
            {
                if (item.NrLokaluDane != value)
                {
                    item.NrLokaluDane = value;
                    base.OnPropertyChanged(() => NrLokaluDane);
                }
            }
        }

        public string UwagiDane
        {
            get
            {
                return item.UwagiDane;
            }
            set
            {
                if (item.UwagiDane != value)
                {
                    item.UwagiDane = value;
                    base.OnPropertyChanged(() => UwagiDane);
                }
            }
        }

        public decimal? RabatDane
        {
            get
            {
                return item.RabatDane;
            }
            set
            {
                if (item.RabatDane != value)
                {
                    item.RabatDane = value;
                    base.OnPropertyChanged(() => RabatDane);
                }
            }
        }

        public string NazwaDane
        {
            get
            {
                return item.NazwaDane;
            }
            set
            {
                if (item.NazwaDane != value)
                {
                    item.NazwaDane = value;
                    base.OnPropertyChanged(() => NazwaDane);
                }
            }
        }

        public string BankDane
        {
            get
            {
                return item.BankDane;
            }
            set
            {
                if (item.BankDane != value)
                {
                    item.BankDane = value;
                    base.OnPropertyChanged(() => BankDane);
                }
            }
        }

        public string RachunekNrDane
        {
            get
            {
                return item.RachunekNrDane;
            }
            set
            {
                if (item.RachunekNrDane != value)
                {
                    item.RachunekNrDane = value;
                    base.OnPropertyChanged(() => RachunekNrDane);
                }
            }
        }

        public string NIPDane
        {
            get
            {
                return item.NIPDane;
            }
            set
            {
                if (item.NIPDane != value)
                {
                    item.NIPDane = value;
                    base.OnPropertyChanged(() => NIPDane);
                }
            }
        }

        public string Kraj
        {
            get
            {
                return item.Kraj;
            }
            set
            {
                if (item.Kraj != value)
                {
                    item.Kraj = value;
                    base.OnPropertyChanged(() => Kraj);
                }
            }
        }

        public string Plec
        {
            get
            {
                return item.Plec;
            }
            set
            {
                if (item.Plec != value)
                {
                    item.Plec = value;
                    base.OnPropertyChanged(() => Plec);
                }
            }
        }
        

        public string FormaPlatnosciDane
        {
            get
            {
                return item.FormaPlatnosciDane;
            }
            set
            {
                if (item.FormaPlatnosciDane != value)
                {
                    item.FormaPlatnosciDane = value;
                    base.OnPropertyChanged(() => FormaPlatnosciDane);
                }
            }
        }

        #endregion
        #region Helpers




        public override void Save()
        {
            item.CzyAktywny = true;
            teaShopEntities.DanePersonalne.Add(item);
            Kontrahent kontrahent = new Kontrahent()
            {
                IdDanePersonalne = item.IdDanePersonalne,
                CzyAktywny = true
            };
            teaShopEntities.Kontrahent.Add(kontrahent);
            teaShopEntities.SaveChanges();
        }
        #endregion

    }
}