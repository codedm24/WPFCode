using System.ServiceProcess;
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

namespace WPFSampleQuoteServerController
{
    public enum ButtonState
    {
        Start,
        Stop,
        Pause,
        Continue
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RefreshServiceList();
        }

        private void RefreshServiceList()
        {
            List<ServiceControllerInfo> controllerInfoColl = new List<ServiceControllerInfo>();

            ServiceController.GetServices().OrderBy(item => item.ServiceName).ToList().ForEach(service =>
            {
                ServiceController controller = new ServiceController(service.ServiceName);
                controllerInfoColl.Add(new ServiceControllerInfo(controller));
            });

            this.DataContext = ServiceController.GetServices().OrderBy(sc => sc.DisplayName).Select(sc => new ServiceControllerInfo(sc));
        }

        private void OnServiceCommand(object sender, RoutedEventArgs e)
        {
            Cursor oldCursor = this.Cursor;
            try
            {
                this.Cursor = Cursors.Wait;
                ButtonState currentButtonState = (ButtonState)(sender as Button).Tag;

                var selectedService = listBoxServices.SelectedItem as ServiceControllerInfo;

                switch (currentButtonState)
                {
                    case ButtonState.Start:
                        selectedService?.Controller.Start();
                        selectedService?.Controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                        break;
                    case ButtonState.Stop:
                        selectedService?.Controller.Stop();
                        selectedService?.Controller.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                        break;
                    case ButtonState.Pause:
                        selectedService?.Controller.Pause();
                        selectedService?.Controller.WaitForStatus(ServiceControllerStatus.Paused, TimeSpan.FromSeconds(10));
                        break;
                    case ButtonState.Continue:
                        selectedService?.Controller.Continue();
                        selectedService?.Controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                        break;
                }

                int index = listBoxServices.SelectedIndex;
                RefreshServiceList();
                listBoxServices.SelectedIndex = index;
            }
            catch (System.ServiceProcess.TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Timeout Service Controller", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.Message} {(ex.InnerException != null ? ex.InnerException.Message : string.Empty)}", "Invalid Operation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                this.Cursor = oldCursor;
            }
        }

        private void OnRefresh(object sender, RoutedEventArgs e)
        {
            RefreshServiceList();
        }

        private void OnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}