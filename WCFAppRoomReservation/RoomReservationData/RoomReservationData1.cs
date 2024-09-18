using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationData
{
    internal class RoomReservationData1
    {
        public void ReserveRoom(RoomReservation roomReservation)
        {
            using (var data = new RoomReservationsEntities1())
            {
                data.RoomReservations.Add(roomReservation);
            }
        }

        public RoomReservation[] GetReservations(DateTime fromDate, DateTime toDate) {
            using (var data = new RoomReservationsEntities1()) {
                return (from r in data.RoomReservations
                        where r.StartDate > fromDate && r.EndDate < toDate
                        select r).ToArray();
            }
        }
    }
}
