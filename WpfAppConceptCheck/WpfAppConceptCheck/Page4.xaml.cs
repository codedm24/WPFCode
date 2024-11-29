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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();

            List<Person> people = new List<Person> { 
                new Person { Name = "Alice", Age = 30, City = "New York" }, 
                new Person { Name = "Bob", Age = 25, City = "San Francisco" }, 
                new Person { Name = "Charlie", Age = 35, City = "Chicago" } 
            }; 
            PersonListBox.ItemsSource = people;
        }

        private void NavigateToPage1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }
    }


}
