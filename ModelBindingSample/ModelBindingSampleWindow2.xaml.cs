using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfHVApp.Window
{
    /// <summary>
    /// Interaction logic for ModelBindingSampleWindow.xaml
    /// </summary>
    public partial class ModelBindingSampleWindow2 
    {
        public string Department { get; set; }
        //Propdp
        public string YourName
        {
            get { return (string)GetValue(YourNameProperty); }
            set { SetValue(YourNameProperty, (string)value); }
        }

        // Using a DependencyProperty as the backing store for YourName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YourNameProperty =
            DependencyProperty.Register("YourName", typeof(string), typeof(ModelBindingSampleWindow2), new PropertyMetadata(string.Empty));
        public ModelBindingSampleWindow2()
        {
            Department = "Yo ass Department";
            YourName ="Yo Initial ass name";
            InitializeComponent();
        }

        private void OnReadPropertyBtnClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Department: {Department}; YourName: {YourName}");
        }

        private void OnResetBtnClicked(object sender, RoutedEventArgs e)
        {
            YourName = "It's changed yo";
        }
    }
}
