using Firma.Helpers;
using Firma.Model.Entities;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Firma.ViewModel.Abstract
{
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        protected readonly TeaShopEntities teaShopEntities;
        private BaseCommand _LoadCommand;
        private BaseCommand _AddCommand;
        private BaseCommand _SortCommand;
        private BaseCommand _FindCommand;
        private BaseCommand _MinusCommand;
        private ObservableCollection<T> _List;
        #endregion
        #region Properties
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => load());
                }
                return _LoadCommand;
            }
        }

        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new BaseCommand(() => add());
                }
                return _AddCommand;
            }
        }

        public T Wybrany { get; set; }
        //Usuwanie
        public ICommand MinusCommand
        {
            get
            {
                if (_MinusCommand == null)
                {
                    _MinusCommand = new BaseCommand(() => minus());
                }
                return _MinusCommand;
            }
        }
        public List<string> SortComboboxItems
        {
            get
            {
                return getComboboxSortList();
            }
        }
        public string SortField { get; set; }

        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                {
                    _SortCommand = new BaseCommand(() => sort());
                }
                return _SortCommand;
            }
        }
        public List<string> FindComboboxItems
        {
            get
            {
                return getComboboxFindList();
            }
        }
        public string FindField { get; set; }

        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                {
                    _FindCommand = new BaseCommand(() => find());
                }
                return _FindCommand;
            }
        }
        public string FindTextBox { get; set; }

        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                    load();
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion
        #region Constructor
        public WszystkieViewModel(String displayName)
        {
            base.DisplayName = displayName;
            this.teaShopEntities = new TeaShopEntities();
        }
        #endregion
        #region Helpers
        public abstract void load();
        private void add()
        {
            Messenger.Default.Send(DisplayName);
        }

        public abstract void minus();
        public abstract void sort();
        public abstract List<string> getComboboxSortList();
        public abstract void find();
        public abstract List<string> getComboboxFindList();
        #endregion
    }
}
