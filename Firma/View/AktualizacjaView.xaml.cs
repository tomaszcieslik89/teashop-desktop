using System;
using System.Windows;
using System.Windows.Controls;

namespace Firma.View
{
    public partial class AktualizacjaView : UserControl
    {
        public AktualizacjaView()
        {
            InitializeComponent(); 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            bool isUpdated = random.Next(2) == 0; 
            string message = isUpdated ? "Program jest zaktualizowany." : "Dostępna jest nowa aktualizacja na stronie www.TeaShop.com.pl w zakładce 'Pobierz'.";
            MessageBox.Show(message, "Stan aktualizacji", MessageBoxButton.OK, isUpdated ? MessageBoxImage.Information : MessageBoxImage.Warning);
        }
    }
}
