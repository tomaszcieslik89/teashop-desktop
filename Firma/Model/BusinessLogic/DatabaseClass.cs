using Firma.Model.Entities;

namespace Firma.Model.BusinessLogic
{
    public class DatabaseClass
    {
        #region  Fields and Properties
        private TeaShopEntities _teaShopEntities;

        public TeaShopEntities teaShopEntities
        {
            get
            {
                return _teaShopEntities;
            }
            set
            {
                if (_teaShopEntities != value)
                    _teaShopEntities = value;
            }
        }
        #endregion
        #region  Constructor
        public DatabaseClass(TeaShopEntities teaShopEntities)
        {
            this.teaShopEntities = teaShopEntities;
        }
        #endregion
    }
}

