using Firma.View;
using Firma.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Firma
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            LogowanieView window = new LogowanieView();
            window.DataContext = new LogowanieViewModel();
            window.Show();
        }
    }
}
