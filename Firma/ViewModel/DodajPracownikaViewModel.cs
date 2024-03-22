using Firma.Model.Entities;
using Firma.ViewModel.Abstract;
using System;

namespace Firma.ViewModel
{
    public class DodajPracownikaViewModel : JedenViewModel<Pracownik>
    {
        #region Constructor
        public DodajPracownikaViewModel()
         : base("Dodaj pracownika")
        {
            item = new Pracownik();
        }
        #endregion
        #region Properties

        public int IdPracownika
        {
            get
            {
                return item.IdPracownika;
            }
            set
            {
                if (item.IdPracownika != value)
                {
                    item.IdPracownika = value;
                    base.OnPropertyChanged(() => IdPracownika);
                }
            }
        }
        public string ImieP
        {
            get
            {
                return item.ImieP;
            }
            set
            {
                if (item.ImieP != value)
                {
                    item.ImieP = value;
                    base.OnPropertyChanged(() => ImieP);
                }
            }
        }
        public string DrugieImieP
        {
            get
            {
                return item.DrugieImieP;
            }
            set
            {
                if (item.DrugieImieP != value)
                {
                    item.DrugieImieP = value;
                    base.OnPropertyChanged(() => DrugieImieP);
                }
            }
        }
        public string NazwiskoP
        {
            get
            {
                return item.NazwiskoP;
            }
            set
            {
                if (item.NazwiskoP != value)
                {
                    item.NazwiskoP = value;
                    base.OnPropertyChanged(() => NazwiskoP);
                }
            }
        }
        public string NazwiskoRodoweP
        {
            get
            {
                return item.NazwiskoRodoweP;
            }
            set
            {
                if (item.NazwiskoRodoweP != value)
                {
                    item.NazwiskoRodoweP = value;
                    base.OnPropertyChanged(() => NazwiskoRodoweP);
                }
            }
        }
        public string ImieOjcaP
        {
            get
            {
                return item.ImieOjcaP;
            }
            set
            {
                if (item.ImieOjcaP != value)
                {
                    item.ImieOjcaP = value;
                    base.OnPropertyChanged(() => ImieOjcaP);
                }
            }
        }
        public string ImieMatkiP
        {
            get
            {
                return item.ImieMatkiP;
            }
            set
            {
                if (item.ImieMatkiP != value)
                {
                    item.ImieMatkiP = value;
                    base.OnPropertyChanged(() => ImieMatkiP);
                }
            }
        }
        public string NrPaszportuP
        {
            get
            {
                return item.NrPaszportuP;
            }
            set
            {
                if (item.NrPaszportuP != value)
                {
                    item.NrPaszportuP = value;
                    base.OnPropertyChanged(() => NrPaszportuP);
                }
            }
        }
        public decimal? PESELP
        {
            get
            {
                return item.PESELP;
            }
            set
            {
                if (item.PESELP != value)
                {
                    item.PESELP = value;
                    base.OnPropertyChanged(() => PESELP);
                }
            }
        }
        public string TelefonP
        {
            get
            {
                return item.TelefonP;
            }
            set
            {
                if (item.TelefonP != value)
                {
                    item.TelefonP = value;
                    base.OnPropertyChanged(() => TelefonP);
                }
            }
        }
        public string EmailP
        {
            get
            {
                return item.EmailP;
            }
            set
            {
                if (item.EmailP != value)
                {
                    item.EmailP = value;
                    base.OnPropertyChanged(() => EmailP);
                }
            }
        }
        public DateTime? DataUrodzeniaP
        {
            get
            {
                return item.DataUrodzeniaP;
            }
            set
            {
                if (item.DataUrodzeniaP != value)
                {
                    item.DataUrodzeniaP = value;
                    base.OnPropertyChanged(() => DataUrodzeniaP);
                }
            }
        }
        public string PowiatP
        {
            get
            {
                return item.PowiatP;
            }
            set
            {
                if (item.PowiatP != value)
                {
                    item.PowiatP = value;
                    base.OnPropertyChanged(() => PowiatP);
                }
            }
        }
        public string MiejscowoscP
        {
            get
            {
                return item.MiejscowoscP;
            }
            set
            {
                if (item.MiejscowoscP != value)
                {
                    item.MiejscowoscP = value;
                    base.OnPropertyChanged(() => MiejscowoscP);
                }
            }
        }
        public string UlicaP
        {
            get
            {
                return item.UlicaP;
            }
            set
            {
                if (item.UlicaP != value)
                {
                    item.UlicaP = value;
                    base.OnPropertyChanged(() => UlicaP);
                }
            }
        }
        public string GminaP
        {
            get
            {
                return item.GminaP;
            }
            set
            {
                if (item.GminaP != value)
                {
                    item.GminaP = value;
                    base.OnPropertyChanged(() => GminaP);
                }
            }
        }
        public string KodPocztowyP
        {
            get
            {
                return item.KodPocztowyP;
            }
            set
            {
                if (item.KodPocztowyP != value)
                {
                    item.KodPocztowyP = value;
                    base.OnPropertyChanged(() => KodPocztowyP);
                }
            }
        }
        public string NrDomuP
        {
            get
            {
                return item.NrDomuP;
            }
            set
            {
                if (item.NrDomuP != value)
                {
                    item.NrDomuP = value;
                    base.OnPropertyChanged(() => NrDomuP);
                }
            }
        }
        public string NrLokaluP
        {
            get
            {
                return item.NrLokaluP;
            }
            set
            {
                if (item.NrLokaluP != value)
                {
                    item.NrLokaluP = value;
                    base.OnPropertyChanged(() => NrLokaluP);
                }
            }
        }
        public DateTime? DataRozpPracyP
        {
            get
            {
                return item.DataRozpPracyP;
            }
            set
            {
                if (item.DataRozpPracyP != value)
                {
                    item.DataRozpPracyP = value;
                    base.OnPropertyChanged(() => DataRozpPracyP);
                }
            }
        }
        public DateTime? DataZatrudnieniaP
        {
            get
            {
                return item.DataZatrudnieniaP;
            }
            set
            {
                if (item.DataZatrudnieniaP != value)
                {
                    item.DataZatrudnieniaP = value;
                    base.OnPropertyChanged(() => DataZatrudnieniaP);
                }
            }
        }
        public DateTime? DataZwolnieniaP
        {
            get
            {
                return item.DataZwolnieniaP;
            }
            set
            {
                if (item.DataZwolnieniaP != value)
                {
                    item.DataZwolnieniaP = value;
                    base.OnPropertyChanged(() => DataZwolnieniaP);
                }
            }
        }
        public string WymiarEtatuP
        {
            get
            {
                return item.WymiarEtatuP;
            }
            set
            {
                if (item.WymiarEtatuP != value)
                {
                    item.WymiarEtatuP = value;
                    base.OnPropertyChanged(() => WymiarEtatuP);
                }
            }
        }
        public decimal? StawkaP
        {
            get
            {
                return item.StawkaP;
            }
            set
            {
                if (item.StawkaP != value)
                {
                    item.StawkaP = value;
                    base.OnPropertyChanged(() => StawkaP);
                }
            }
        }
        public decimal? LimitUrlopuP
        {
            get
            {
                return item.LimitUrlopuP;
            }
            set
            {
                if (item.LimitUrlopuP != value)
                {
                    item.LimitUrlopuP = value;
                    base.OnPropertyChanged(() => LimitUrlopuP);
                }
            }
        }
        public decimal? DodatkoweDniUrlopuP
        {
            get
            {
                return item.DodatkoweDniUrlopuP;
            }
            set
            {
                if (item.DodatkoweDniUrlopuP != value)
                {
                    item.DodatkoweDniUrlopuP = value;
                    base.OnPropertyChanged(() => DodatkoweDniUrlopuP);
                }
            }
        }
        public decimal? WykorzystanoP
        {
            get
            {
                return item.WykorzystanoP;
            }
            set
            {
                if (item.WykorzystanoP != value)
                {
                    item.WykorzystanoP = value;
                    base.OnPropertyChanged(() => WykorzystanoP);
                }
            }
        }
        public decimal? PozostaloP
        {
            get
            {
                return item.PozostaloP;
            }
            set
            {
                if (item.PozostaloP != value)
                {
                    item.PozostaloP = value;
                    base.OnPropertyChanged(() => PozostaloP);
                }
            }
        }
        public string KrajP
        {
            get
            {
                return item.KrajP;
            }
            set
            {
                if (item.KrajP != value)
                {
                    item.KrajP = value;
                    base.OnPropertyChanged(() => KrajP);
                }
            }
        }
        public string PlecP
        {
            get
            {
                return item.PlecP;
            }
            set
            {
                if (item.PlecP != value)
                {
                    item.PlecP = value;
                    base.OnPropertyChanged(() => PlecP);
                }
            }
        }
        public string WojewodzctwoP
        {
            get
            {
                return item.WojewodzctwoP;
            }
            set
            {
                if (item.WojewodzctwoP != value)
                {
                    item.WojewodzctwoP = value;
                    base.OnPropertyChanged(() => WojewodzctwoP);
                }
            }
        }
        public string RodzajUmowyP
        {
            get
            {
                return item.RodzajUmowyP;
            }
            set
            {
                if (item.RodzajUmowyP != value)
                {
                    item.RodzajUmowyP = value;
                    base.OnPropertyChanged(() => RodzajUmowyP);
                }
            }
        }
        public string RodzajZatrudnieniaP
        {
            get
            {
                return item.RodzajZatrudnieniaP;
            }
            set
            {
                if (item.RodzajZatrudnieniaP != value)
                {
                    item.RodzajZatrudnieniaP = value;
                    base.OnPropertyChanged(() => RodzajZatrudnieniaP);
                }
            }
        }
        public string StanowiskoP
        {
            get
            {
                return item.StanowiskoP;
            }
            set
            {
                if (item.StanowiskoP != value)
                {
                    item.StanowiskoP = value;
                    base.OnPropertyChanged(() => StanowiskoP);
                }
            }
        }
        #endregion
        #region Helpers
        public override void Save()
        {
            item.CzyAktywny = true;
            teaShopEntities.Pracownik.Add(item);
            teaShopEntities.SaveChanges();
        }
        #endregion
    }
}