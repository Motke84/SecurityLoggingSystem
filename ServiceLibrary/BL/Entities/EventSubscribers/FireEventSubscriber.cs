using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;

namespace LoggingServiceLibrary.BL.Entities.EventSubscribers
{
    public class FireEventSubscriber : EventSubscriber
    {
        public override void Update(SecurityEvent securityEvent)
        {
            Console.WriteLine("FireEventSubscriber {0}", securityEvent);
        }
    }
}
