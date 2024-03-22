using System.Windows;
using System.Windows.Controls;

namespace Firma.View
{
    public partial class OProgramieView : UserControl
    {
        public OProgramieView()
        {
            InitializeComponent(); 
            licencjaButton.Click += licencjaButton_Click; 
        }
        private void licencjaButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Numer licencji: ABC123-XYZ456-789DEF", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                var tabItem = this.Parent as TabItem;
                if (tabItem != null)
                {        
                    var tabControl = tabItem.Parent as TabControl;
                    if (tabControl != null)
                    {
                        tabControl.Items.Remove(tabItem);
                    }
                }
            }
        }
    }
}
