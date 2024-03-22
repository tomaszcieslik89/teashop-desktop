using Firma.Helpers;
using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using Firma.ViewModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class ZaplanujUrlopViewModel : JedenViewModel<Urlop>
    {
        #region Constructor
        public ZaplanujUrlopViewModel()
           : base("Zaplanuj urlop")
        {
            item = new Urlop();
        }
        #endregion
        #region Properties 
        public int IdUrlopu
        {
            get
            {
                return item.IdUrlopu;
            }
            set
            {
                if (item.IdUrlopu != value)
                {
                    item.IdUrlopu = value;
                    base.OnPropertyChanged(() => IdUrlopu);
                }
            }
        }

        public decimal? WykorzystanoU
        {
            get
            {
                return item.WykorzystanoU;
            }
            set
            {
                if (item.WykorzystanoU != value)
                {
                    item.WykorzystanoU = value;
                    base.OnPropertyChanged(() => WykorzystanoU);
                }
            }
        }

        public decimal? DodatkoweDniUrlopu
        {
            get
            {
                return item.DodatkoweDniUrlopu;
            }
            set
            {
                if (item.DodatkoweDniUrlopu != value)
                {
                    item.DodatkoweDniUrlopu = value;
                    base.OnPropertyChanged(() => DodatkoweDniUrlopu);
                }
            }
        }

        public DateTime? DataRozpUrlopuU
        {
            get
            {
                return item.DataRozpUrlopuU;
            }
            set
            {
                if (item.DataRozpUrlopuU != value)
                {
                    item.DataRozpUrlopuU = value;
                    base.OnPropertyChanged(() => DataRozpUrlopuU);
                }
            }
        }

        public string RodzajUrlopuU
        {
            get
            {
                return item.RodzajUrlopuU;
            }
            set
            {
                if (item.RodzajUrlopuU != value)
                {
                    item.RodzajUrlopuU = value;
                    base.OnPropertyChanged(() => RodzajUrlopuU);
                }
            }
        }

        public string RodzajUmowyU
        {
            get
            {
                return item.RodzajUmowyU;
            }
            set
            {
                if (item.RodzajUmowyU != value)
                {
                    item.RodzajUmowyU = value;
                    base.OnPropertyChanged(() => RodzajUmowyU);
                }
            }
        }

        public string WymiarEtatuU
        {
            get
            {
                return item.WymiarEtatuU;
            }
            set
            {
                if (item.WymiarEtatuU != value)
                {
                    item.WymiarEtatuU = value;
                    base.OnPropertyChanged(() => WymiarEtatuU);
                }
            }
        }

        public decimal? LimitUrlopuU
        {
            get
            {
                return item.LimitUrlopuU;
            }
            set
            {
                if (item.LimitUrlopuU != value)
                {
                    item.LimitUrlopuU = value;
                    base.OnPropertyChanged(() => LimitUrlopuU);
                }
            }
        }

        public string NazwaPracownikU
        {
            get
            {
                return item.NazwaPracownikU;
            }
            set
            {
                if (item.NazwaPracownikU != value)
                {
                    item.NazwaPracownikU = value;
                    base.OnPropertyChanged(() => NazwaPracownikU);
                }
            }
        }

        public string ImieU
        {
            get
            {
                return item.ImieU;
            }
            set
            {
                if (item.ImieU != value)
                {
                    item.ImieU = value;
                    base.OnPropertyChanged(() => ImieU);
                }
            }
        }

        public string DrugieImieU
        {
            get
            {
                return item.DrugieImieU;
            }
            set
            {
                if (item.DrugieImieU != value)
                {
                    item.DrugieImieU = value;
                    base.OnPropertyChanged(() => DrugieImieU);
                }
            }
        }

        public string NazwiskoU
        {
            get
            {
                return item.NazwiskoU;
            }
            set
            {
                if (item.NazwiskoU != value)
                {
                    item.NazwiskoU = value;
                    base.OnPropertyChanged(() => NazwiskoU);
                }
            }
        }

        public string NazwiskoRodMatU
        {
            get
            {
                return item.NazwiskoRodMatU;
            }
            set
            {
                if (item.NazwiskoRodMatU != value)
                {
                    item.NazwiskoRodMatU = value;
                    base.OnPropertyChanged(() => NazwiskoRodMatU);
                }
            }
        }

        public string ImieOjcaU
        {
            get
            {
                return item.ImieOjcaU;
            }
            set
            {
                if (item.ImieOjcaU != value)
                {
                    item.ImieOjcaU = value;
                    base.OnPropertyChanged(() => ImieOjcaU);
                }
            }
        }

        public string ImieMatkiU
        {
            get
            {
                return item.ImieMatkiU;
            }
            set
            {
                if (item.ImieMatkiU != value)
                {
                    item.ImieMatkiU = value;
                    base.OnPropertyChanged(() => ImieMatkiU);
                }
            }
        }

        public string MiejscowoscU
        {
            get
            {
                return item.MiejscowoscU;
            }
            set
            {
                if (item.MiejscowoscU != value)
                {
                    item.MiejscowoscU = value;
                    base.OnPropertyChanged(() => MiejscowoscU);
                }
            }
        }

        public DateTime? DataUrodzeniaU
        {
            get
            {
                return item.DataUrodzeniaU;
            }
            set
            {
                if (item.DataUrodzeniaU != value)
                {
                    item.DataUrodzeniaU = value;
                    base.OnPropertyChanged(() => DataUrodzeniaU);
                }
            }
        }

        public string KrajU
        {
            get
            {
                return item.KrajU;
            }
            set
            {
                if (item.KrajU != value)
                {
                    item.KrajU = value;
                    base.OnPropertyChanged(() => KrajU);
                }
            }
        }

        public string PowiatU
        {
            get
            {
                return item.PowiatU;
            }
            set
            {
                if (item.PowiatU != value)
                {
                    item.PowiatU = value;
                    base.OnPropertyChanged(() => PowiatU);
                }
            }
        }

        public string GminaU
        {
            get
            {
                return item.GminaU;
            }
            set
            {
                if (item.GminaU != value)
                {
                    item.GminaU = value;
                    base.OnPropertyChanged(() => GminaU);
                }
            }
        }

        public string NrPaszportuU
        {
            get
            {
                return item.NrPaszportuU;
            }
            set
            {
                if (item.NrPaszportuU != value)
                {
                    item.NrPaszportuU = value;
                    base.OnPropertyChanged(() => NrPaszportuU);
                }
            }
        }

        public string UlicaU
        {
            get
            {
                return item.UlicaU;
            }
            set
            {
                if (item.UlicaU != value)
                {
                    item.UlicaU = value;
                    base.OnPropertyChanged(() => UlicaU);
                }
            }
        }

        public string NrDomuU
        {
            get
            {
                return item.NrDomuU;
            }
            set
            {
                if (item.NrDomuU != value)
                {
                    item.NrDomuU = value;
                    base.OnPropertyChanged(() => NrDomuU);
                }
            }
        }

        public string NrLokaluU
        {
            get
            {
                return item.NrLokaluU;
            }
            set
            {
                if (item.NrLokaluU != value)
                {
                    item.NrLokaluU = value;
                    base.OnPropertyChanged(() => NrLokaluU);
                }
            }
        }

        public string TelefonU
        {
            get
            {
                return item.TelefonU;
            }
            set
            {
                if (item.TelefonU != value)
                {
                    item.TelefonU = value;
                    base.OnPropertyChanged(() => TelefonU);
                }
            }
        }

        public string EmailU
        {
            get
            {
                return item.EmailU;
            }
            set
            {
                if (item.EmailU != value)
                {
                    item.EmailU = value;
                    base.OnPropertyChanged(() => EmailU);
                }
            }
        }

        public string WojewodzctwoU
        {
            get
            {
                return item.WojewodzctwoU;
            }
            set
            {
                if (item.WojewodzctwoU != value)
                {
                    item.WojewodzctwoU = value;
                    base.OnPropertyChanged(() => WojewodzctwoU);
                }
            }
        }

        public DateTime? DataZakonczeniaUrlopu
        {
            get
            {
                return item.DataZakonczeniaUrlopu;
            }
            set
            {
                if (item.DataZakonczeniaUrlopu != value)
                {
                    item.DataZakonczeniaUrlopu = value;
                    base.OnPropertyChanged(() => DataZakonczeniaUrlopu);
                }
            }
        }

        public string StanowiskoU
        {
            get
            {
                return item.StanowiskoU;
            }
            set
            {
                if (item.StanowiskoU != value)
                {
                    item.StanowiskoU = value;
                    base.OnPropertyChanged(() => StanowiskoU);
                }
            }
        }
        #region Helpers
        public override void Save()
        {
            item.CzyAktywny = true;
            teaShopEntities.Urlop.Add(item);
            teaShopEntities.SaveChanges();
        }
        #endregion
        #endregion
    }
}
