using Firma.ViewModel;
using System.Windows;

namespace Firma.View
{
    public partial class LogowanieView : Window
    {
        public LogowanieView()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogowanieViewModel viewModel = new LogowanieViewModel();
            bool czyPoprawneLogowanie = viewModel.Logowanie(Uzytkownik.Text, Haslo.Password);
            if (czyPoprawneLogowanie == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.DataContext = new MainWindowViewModel();
                App.Current.Windows[0].Close();
                mainWindow.Show();
            }
        }
    }
}





