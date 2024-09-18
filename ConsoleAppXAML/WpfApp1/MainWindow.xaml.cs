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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "clicked";
            MyDependencyObject object1 = (MyDependencyObject)this.FindResource("dep1");
            if(object1 != null)
            {
                object1.Value += 1;
            }

            MyAttachedPropertyProvider.SetMyProperty(buttonMouseMove, "sample value");

            //using VisualTreeHelper
            //foreach (var item in GetChildren(stackPanelButton, e => MyAttachedPropertyProvider.GetMyProperty(e) != string.Empty))
            //{
            //    list1.Items.Add($"{item.Name}: {MyAttachedPropertyProvider.GetMyProperty(item)}");
            //}

            //using LogicalTreeHelper
            foreach (var item in LogicalTreeHelper.GetChildren(stackPanelButton).OfType<FrameworkElement>().Where(e => MyAttachedPropertyProvider.GetMyProperty(e) != string.Empty))
            {
                list1.Items.Add($"{item.Name}: {MyAttachedPropertyProvider.GetMyProperty(item)}");
            }
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (CheckIgnoreGridMove.IsChecked == true && !IsButtonMouseMoveSource(e))
                return;
            ShowStatus(nameof(Grid_MouseMove), e);
            e.Handled = CheckStopBubbling.IsChecked == true;
        }

        private void Grid_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (CheckIgnoreGridMove.IsChecked == true && !IsButtonMouseMoveSource(e))
                return;
            ShowStatus(nameof(Grid_PreviewMouseMove), e);
            e.Handled = CheckStopPreview.IsChecked == true;
        }

        private void buttonCleanStatus_Click(object sender, RoutedEventArgs e)
        {
            textStatus.Text = string.Empty;
        }

        private void buttonMouseMove_MouseMove(object sender, MouseEventArgs e)
        {
            ShowStatus(nameof(buttonMouseMove_MouseMove), e);
            e.Handled = CheckStopBubbling.IsChecked == true;
        }

        private void buttonMouseMove_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            ShowStatus(nameof(buttonMouseMove_PreviewMouseMove), e);
            e.Handled = CheckStopPreview.IsChecked == true;
        }

        private bool IsButtonMouseMoveSource(RoutedEventArgs e) => (e.Source as FrameworkElement)?.Name == nameof(buttonMouseMove);

        private void ShowStatus(string status, RoutedEventArgs e)
        {
            textStatus.Text += $"{status} source: {e.Source.GetType().Name}, " +
                $" {(e.Source as FrameworkElement)?.Name} " +
                $" original source: {e.OriginalSource.GetType().Name}";
            textStatus.Text += "\r\n";
        }

        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private IEnumerable<FrameworkElement> GetChildren(FrameworkElement rootElement, Func<FrameworkElement, bool> pred)
        {
            int childrenCount = VisualTreeHelper.GetChildrenCount(rootElement);
            for(int  i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(rootElement, i) as FrameworkElement;
                if(child != null && pred(child))
                    yield return child;
            }
        }
    }
}