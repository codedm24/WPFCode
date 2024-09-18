using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationData
{
    public class RoomReservationData
    {
        public void ReserveRoom(RoomReservation roomReservation) {
            using (var data = new RoomReservationModel()) {
                data.RoomReservations.Add(roomReservation);
                data.SaveChanges();
            }
        }

        public RoomReservation[] GetReservations(DateTime fromDate, DateTime toDate)
        {
            using (var data = new RoomReservationModel()) {
                return (from r in data.RoomReservations
                        where r.StartDate > fromDate && r.EndDate < toDate
                        select r).ToArray();
            }
        }
    }
}
