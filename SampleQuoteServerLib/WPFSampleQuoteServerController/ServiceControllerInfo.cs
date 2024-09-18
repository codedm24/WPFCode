using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace WPFSampleQuoteServerController
{
    public class ServiceControllerInfo
    {

        public ServiceControllerInfo(ServiceController controller)
        {
            Controller = controller;
        }

        public ServiceController Controller { get; }

        public string DisplayName =>  Controller.DisplayName; 

        public string ServiceName => Controller.ServiceName; 

        public string ServiceTypeName
        {
            get
            {
                ServiceType serviceType = Controller.ServiceType;
                string serviceTypeName = "";
                if ((serviceType & ServiceType.InteractiveProcess) != 0)
                {
                    serviceTypeName = "Interactive";
                    serviceType -= ServiceType.InteractiveProcess;
                }

                switch (serviceType) {
                    case ServiceType.Adapter:
                        serviceTypeName += "Adapter";
                        break;
                    case ServiceType.FileSystemDriver:
                    case ServiceType.KernelDriver:
                    case ServiceType.RecognizerDriver:
                        serviceTypeName += "Driver";
                        break;
                    case ServiceType.Win32OwnProcess:
                        serviceTypeName += "Win32 Service Process";
                        break;
                    case ServiceType.Win32ShareProcess:
                        serviceTypeName += "Win32 Shared Process";
                        break;
                    default:
                        serviceTypeName += "unknown type" + serviceType.ToString();
                        break;
                }
                return serviceTypeName;
            }
        }

        public string ServiceStatusName
        {
            get
            {
                switch (Controller.Status) {
                    case ServiceControllerStatus.ContinuePending:
                        return "Continue Pending";
                    case ServiceControllerStatus.Paused:
                        return "Paused";
                    case ServiceControllerStatus.PausePending:
                        return "Pause Pending";
                    case ServiceControllerStatus.StartPending:
                        return "Start Pending";
                    case ServiceControllerStatus.Running:
                        return "Running";
                    case ServiceControllerStatus.Stopped:
                        return "Stopped";
                    case ServiceControllerStatus.StopPending:
                        return "Stop Pending";
                    default:
                        return "Unknown status";
                }
            }
        }

        public bool EnableStart => Controller.Status == ServiceControllerStatus.Stopped;

        public bool EnableStop => Controller.Status == ServiceControllerStatus.Running;

        public bool EnablePause => Controller.Status == ServiceControllerStatus.Running && Controller.CanPauseAndContinue;

        public bool EnableContinue => Controller.Status == ServiceControllerStatus.Paused;
    }
}
