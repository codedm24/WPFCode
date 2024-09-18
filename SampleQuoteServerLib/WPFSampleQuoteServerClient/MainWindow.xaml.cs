using System.Net.Sockets;
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

namespace WPFSampleQuoteServerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuoteInformation _quoteInformation = new QuoteInformation();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _quoteInformation;
        }

        protected async void buttonGetQuote_Click(object sender, RoutedEventArgs e)
        {
            const int bufferSize = 1024;
            Cursor currentCursor = this.Cursor;
            this.Cursor = Cursors.Wait;
            _quoteInformation.EnableRequest = false;

            string serverName = Properties.Settings.Default.ServerName;
            int port = Properties.Settings.Default.PortNumber;

            var tcpClient = new TcpClient();
            NetworkStream? stream = null;

            try
            {
                await tcpClient.ConnectAsync(serverName, port);
                stream = tcpClient.GetStream();
                byte[] buffer = new byte[bufferSize];
                int received = await stream.ReadAsync(buffer, 0, bufferSize);
                if (received < 0)
                    return;
                _quoteInformation.Quote = Encoding.Unicode.GetString(buffer).Trim('\0');
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error Quote of the day", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            { 
                stream?.Close();
                if(tcpClient.Connected)
                    tcpClient.Close();
            }

            this.Cursor = currentCursor;
            _quoteInformation.EnableRequest = true;
        }
    }
}