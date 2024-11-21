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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppConceptCheck
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void NavigateToPage1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void btnNavigate2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            byte r = byte.Parse(new Random().Next(100, 150).ToString());
            byte g = byte.Parse(new Random().Next(150, 200).ToString());
            byte b = byte.Parse(new Random().Next(200, 255).ToString());
            Color customColor = Color.FromRgb(r, g, b);
            
            Application.Current.Resources["DynamicBrush"] = new SolidColorBrush(customColor);

            //Application.Current.Resources["DynamicBrush"] = new SolidColorBrush(Colors.LightGreen);
            
        }

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Add("2. StackPanel Mouse Up");
        }

        private void Grid1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Add("3. Grid Mouse Up");
        }

        private void bubbleEvent_MouseUp(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Add("1. Label Mouse Up");
        }

        private void Grid1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Add("1. Grid Mouse Down Preview");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Add("2. StackPanel Mouse Down Preview");
        }

        private void bubbleEvent_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Add("3. Label Mouse Down Preview");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listView1.Items.Add("1. Window load event direct event handling");
        }

        private void bubbleEvent_Loaded(object sender, RoutedEventArgs e)
        {
            listView1.Items.Add("2. Label load event direct event handling");
        }
    }
}
