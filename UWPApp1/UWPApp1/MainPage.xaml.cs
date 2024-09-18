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

namespace UWPApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : BasePage
    {
       
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void OnNavigateToSecondPage()
        {
            Frame.Navigate(typeof(SecondPage));
        }

        private void OnNavigateToSecondPage(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SecondPage));
        }

        public static readonly DependencyProperty InfoProperty = DependencyProperty.Register("Info", typeof(string), typeof(MainPage),
           new PropertyMetadata(string.Empty));

        public string Info
        {
            get
            {
                return (string)GetValue(InfoProperty);
            }
            set
            {
                SetValue(InfoProperty, value);
            }
        }

        private void OnHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        {
            Info = e.Section.Tag as string;
        }
    }
}
