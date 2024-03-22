using System.Windows;
using System.Windows.Controls;

namespace Firma.View
{
    public class WszystkieViewBaseZDedykowanymFiltrowaniem : UserControl
    {
        static WszystkieViewBaseZDedykowanymFiltrowaniem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WszystkieViewBaseZDedykowanymFiltrowaniem), new FrameworkPropertyMetadata(typeof(WszystkieViewBaseZDedykowanymFiltrowaniem)));
        }
    }
}
