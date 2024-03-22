using Firma.Helpers;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Constructor
        public MainWindowViewModel()
        {
            Messenger.Default.Register<string>(this, open);
        }
        #endregion

        private void open(string name)
        {
            switch (name)
            {
                case "Lista dokumentów": this.Create(new NowaFakturaViewModel()); break;
                case "Lista kontrahentów": this.Create(new NowyKontrahentViewModel()); break;
                case "Lista towarów": this.Create(new NowyTowarViewModel()); break;
                case "Etap reklamacji": this.Create(new DodajReklamacjeViewModel()); break;
                case "Lista pracowników": this.Create(new DodajPracownikaViewModel()); break;
                case "Urlopy": this.Create(new ZaplanujUrlopViewModel()); break;
                case "WybierzKontrahenta": this.ShowAllListaKontrahentow(true); break;
                case "WybierzTowar": this.ShowAllListaTowarow(true); break;
            }
        }
        #region Fields
        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion

        #region ToolBarComands

        private BaseCommand getCommand(BaseCommand _command, WorkspaceViewModel _workspase)
        {
            if (_command == null)
                _command = new BaseCommand(() => Create(_workspase));
            return _command;
        }

        private BaseCommand _CreateTowarCommand;
        public ICommand CreateTowarCommand
        {
            get
            {
                return getCommand(_CreateTowarCommand, new NowyTowarViewModel());
            }
        }

        private BaseCommand _CreateFakturaCommand;
        public ICommand CreateFakturaCommand
        {
            get
            {
                return getCommand(_CreateFakturaCommand, new NowaFakturaViewModel());
            }
        }

        private BaseCommand _CreateOProgramieCommand;
        public ICommand CreateOProgramieCommand
        {
            get
            {
                return getCommand(_CreateOProgramieCommand, new OProgramieViewModel());
            }
        }

        private BaseCommand _CreateParagonCommand;
        public ICommand CreateParagonCommand
        {
            get
            {
                return getCommand(_CreateParagonCommand, new NowyParagonViewModel());
            }
        }

        private BaseCommand _CreateProFormaCommand;
        public ICommand CreateProFormaCommand
        {
            get
            {
                return getCommand(_CreateProFormaCommand, new NowaFakturaProFormaViewModel());
            }
        }

        private BaseCommand _CreateNowyKontrahentCommand;
        public ICommand CreateNowyKontrahentCommand
        {
            get
            {
                return getCommand(_CreateNowyKontrahentCommand, new NowyKontrahentViewModel());
            }
        }

        private BaseCommand _CreateRaportSprzedazyCommand;
        public ICommand CreateRaportSprzedazyCommand
        {
            get
            {
                return getCommand(_CreateRaportSprzedazyCommand, new RaportSprzedazyViewModel());
            }
        }

        private BaseCommand _CreateUzytkownicyCommand;
        public ICommand CreateUzytkownicyCommand
        {
            get
            {
                return getCommand(_CreateUzytkownicyCommand, new UzytkownicyViewModel());
            }
        }

        private BaseCommand _CreateKoniecPracyCommand;
        public ICommand CreateKoniecPracyCommand
        {
            get
            {
                return getCommand(_CreateKoniecPracyCommand, new KoniecPracyViewModel());
            }
        }

        private BaseCommand _CreateListaKontrahentowCommand;
        public ICommand CreateListaKontrahentowCommand
        {
            get
            {
                return getCommand(_CreateListaKontrahentowCommand, new ListaKontrahentowViewModel(false));
            }
        }

        private BaseCommand _CreateDodajReklamacjeCommand;
        public ICommand CreateDodajReklamacjeCommand
        {
            get
            {
                return getCommand(_CreateDodajReklamacjeCommand, new DodajReklamacjeViewModel());
            }
        }

        private BaseCommand _CreateDodajPracownikaCommand;
        public ICommand CreateDodajPracownikaCommand
        {
            get
            {
                return getCommand(_CreateDodajPracownikaCommand, new DodajPracownikaViewModel());
            }
        }

        private BaseCommand _CreateListaPracownikowCommand;
        public ICommand CreateListaPracownikowCommand
        {
            get
            {
                return getCommand(_CreateListaPracownikowCommand, new ListaPracownikowViewModel());
            }
        }

        private BaseCommand _CreateZaplanujUrlopCommand;
        public ICommand CreateZaplanujUrlopCommand
        {
            get
            {
                return getCommand(_CreateZaplanujUrlopCommand, new ZaplanujUrlopViewModel());
            }
        }

        private BaseCommand _CreateUrlopyCommand;
        public ICommand CreateUrlopyCommand
        {
            get
            {
                return getCommand(_CreateUrlopyCommand, new UrlopyViewModel());
            }
        }

        private BaseCommand _CreateListaDokumentowCommand;
        public ICommand CreateListaDokumentowCommand
        {
            get
            {
                return getCommand(_CreateListaDokumentowCommand, new ListaDokumentowViewModel());
            }
        }

        private BaseCommand _CreateAktualizacjaCommand;
        public ICommand CreateAktualizacjaCommand
        {
            get
            {
                return getCommand(_CreateAktualizacjaCommand, new AktualizacjaViewModel());
            }
        }

        private BaseCommand _EtapReklamacjiCommand;
        public ICommand EtapReklamacjiCommand
        {
            get
            {
                return getCommand(_CreateAktualizacjaCommand, new EtapReklamacjiViewModel());
            }
        }

        private BaseCommand _ShowEtapReklamacjiCommand;
        public ICommand ShowEtapReklamacjiCommand
        {
            get
            {
                if (_ShowEtapReklamacjiCommand == null)
                    _ShowEtapReklamacjiCommand = new BaseCommand(() => ShowAllEtapReklamacji());
                return _ShowEtapReklamacjiCommand;
            }
        }

        private BaseCommand _ShowAktualizacjaCommand;
        public ICommand ShowAktualizacjaCommand
        {
            get
            {
                if (_ShowAktualizacjaCommand == null)
                    _ShowAktualizacjaCommand = new BaseCommand(() => ShowAllAktualizacja());
                return _ShowAktualizacjaCommand;
            }
        }


        private BaseCommand _ShowListaDokumentowCommand;
        public ICommand ShowListaDokumentowCommand
        {
            get
            {
                if (_ShowListaDokumentowCommand == null)
                    _ShowListaDokumentowCommand = new BaseCommand(() => ShowAllListaDokumentow());
                return _ShowListaDokumentowCommand;
            }
        }

        private BaseCommand _ShowUrlopyCommand;
        public ICommand ShowUrlopyCommand
        {
            get
            {
                if (_ShowUrlopyCommand == null)
                    _ShowUrlopyCommand = new BaseCommand(() => ShowAllUrlopy());
                return _ShowUrlopyCommand;
            }
        }

        private BaseCommand _ShowZaplanujUrlopCommand;
        public ICommand ShowZaplanujUrlopCommand
        {
            get
            {
                if (_ShowZaplanujUrlopCommand == null)
                    _ShowZaplanujUrlopCommand = new BaseCommand(() => ShowAllZaplanujUrlop());
                return _ShowZaplanujUrlopCommand;
            }
        }

        private BaseCommand _ShowDodajReklamacjeCommand;
        public ICommand ShowDodajReklamacjeCommand
        {
            get
            {
                if (_ShowDodajReklamacjeCommand == null)
                    _ShowDodajReklamacjeCommand = new BaseCommand(() => ShowAllDodajReklamacje());
                return _ShowDodajReklamacjeCommand;
            }
        }

        private BaseCommand _ShowDodajPracownikaCommand;
        public ICommand ShowDodajPracownikaCommand
        {
            get
            {
                if (_ShowDodajPracownikaCommand == null)
                    _ShowDodajPracownikaCommand = new BaseCommand(() => ShowAllDodajPracownika());
                return _ShowDodajPracownikaCommand;
            }
        }

        private BaseCommand _ShowListaPracownikowCommand;
        public ICommand ShowListaPracownikowCommand
        {
            get
            {
                if (_ShowListaPracownikowCommand == null)
                    _ShowListaPracownikowCommand = new BaseCommand(() => ShowAllListaPracownikow());
                return _ShowListaPracownikowCommand;
            }
        }

        private BaseCommand _ShowListaKontrahentowCommand;
        public ICommand ShowListaKontrahentowCommand
        {
            get
            {
                if (_ShowListaKontrahentowCommand == null)
                    _ShowListaKontrahentowCommand = new BaseCommand(() => ShowAllListaKontrahentow(false));
                return _ShowListaKontrahentowCommand;
            }
        }

        private BaseCommand _ShowRaportSprzedazyCommand;
        public ICommand ShowRaportSprzedazyCommand
        {
            get
            {
                if (_ShowRaportSprzedazyCommand == null)
                    _ShowRaportSprzedazyCommand = new BaseCommand(() => ShowAllRaportSprzedazy());
                return _ShowRaportSprzedazyCommand;
            }
        }


        private BaseCommand _ShowOProgramieCommand;
        public ICommand ShowOProgramieCommand
        {
            get
            {
                if (_ShowOProgramieCommand == null)
                    _ShowOProgramieCommand = new BaseCommand(() => ShowAllOProgramie());
                return _ShowOProgramieCommand;
            }
        }

        private BaseCommand _ShowNowyParagonCommand;
        public ICommand ShowNowyParagonCommand
        {
            get
            {
                if (_ShowNowyParagonCommand == null)
                    _ShowNowyParagonCommand = new BaseCommand(() => ShowAllNowyParagon());
                return _ShowNowyParagonCommand;
            }
        }

        private BaseCommand _ShowNowaProFormaCommand;
        public ICommand ShowNowaProFormaCommand
        {
            get
            {
                if (_ShowNowaProFormaCommand == null)
                    _ShowNowaProFormaCommand = new BaseCommand(() => ShowAllNowaProForma());
                return _ShowNowaProFormaCommand;
            }
        }

        private BaseCommand _ShowNowaKontrahentCommand;
        public ICommand ShowNowaKontrahentCommand
        {
            get
            {
                if (_ShowNowaKontrahentCommand == null)
                    _ShowNowaKontrahentCommand = new BaseCommand(() => ShowAllNowaKontrahent());
                return _ShowNowaKontrahentCommand;
            }
        }


        private BaseCommand _ShowNowyTowarCommand;
        public ICommand ShowNowyTowarCommand
        {
            get
            {
                if (_ShowNowyTowarCommand == null)
                    _ShowNowyTowarCommand = new BaseCommand(() => ShowAllNowyTowar());
                return _ShowNowyTowarCommand;
            }
        }

        private BaseCommand _ShowNowaFakturaCommand;
        public ICommand ShowNowaFakturaCommand
        {
            get
            {
                if (_ShowNowaFakturaCommand == null)
                    _ShowNowaFakturaCommand = new BaseCommand(() => ShowAllNowaFaktura());
                return _ShowNowaFakturaCommand;
            }
        }


        private BaseCommand _ShowListaTowarowCommand;
        public ICommand ShowListaTowarowCommand
        {
            get
            {
                if (_ShowListaTowarowCommand == null)
                    _ShowListaTowarowCommand = new BaseCommand(() => ShowAllListaTowarow(false));
                return _ShowListaTowarowCommand;
            }
        }



        private BaseCommand _ShowUzytkownicyCommand;
        public ICommand ShowUzytkownicyCommand
        {
            get
            {
                if (_ShowUzytkownicyCommand == null)
                    _ShowUzytkownicyCommand = new BaseCommand(() => ShowAllUzytkownicy());
                return _ShowUzytkownicyCommand;
            }
        }

        private BaseCommand _ShowKoniecPracyCommand;
        public ICommand ShowKoniecPracyCommand
        {
            get
            {
                if (_ShowKoniecPracyCommand == null)
                    _ShowKoniecPracyCommand = new BaseCommand(() => ShowAllKoniecPracy());
                return _ShowKoniecPracyCommand;
            }
        }
        #endregion

        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }

        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
            {
                new CommandViewModel("Dodaj towar",new BaseCommand(()=>this.Create(new NowyTowarViewModel()))), 
                new CommandViewModel("Faktura",new BaseCommand(()=>this.Create(new NowaFakturaViewModel()))),
                new CommandViewModel("O programie",new BaseCommand(()=>this.Create(new OProgramieViewModel()))),
                new CommandViewModel("O programie",new BaseCommand(()=>this.ShowAllOProgramie())),
                new CommandViewModel("Dodaj paragon",new BaseCommand(()=>this.Create(new NowyParagonViewModel()))),
                new CommandViewModel("paragon",new BaseCommand(()=>this.ShowAllNowyParagon())),
                new CommandViewModel("Dodaj fakture pro-forma",new BaseCommand(()=>this.Create(new NowaFakturaProFormaViewModel()))),
                new CommandViewModel("Pro forma",new BaseCommand(()=>this.ShowAllNowaProForma())),
                new CommandViewModel("Dodaj kontrahenta",new BaseCommand(()=>this.Create(new NowyKontrahentViewModel()))),
                new CommandViewModel("Kontrahent",new BaseCommand(()=>this.ShowAllNowaKontrahent())),
                new CommandViewModel("Lista towarów",new BaseCommand(()=>this.Create(new ListaTowarowViewModel(false)))),
                new CommandViewModel("Wszystkie Towary",new BaseCommand(()=>this.ShowAllListaTowarow(false))),
                new CommandViewModel("Uzytkownicy",new BaseCommand(()=>this.Create(new UzytkownicyViewModel()))),
                new CommandViewModel("Wszyscy uzytkownicy",new BaseCommand(()=>this.ShowAllUzytkownicy())),
                new CommandViewModel("Koniec pracy",new BaseCommand(()=>this.Create(new KoniecPracyViewModel()))),
                new CommandViewModel("Koniec",new BaseCommand(()=>this.ShowAllKoniecPracy())),
                new CommandViewModel("Lista kontrahentów",new BaseCommand(()=>this.Create(new ListaKontrahentowViewModel(false)))),
                new CommandViewModel("Kontrahenci",new BaseCommand(()=>this.ShowAllListaKontrahentow(false))),
                new CommandViewModel("Dodaj reklamacje",new BaseCommand(()=>this.Create(new DodajReklamacjeViewModel()))),
                new CommandViewModel("Reklamacje",new BaseCommand(()=>this.ShowAllDodajReklamacje())),
                new CommandViewModel("Dodaj pracownika",new BaseCommand(()=>this.Create(new DodajPracownikaViewModel()))),
                new CommandViewModel("Pracownicy",new BaseCommand(()=>this.ShowAllDodajPracownika())),
                new CommandViewModel("Lista pracowników",new BaseCommand(()=>this.Create(new ListaPracownikowViewModel()))),
                new CommandViewModel("Pracownicy",new BaseCommand(()=>this.ShowAllListaPracownikow())),
                new CommandViewModel("Zaplanuj urlop",new BaseCommand(()=>this.Create(new ZaplanujUrlopViewModel()))),
                new CommandViewModel("Zaplanuj",new BaseCommand(()=>this.ShowAllZaplanujUrlop())),
                new CommandViewModel("Urlopy",new BaseCommand(()=>this.Create(new UrlopyViewModel()))),
                new CommandViewModel("Urlopy",new BaseCommand(()=>this.ShowAllUrlopy())),
                new CommandViewModel("Lista dokumentów",new BaseCommand(()=>this.Create(new ListaDokumentowViewModel()))),
                new CommandViewModel("Lista",new BaseCommand(()=>this.ShowAllListaDokumentow())),
                new CommandViewModel("Raport sprzedaży",new BaseCommand(()=>this.Create(new RaportSprzedazyViewModel()))),
                new CommandViewModel("sprzedaży",new BaseCommand(()=>this.ShowAllRaportSprzedazy())),
                new CommandViewModel("Aktualizacja",new BaseCommand(()=>this.Create(new AktualizacjaViewModel()))),
                new CommandViewModel("Aktualizacje",new BaseCommand(()=>this.ShowAllAktualizacja())),
                new CommandViewModel("Etap reklamacji",new BaseCommand(()=>this.Create(new EtapReklamacjiViewModel()))),
                new CommandViewModel("Etap",new BaseCommand(()=>this.ShowAllEtapReklamacji())),

            };
        }
        #endregion
        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            this.Workspaces.Remove(workspace);
        }
        #endregion
        #region PrivateHelpers
        private void Create(WorkspaceViewModel workspace)
        {
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }
        private void ShowAllEtapReklamacji()
        {
            EtapReklamacjiViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is EtapReklamacjiViewModel) as EtapReklamacjiViewModel;
            if (workspace == null)
            {
                workspace = new EtapReklamacjiViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllAktualizacja()
        {
            AktualizacjaViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is AktualizacjaViewModel) as AktualizacjaViewModel;
            if (workspace == null)
            {
                workspace = new AktualizacjaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }


        private void ShowAllListaDokumentow()
        {
            ListaDokumentowViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is ListaDokumentowViewModel) as ListaDokumentowViewModel;
            if (workspace == null)
            {
                workspace = new ListaDokumentowViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllUrlopy()
        {
            UrlopyViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is UrlopyViewModel) as UrlopyViewModel;
            if (workspace == null)
            {
                workspace = new UrlopyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllZaplanujUrlop()
        {
            ZaplanujUrlopViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is ZaplanujUrlopViewModel) as ZaplanujUrlopViewModel;
            if (workspace == null)
            {
                workspace = new ZaplanujUrlopViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }


        private void ShowAllListaKontrahentow(bool czyZamknac)
        {
            ListaKontrahentowViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is ListaKontrahentowViewModel) as ListaKontrahentowViewModel;
            if (workspace == null)
            {
                workspace = new ListaKontrahentowViewModel(czyZamknac);
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }


        private void ShowAllListaTowarow(bool czyZamknac)
        {
            ListaTowarowViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is ListaTowarowViewModel) as ListaTowarowViewModel;
            if (workspace == null)
            {
                workspace = new ListaTowarowViewModel(czyZamknac);
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllRaportSprzedazy()
        {
            RaportSprzedazyViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is RaportSprzedazyViewModel) as RaportSprzedazyViewModel;
            if (workspace == null)
            {
                workspace = new RaportSprzedazyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllOProgramie()
        {
            OProgramieViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is OProgramieViewModel) as OProgramieViewModel;
            if (workspace == null)
            {
                workspace = new OProgramieViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }


        private void ShowAllNowaFaktura()
        {
            NowaFakturaViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is NowaFakturaViewModel) as NowaFakturaViewModel;
            if (workspace == null)
            {
                workspace = new NowaFakturaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllUzytkownicy()
        {
            UzytkownicyViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is UzytkownicyViewModel) as UzytkownicyViewModel;
            if (workspace == null)
            {
                workspace = new UzytkownicyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllKoniecPracy()
        {
            KoniecPracyViewModel workspace =
                 this.Workspaces.FirstOrDefault(vm => vm is KoniecPracyViewModel) as KoniecPracyViewModel;
            if (workspace == null)
            {
                workspace = new KoniecPracyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
        private void ShowAllNowyParagon()
        {
            NowyParagonViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is NowyParagonViewModel) as NowyParagonViewModel;
            if (workspace == null)
            {
                workspace = new NowyParagonViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllNowaProForma()
        {
            NowaFakturaProFormaViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is NowaFakturaProFormaViewModel) as NowaFakturaProFormaViewModel;
            if (workspace == null)
            {
                workspace = new NowaFakturaProFormaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllNowaKontrahent()
        {
            NowyKontrahentViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is NowyKontrahentViewModel) as NowyKontrahentViewModel;
            if (workspace == null)
            {
                workspace = new NowyKontrahentViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllNowyTowar()
        {
            NowyTowarViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is NowyTowarViewModel) as NowyTowarViewModel;
            if (workspace == null)
            {
                workspace = new NowyTowarViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllDodajReklamacje()
        {
            DodajReklamacjeViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is DodajReklamacjeViewModel) as DodajReklamacjeViewModel;
            if (workspace == null)
            {
                workspace = new DodajReklamacjeViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllDodajPracownika()
        {
            DodajPracownikaViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is DodajPracownikaViewModel) as DodajPracownikaViewModel;
            if (workspace == null)
            {
                workspace = new DodajPracownikaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }

        private void ShowAllListaPracownikow()
        {
            ListaPracownikowViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is ListaPracownikowViewModel) as ListaPracownikowViewModel;
            if (workspace == null)
            {
                workspace = new ListaPracownikowViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }
        #endregion
    }
}