using RoomReservationClientWPF.RoomReservationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.ServiceModel;
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

namespace RoomReservationClientWPF
{
    public class SearchDetail
    { 
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public List<RoomReservation> RoomReservationList { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RoomReservation _room = null;
        private SearchDetail _searchDate = null;
        private List<RoomReservation> _listRoomReservation = null;
        
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
                buttonReserveRoom.IsEnabled = false;
            }
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            DateTime startDate = _searchDate.StartDate;
            DateTime endDate = _searchDate.EndDate;
            _searchDate.RoomReservationList = GetRoomReservationColl(startDate,endDate);
            gridSearch.DataContext = null;
            gridSearch.DataContext = _searchDate;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _room = new RoomReservation()
            {
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date
            };
            itemGrid.DataContext = _room;
            SetReservationID();
            SetSearchDetail();
        }

        private bool AddRoomReservation()
        {
            SetReservationID();

            using (var client = new RoomServiceClient())
            {
                //int Id = 0;
                //int.TryParse(textBoxID.Text, out Id);
                //DateTime startDate = DateTime.MinValue;
                //DateTime.TryParse(datePickerStartDate.Text, out startDate);
                //DateTime endDate = DateTime.MinValue;
                //DateTime.TryParse(datePickerEndDate.Text, out endDate);

                //RoomReservation room = new RoomReservation
                //{
                //    Id = Id,
                //    Contact = textBoxContact.Text,
                //    Event = textBoxEvent.Text,
                //    StartDate = startDate,
                //    EndDate = endDate,
                //    RoomName = textBoxRoomName.Text
                //};
                return client.ReserveRoom(_room);
            }
        }

        private void SetReservationID()
        {
            using (var client = new RoomServiceClient())
            {

                RoomReservation[] reservations = client.GetRoomReservations(DateTime.MinValue, DateTime.MaxValue);
                if (reservations != null)
                    _room.Id = reservations.Max(item => item.Id) + 1;
                else
                    _room.Id = 1;

                //textBoxID.Text = Id.ToString();
            }
        }

        private void SetSearchDetail() {

            DateTime startDate = System.DateTime.Now.Date.AddMonths(-1).Date;
            DateTime endDate = System.DateTime.Now.Date.AddMonths(1).Date;
            _searchDate = new SearchDetail
            {
                StartDate = startDate.Date,
                EndDate = endDate,
                RoomReservationList = GetRoomReservationColl(startDate, endDate)
            };

            gridSearch.DataContext = _searchDate;
        }

        private void ResetFields()
        {
            buttonReserveRoom.IsEnabled = true;
            _room = new RoomReservation()
            {
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date
            };
            SetReservationID();
        }

        private List<RoomReservation> GetRoomReservationColl(DateTime startDate, DateTime endDate)
        {
            List<RoomReservation> roomReservationColl = new List<RoomReservation>();

            using(var client = new RoomServiceClient())
            {
                roomReservationColl = client.GetRoomReservations(startDate, endDate).ToList<RoomReservation>();
            }

            return roomReservationColl;
        }

    }
}
