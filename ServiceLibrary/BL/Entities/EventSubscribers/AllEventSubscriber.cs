using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;

namespace LoggingServiceLibrary.BL.Entities.EventSubscribers
{
    public class AllEventSubscriber : EventSubscriber
    {
        public override void Update(SecurityEvent securityEvent)
        {
            Console.WriteLine("AllEventSubscriber {0}", securityEvent);
        }
    }
}
