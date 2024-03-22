using Firma.Helpers;
using System;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public abstract class WorkspaceViewModel:BaseViewModel
    {
        #region Constructor
        public WorkspaceViewModel()
        {}
        #endregion
        #region CloseCommand
        private BaseCommand _CloseCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                    _CloseCommand = new BaseCommand(()=>this.OnRequestClose());
                return _CloseCommand;
            }
        }
        #endregion
        #region Helpers
        public event EventHandler RequestClose;
        protected void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        #endregion
    }
}
