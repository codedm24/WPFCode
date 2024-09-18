using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "clicked";
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ShowStatus(nameof(Grid_Tapped), e);
            e.Handled = CheckStopRouting.IsChecked == true;
        }

        private void button3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ShowStatus(nameof(button3_Tapped), e);
            e.Handled = CheckStopRouting.IsChecked == true;
        }

        private void ShowStatus(string status, RoutedEventArgs e)
        {
            textStatus.Text += $"{status} {e.OriginalSource.GetType().Name}";
            textStatus.Text += "\r\n";
        }

        private void buttonCleanStatus_Click(object sender, RoutedEventArgs e)
        {
            textStatus.Text = string.Empty;
        }

        private void buttonAttachedProperty_Click(object sender, RoutedEventArgs e)
        {
            MyAttachedPropertyProvider.SetMyProperty(buttonAttachedProperty1, "Sample Value");

            foreach (var item in GetChildren(stackPanelAttachedProperty, arg => MyAttachedPropertyProvider.GetMyProperty(arg) != string.Empty))
            {
                list1.Items.Add($"{item.Name}: {MyAttachedPropertyProvider.GetMyProperty(item)}");
            }
        }

        private IEnumerable<FrameworkElement> GetChildren(FrameworkElement element, Func<FrameworkElement, bool> predicate)
        {
            int childCount = VisualTreeHelper.GetChildrenCount(element);

            for (int i = 0; i < childCount; i++)
            {
                FrameworkElement child = VisualTreeHelper.GetChild(element, i) as FrameworkElement;
                if (child != null && !predicate(child))
                    yield return child;
            }
        }
    }
}
