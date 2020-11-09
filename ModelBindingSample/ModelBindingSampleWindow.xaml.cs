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
using System.Windows.Shapes;

namespace WpfHVApp.Window
{
    /// <summary>
    /// Interaction logic for ModelBindingSampleWindow.xaml
    /// </summary>
    public partial class ModelBindingSampleWindow
    {
        public string Department { get; set; }
        public string YourName { get; set; }
        public ModelBindingSampleWindow()
        {
            Department = "Yo ass Department";
            YourName = "Yo ass name";
            InitializeComponent();
        }
    }
}
