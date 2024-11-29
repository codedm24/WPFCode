using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppConceptCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
       

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = this;
            DataContext = new MainViewModel();
            MainFrame.Navigate(new Page1());

            int renderCapabilityTier = RenderCapability.Tier;
            labelGpu.Content ="GPU tier: "+ renderCapabilityTier;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            (sender as Button).Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            (sender as Button).Background = new SolidColorBrush(Colors.Violet);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Window loaded");
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Window Activated");
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Debug.WriteLine("Window Deactivated");
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Window unloaded");
        }

        private void btnSampleDialog_Click(object sender, RoutedEventArgs e)
        {
            WindowSampleDialog windSampleDialog = new WindowSampleDialog();
            Application.Current.MainWindow = windSampleDialog;
            Application.Current.MainWindow.Show();
            this.Close();
        }
    }
}
