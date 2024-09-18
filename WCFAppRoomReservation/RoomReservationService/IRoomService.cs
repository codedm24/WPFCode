using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RoomReservationData;

namespace WCF.App.RoomReservation.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRoomService
    {
        [OperationContract]
        bool ReserveRoom(RoomReservationData.RoomReservation roomReservation);

        [OperationContract]
        RoomReservationData.RoomReservation[] GetRoomReservations(DateTime fromDate, DateTime toDate);

        // TODO: Add your service operations here
    }
}
