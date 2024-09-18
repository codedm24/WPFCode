using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace UWPApp2
{
    internal class MyAttachedPropertyProvider : DependencyObject
    {
        public string MySample
        {
            get { return (string)GetValue(MySampleProperty); }
            set { SetValue(MySampleProperty, value); }
        }

        public static DependencyProperty MySampleProperty => DependencyProperty.RegisterAttached("MySample", typeof(string),
            typeof(MyAttachedPropertyProvider), new PropertyMetadata(String.Empty));

        public static void SetMyProperty(UIElement element, string value) => element.SetValue(MySampleProperty, value);

        public static string GetMyProperty(UIElement element) => (string)element.GetValue(MySampleProperty);
    }
}
