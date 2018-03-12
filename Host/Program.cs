using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using LoggingServiceLibrary;
using System.Diagnostics;
using System.Threading;
using LoggingServiceLibrary.BL.Entities.EventSubscribers;
using LoggingServiceLibrary.BL.Entities.Notifyers;

namespace Host
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

      

           
            WinService winService = new WinService();
            Console.ReadLine();
        }


      
    }
}
