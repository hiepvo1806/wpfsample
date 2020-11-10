using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Models;

namespace WpfApp1.ModelBindingSample
{
    /// <summary>
    /// Interaction logic for GridBindingExampleWindow.xaml
    /// </summary>
    public partial class GridBindingExampleWindow : Window
    {

        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Employees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(GridBindingExampleWindow), new PropertyMetadata(new ObservableCollection<Employee>()));

        public GridBindingExampleWindow()
        {
            InitializeComponent();
            Employees = new ObservableCollection<Employee>
            {
                new Employee
                {
                    Department = "W",
                    FirstName = "A",
                    Id = "I",
                    LastName = "L"
                },
                new Employee
                {
                    Department = "HR Department",
                    FirstName = "A2",
                    Id = "I2",
                    LastName = "L2"
                }, 
                new Employee
                {
                    Department = "Finance Department",
                    FirstName = "A3",
                    Id = "I3",
                    LastName = "L3"
                },
                new Employee
                {
                    Department = "HR Department",
                    FirstName = "A2",
                    Id = "I2",
                    LastName = "L2"
                },
                new Employee
                {
                    Department = "IT Department",
                    FirstName = "A3",
                    Id = "I3",
                    LastName = "L3"
                },
                new Employee
                {
                    Department = "HR Department",
                    FirstName = "A2",
                    Id = "I2",
                    LastName = "L2"
                },
                new Employee
                {
                    Department = "IT Department",
                    FirstName = "A3",
                    Id = "I3",
                    LastName = "L3"
                },
                new Employee
                {
                    Department = "HR Department",
                    FirstName = "A2",
                    Id = "I2",
                    LastName = "L2"
                },
                new Employee
                {
                    Department = "Finance Department",
                    FirstName = "A3",
                    Id = "I3",
                    LastName = "L3"
                }
            };
            dataGrid.ItemsSource = Employees;
        }

        private void OnSortClicked(object sender, RoutedEventArgs e)
        {
            var cvs = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            if (cvs!=null && cvs.CanSort)
            {
                cvs.SortDescriptions.Clear();
                cvs.SortDescriptions.Add(new SortDescription("Department", ListSortDirection.Descending));
            }
        }

        private void OnGroupClicked(object sender, RoutedEventArgs e)
        {
            var cvs = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            if (cvs != null && cvs.CanGroup)
            {
                cvs.GroupDescriptions.Clear();
                cvs.GroupDescriptions.Add(new PropertyGroupDescription("Department"));
            }
        }

        private void OnFilterTextChanged(object sender, TextChangedEventArgs e)
        {
            var cvs = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            if (cvs != null && cvs.CanFilter)
            {
                cvs.Filter = OnFilteredApplied;
            }
        }

        private bool OnFilteredApplied(object obj)
        {
            if (obj is Employee emp)
            {
                var searchText = filterBox.Text.ToLower();
                return emp.FirstName.ToLower().Contains(searchText) || emp.Department.ToLower().Contains(searchText) || emp.LastName.ToLower().Contains(searchText);
            }
            return false;
        }
    }
}
