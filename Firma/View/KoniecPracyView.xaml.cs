using System.Windows;
using System.Windows.Controls;

namespace Firma.View
{
    public partial class KoniecPracyView : UserControl
    {
        private bool CzyAPPzamykana = false; 
        public KoniecPracyView()
        {
            InitializeComponent();
        }
        private void TakButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CzyAPPzamykana)
            {
                var result = MessageBox.Show("Czy na pewno chcesz zakończyć pracę?", "Uwaga!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    CzyAPPzamykana = true; 
                    CloseCurrentWindow();
                }
            }
        }
        private void NieButton_Click(object sender, RoutedEventArgs e)
        {}
        private void CloseCurrentWindow()
        {
            var window = Window.GetWindow(this);
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
