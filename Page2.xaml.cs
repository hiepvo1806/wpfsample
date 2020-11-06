using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void OnPreviousClick(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }
    }
}
