﻿using System;
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
    public partial class ModelBindingSampleWindow : INotifyPropertyChanged
    {
        public string Department { get; set; }
        private string _yourName;
        public string YourName
        {
            get
            {
                return _yourName;
            }
            set
            {
                _yourName = value;
                OnPropertyChanged("YourName");
            }
        }
        public ModelBindingSampleWindow()
        {
            Department = "Yo ass Department";
            YourName = "Yo ass name";
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        private void ReadPropertyHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Department: {Department}; YourName: {YourName}");
        }

        private void ResetPropertyHandler(object sender, RoutedEventArgs e)
        {
            YourName = "It's changed yo";
        }
    }
}
