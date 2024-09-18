using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    internal class MyAttachedPropertyProvider : DependencyObject
    {
        public string MySample
        {
            get {
                return (string)GetValue(MySampleProperty);
            }

            set { 
                SetValue(MySampleProperty, value);
            }
        }

        public static readonly DependencyProperty MySampleProperty = DependencyProperty.RegisterAttached("MySample", typeof(string),
            typeof(MyAttachedPropertyProvider), new PropertyMetadata(string.Empty));

        public static void SetMyProperty(UIElement element, string value) => element.SetValue(MySampleProperty, value);

        public static string GetMyProperty(UIElement element) => (string)element.GetValue(MySampleProperty);
    }
}
