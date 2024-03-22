using Firma.Model.Entities;
using Firma.Helpers;
using System;
using System.Windows.Input;

namespace Firma.ViewModel.Abstract
{
    public abstract class JedenViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        protected TeaShopEntities teaShopEntities;
        protected T item;
        #endregion
        #region Constructor

        public JedenViewModel(String displayName)
        {
            base.DisplayName = displayName;
            teaShopEntities = new TeaShopEntities();
        }
        #endregion
        #region Command
        private BaseCommand _SaveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => saveAndClose());
                return _SaveCommand;
            }
        }
        #endregion
        #region Helpers

        public abstract void Save();

        private void saveAndClose()
        {
            {
                Save();
                base.OnRequestClose();
            }
        }
        #endregion
    }
}