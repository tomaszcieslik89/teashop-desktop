﻿using System;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class CommandViewModel : BaseViewModel
    {
        #region Properties
        public ICommand Command { get; private set; }
        #endregion
        #region Constructor
        public CommandViewModel(string displayName, ICommand command)
        {
            if (command == null)
                throw new ArgumentNullException("command");
            this.DisplayName = displayName;
            this.Command = command;
        }
        #endregion
    }
}
