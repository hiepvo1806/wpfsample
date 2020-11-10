using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfHVApp.Window
{
    public class TextBoxExtensions
    {
        public static bool GetSelectOnFocus(DependencyObject obj)
        {
            return (bool)obj.GetValue(SelectOnFocusProperty);
        }

        public static void SetSelectOnFocus(DependencyObject obj, bool value)
        {
            obj.SetValue(SelectOnFocusProperty, value);
        }

        // Using a DependencyProperty as the backing store for SelectOnFocus.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectOnFocusProperty =
            DependencyProperty.RegisterAttached("SelectOnFocus", typeof(bool), typeof(TextBoxExtensions), new PropertyMetadata(false, SelectOnFocus));

        private static void SelectOnFocus(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                textBox.GotFocus += (s, arg) =>
                 {
                     textBox.Clear();
                 };
            }
        }
    }
}
