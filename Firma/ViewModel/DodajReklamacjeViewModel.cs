using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;

namespace Firma.ViewModel
{
    public class DodajReklamacjeViewModel : JedenViewModel<Reklamacje> //bo wszystkie ViewModel obsługujące zakładki bd dziedziczyc po WorkspaceViewModel
    {
        #region Constructor
        public DodajReklamacjeViewModel()
            : base("Reklamacje")
        {
            item = new Reklamacje();
        }
        #endregion
        #region Properties
        public DateTime? DataZakupu
        {
            get
            {
                return item.DataZakupu;
            }
            set
            {
                if (item.DataZakupu != value)
                {
                    item.DataZakupu = value;
                    base.OnPropertyChanged(() => DataZakupu);
                }
            }
        }

        public DateTime? DataPowstaniaWady
        {
            get
            {
                return item.DataPowstaniaWady;
            }
            set
            {
                if (item.DataPowstaniaWady != value)
                {
                    item.DataPowstaniaWady = value;
                    base.OnPropertyChanged(() => DataPowstaniaWady);
                }
            }
        }

        public DateTime? DataGwarancjiDo
        {
            get
            {
                return item.DataGwarancjiDo;
            }
            set
            {
                if (item.DataGwarancjiDo != value)
                {
                    item.DataGwarancjiDo = value;
                    base.OnPropertyChanged(() => DataGwarancjiDo);
                }
            }
        }

        public int IdReklamacji
        {
            get
            {
                return item.IdReklamacji;
            }
            set
            {
                if (item.IdReklamacji != value)
                {
                    item.IdReklamacji = value;
                    base.OnPropertyChanged(() => IdReklamacji);
                }
            }
        }

        public string ImieR
        {
            get
            {
                return item.ImieR;
            }
            set
            {
                if (item.ImieR != value)
                {
                    item.ImieR = value;
                    base.OnPropertyChanged(() => ImieR);
                }
            }
        }

        public string TelefonR
        {
            get
            {
                return item.TelefonR;
            }
            set
            {
                if (item.TelefonR != value)
                {
                    item.TelefonR = value;
                    base.OnPropertyChanged(() => TelefonR);
                }
            }
        }

        public string NazwiskoR
        {
            get
            {
                return item.NazwiskoR;
            }
            set
            {
                if (item.NazwiskoR != value)
                {
                    item.NazwiskoR = value;
                    base.OnPropertyChanged(() => NazwiskoR);
                }
            }
        }

        public string EmailR
        {
            get
            {
                return item.EmailR;
            }
            set
            {
                if (item.EmailR != value)
                {
                    item.EmailR = value;
                    base.OnPropertyChanged(() => EmailR);
                }
            }
        }


        public string MiejscowoscR
        {
            get
            {
                return item.MiejscowoscR;
            }
            set
            {
                if (item.MiejscowoscR != value)
                {
                    item.MiejscowoscR = value;
                    base.OnPropertyChanged(() => MiejscowoscR);
                }
            }
        }
        public string UlicaR
        {
            get
            {
                return item.UlicaR;
            }
            set
            {
                if (item.UlicaR != value)
                {
                    item.UlicaR = value;
                    base.OnPropertyChanged(() => UlicaR);
                }
            }
        }

        public string NrDomuR
        {
            get
            {
                return item.NrDomuR;
            }
            set
            {
                if (item.NrDomuR != value)
                {
                    item.NrDomuR = value;
                    base.OnPropertyChanged(() => NrDomuR);
                }
            }
        }



        public string KodPocztowyR
        {
            get
            {
                return item.KodPocztowyR;
            }
            set
            {
                if (item.KodPocztowyR != value)
                {
                    item.KodPocztowyR = value;
                    base.OnPropertyChanged(() => KodPocztowyR);
                }
            }
        }

        public string NrLokaluR
        {
            get
            {
                return item.NrLokaluR;
            }
            set
            {
                if (item.NrLokaluR != value)
                {
                    item.NrLokaluR = value;
                    base.OnPropertyChanged(() => NrLokaluR);
                }
            }
        }


        public string PESELR
        {
            get
            {
                return item.PESELR;
            }
            set
            {
                if (item.PESELR != value)
                {
                    item.PESELR = value;
                    base.OnPropertyChanged(() => PESELR);
                }
            }
        }

        public string TowaryR
        {
            get
            {
                return item.TowaryR;
            }
            set
            {
                if (item.TowaryR != value)
                {
                    item.TowaryR = value;
                    base.OnPropertyChanged(() => TowaryR);
                }
            }
        }

        public string DostawcaR
        {
            get
            {
                return item.DostawcaR;
            }
            set
            {
                if (item.DostawcaR != value)
                {
                    item.DostawcaR = value;
                    base.OnPropertyChanged(() => DostawcaR);
                }
            }
        }

        public string IloscR
        {
            get
            {
                return item.IloscR;
            }
            set
            {
                if (item.IloscR != value)
                {
                    item.IloscR = value;
                    base.OnPropertyChanged(() => IloscR);
                }
            }
        }

        public string JednostkaR
        {
            get
            {
                return item.JednostkaR;
            }
            set
            {
                if (item.JednostkaR != value)
                {
                    item.JednostkaR = value;
                    base.OnPropertyChanged(() => JednostkaR);
                }
            }
        }

        public string DokumentR
        {
            get
            {
                return item.DokumentR;
            }
            set
            {
                if (item.DokumentR != value)
                {
                    item.DokumentR = value;
                    base.OnPropertyChanged(() => DokumentR);
                }
            }
        }

        public string OpisR
        {
            get
            {
                return item.OpisR;
            }
            set
            {
                if (item.OpisR != value)
                {
                    item.OpisR = value;
                    base.OnPropertyChanged(() => OpisR);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            item.CzyAktywny = true;
            teaShopEntities.Reklamacje.Add(item);
            teaShopEntities.SaveChanges();
        }
        #endregion
    }
}



