using Firma.Model.Entities;
using Firma.Model.EntitiesForView;
using System.Linq;

namespace Firma.Model.BusinessLogic
{
    public class TowarB : DatabaseClass
    {
        #region Constructor
        public TowarB(TeaShopEntities teaShopEntities)
            : base(teaShopEntities)
        { }
        #endregion
        #region GetDataFunction
        public IQueryable<KeyAndValue> GetTowaryKeyAndValue()
                                                             
        {
            return
                (
                    from towar in teaShopEntities.Towar
                    where towar.CzyAktywny==true
                    select new KeyAndValue
                    {
                        Key = towar.IdTowaru,
                        Value = towar.Nazwa + " " + towar.Kod
                    }
                ).ToList().AsQueryable();

        }
        public IQueryable<KeyAndValue> GetProducentKeyAndValue()
        {
            return
                (
                    from producent in teaShopEntities.Producent
                    where producent.CzyAktywny == true
                    select new KeyAndValue
                    {
                        Key = producent.IdProducenta,
                        Value = producent.NazwaProducenta + " " 
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}