using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SeventhPage : Page
    {
        public SeventhPage()
        {
            this.InitializeComponent();
        }

        public Book Book { get; } = new Book { 
            Title = "Professional C# 6",
            Publisher = "Wrox Press"
        };

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            Book.Title = "Professional C# 6 and .NET Core 5";
        }

        private void OnStopTracking(object sender, RoutedEventArgs e)
        {
            Bindings.StopTracking();
        }
        
        private void OnUpdateBinding(object sender, RoutedEventArgs e)
        {
            Bindings.Update();
        }

        private void buttonNavNext_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EighthPage));
        }
    }

    public class Book : BindableBase
    { 
        public int BookId {  get; set; }
        private string _title;
    
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Publisher {  get; set; }

        public override string ToString() => Title;
    }
}
