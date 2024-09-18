using RoomReservationService;
using System.ServiceModel;
using System.ServiceModel.Channels;
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

namespace RoomReservationClientWPF
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

        private void buttonReserveRoom_Click(object sender, RoutedEventArgs e)
        {
            bool reserved = AddRoomReservation();
            if (reserved)
            {
                MessageBox.Show("Room reserved successfully", "Room Reservation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private bool AddRoomReservation()
        {
            WSHttpBinding wsBinding = new WSHttpBinding(SecurityMode.Transport);
            EndpointAddress endpointAddress = new EndpointAddress(new Uri("https://localhost:8733/RoomReservationService/"));
            using (var client = new RoomServiceClient(wsBinding, endpointAddress))
            {
                int Id = 0;
                int.TryParse(textBoxID.Text, out Id);
                DateTime startDate = DateTime.MinValue;
                DateTime.TryParse(datePickerStartDate.Text, out startDate);
                DateTime endDate = DateTime.MinValue;
                DateTime.TryParse(datePickerEndDate.Text, out endDate);

                RoomReservation room = new RoomReservation
                {
                    Id = Id,
                    Contact = textBoxContact.Text,
                    Event = textBoxEvent.Text,
                    StartDate = startDate,
                    EndDate = endDate
                };
                return client.ReserveRoom(room);
            }
        }
    }
}