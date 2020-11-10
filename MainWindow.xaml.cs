using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ModelBindingSample;
using WpfHVApp.Window;

namespace WpfHVApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSecondWindowButtonClicked(object sender, RoutedEventArgs e)
        {
            var window = new SecondWindow();
            window.Show();
        }

        private void OnModelBindingSampleClicked(object sender, RoutedEventArgs e)
        {
            var window = new ModelBindingSampleWindow();
            window.Show();
        }

        private void OnModelBindingSample2Clicked(object sender, RoutedEventArgs e)
        {
            var window = new ModelBindingSampleWindow2();
            window.Show();
        }

        private void OnGridBindingClicked(object sender, RoutedEventArgs e)
        {
            var window = new GridBindingExampleWindow();
            window.Show();
        }
    }
}
