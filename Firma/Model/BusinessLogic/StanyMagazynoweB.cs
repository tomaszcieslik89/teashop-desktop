using Firma.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Firma.Model.BusinessLogic
{
    public class StanyMagazynoweB : DatabaseClass
    {
        #region Constructor
        public StanyMagazynoweB(TeaShopEntities teaShopEntities)
            : base(teaShopEntities)
        { }
        #endregion
        #region BusinessFunction
        public decimal? ObliczStanMagazynowy(int idTowaru)
        {
            var UtargB = (
                 from towar in teaShopEntities.Towar
                 where
                     towar.IdTowaru == idTowaru
                 select towar.Ilosc
             ).Sum();
            return UtargB;
        }
        public decimal? ObliczStanMagazynowyProducentClick(int idProducenta)
        {
            var producent = teaShopEntities.Producent.Find(idProducenta);
            var UtargB = (
                 from towar in teaShopEntities.Towar
                 where
                     towar.ProducentT == producent.NazwaProducenta
                     //&& towar.CzyAktywny == true
                 select towar.Ilosc
             ).Sum();
            return UtargB;
        }
        public List<MalaIloscTowaruModel> wyswietlMalaIloscTowaruClick()
        {
            var wynik = teaShopEntities.Towar.Where(x => x.Ilosc < 20 && x.CzyAktywny == true).ToList();
            List<MalaIloscTowaruModel> lista = new List<MalaIloscTowaruModel>();
            foreach (var item in wynik)
            {
                MalaIloscTowaruModel model = new MalaIloscTowaruModel();
                model.Marka = item.MarkaT;
                model.Towar = item.Nazwa;
                model.Ilosc = item.Ilosc;
                lista.Add(model);
            }
            return lista;
        }
    }
}
#endregion


