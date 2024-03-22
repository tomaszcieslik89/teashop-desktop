using System.Windows;
using System.Windows.Controls;

namespace Firma.View
{
    public class JedenViewBase : UserControl
    {
        static JedenViewBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(JedenViewBase), new FrameworkPropertyMetadata(typeof(JedenViewBase)));
        }
    }
}
