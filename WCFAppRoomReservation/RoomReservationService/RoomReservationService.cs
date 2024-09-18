using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.App.RoomReservation.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RoomReservationService : IRoomService
    {
        public RoomReservationData.RoomReservation[] GetRoomReservations(DateTime fromDate, DateTime toDate)
        {
            var data = new RoomReservationData.RoomReservationData();
            return data.GetReservations(fromDate, toDate);
        }

        public bool ReserveRoom(RoomReservationData.RoomReservation roomReservation)
        {
            var data = new RoomReservationData.RoomReservationData();
            data.ReserveRoom(roomReservation);
            return true;
        }
    }
}
