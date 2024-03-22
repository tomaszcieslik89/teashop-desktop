using Firma.Model.Entities;
using System;
using System.Linq;

namespace Firma.Model.BusinessLogic
{
    public class UtargB : DatabaseClass
    {
        #region Constructor
        public UtargB(TeaShopEntities teaShopEntities)
            : base(teaShopEntities)
        { }
        #endregion
        #region BusinessFunction
        public decimal? UtargOkresTowar(int idTowaru, DateTime dataOd, DateTime dataDo)
        {
            var UtargB = (
                 from PozycjaDokumentu in teaShopEntities.DokumentSprzedazy
                 join DokumentSprzedazyTowar in teaShopEntities.DokumentSprzedazyTowar on PozycjaDokumentu.IdDokumentuSprzedazy equals DokumentSprzedazyTowar.IdDokumentSprzedazy
                 where
                     DokumentSprzedazyTowar.IdTowar == idTowaru &&    
             PozycjaDokumentu.DataWystawienia >= dataOd &&  
             PozycjaDokumentu.DataWystawienia <= dataDo       
                 select DokumentSprzedazyTowar.Ilosc * DokumentSprzedazyTowar.Towar.CenaNetto * (1 + (DokumentSprzedazyTowar.Towar.StawkaVatSprzedazy / 100)) * (1 + (DokumentSprzedazyTowar.Towar.Marza / 100))
             ).Sum();
            if (UtargB.HasValue)
            {
                string roundedUtarg = UtargB.Value.ToString("0.00");
                return decimal.Parse(roundedUtarg);
            }
            else
            {
                decimal zero = (0.00M);
                return zero;
            }
        }
        public decimal? UtargRodzajDokumentu(int idTowaru, DateTime dataOd, DateTime dataDo, int IdRodzajDokumentu)
        {
            var UtargB = (
                 from PozycjaDokumentu in teaShopEntities.DokumentSprzedazy
                 join DokumentSprzedazyTowar in teaShopEntities.DokumentSprzedazyTowar on PozycjaDokumentu.IdDokumentuSprzedazy equals DokumentSprzedazyTowar.IdDokumentSprzedazy
                 where
                     DokumentSprzedazyTowar.IdTowar == idTowaru &&   
             PozycjaDokumentu.DataWystawienia >= dataOd &&  
             PozycjaDokumentu.DataWystawienia <= dataDo &&     
                PozycjaDokumentu.IdRodzajuDokumentow == IdRodzajDokumentu
                 select DokumentSprzedazyTowar.Ilosc * DokumentSprzedazyTowar.Towar.CenaNetto * (1 + (DokumentSprzedazyTowar.Towar.StawkaVatSprzedazy / 100)) * (1 + (DokumentSprzedazyTowar.Towar.Marza / 100))
             ).Sum();
            if (UtargB.HasValue)
            {
                string roundedUtarg = UtargB.Value.ToString("0.00");
                return decimal.Parse(roundedUtarg);
            }
            else
            {
                decimal zero = (0.00M);
                return zero;
            }
        }
    }
}
#endregion


