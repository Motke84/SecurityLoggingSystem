using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using LoggingServiceLibrary;

namespace Host
{
    public class WinService
    {
        public WinService()
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(LoggingServiceLibrary.LoggingService)))
            {  
                serviceHost.Open();
                Console.WriteLine("Logging Service is up!!!");
                Console.ReadLine();
            }
        }
    }
}
