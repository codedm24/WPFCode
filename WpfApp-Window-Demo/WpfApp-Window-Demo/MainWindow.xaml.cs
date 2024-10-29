using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Window_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isDirtty = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void documentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _isDirtty = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_isDirtty)
            {
                var result = MessageBox.Show("Document has changed. Close without saving?","Question", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void OpenCustomBorderWindow_Click(object sender, RoutedEventArgs e)
        {
            CustomBorderWindow customBorderWindow = new CustomBorderWindow();
            customBorderWindow.Show();
        }
    }
}