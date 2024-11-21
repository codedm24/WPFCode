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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {
            textBlockChangeColor.Background = checkbox1.IsChecked.Value ? Brushes.LightCoral : Brushes.LightGreen;
        }
    }
}
