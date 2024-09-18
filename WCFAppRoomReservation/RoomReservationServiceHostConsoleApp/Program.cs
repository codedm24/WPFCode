using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCF.App.RoomReservation.Service;

namespace RoomReservationServiceHostConsoleApp
{
    internal class Program
    {
        internal static ServiceHost myServiceHost = null;

        internal static void StartService()
        {
            myServiceHost = new ServiceHost(typeof(RoomReservationService));
            //ContractDescription description = new ContractDescription("WCF.App.RoomReservation.Service.IRoomService");
            //EndpointAddress address = new EndpointAddress(new Uri("https://localhost:8733/RoomReservationService/"));
            //ServiceEndpoint endPoint = new ServiceEndpoint(description, new WSHttpBinding(), address);
            //myServiceHost.Description.Endpoints.Add(endPoint);
            myServiceHost.Open();
        }

        internal static void StopService()
        {
            if (myServiceHost != null && myServiceHost.State != CommunicationState.Closed)
            {
                myServiceHost.Close();
            }
        }

        static void Main(string[] args)
        {
            StartService();
            
            Console.WriteLine("Service is running. Press return to exit.");
            Console.ReadLine();

            StopService();
        }
    }
}
