using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;

namespace LoggingServiceLibrary.BL.Entities.EventSubscribers
{
    public class SecurityEventSubscriber : EventSubscriber
    {
        public override void Update(SecurityEvent securityEvent)
        {
            Console.WriteLine("SecurityEventSubscriber {0}", securityEvent);
        }
    }
}
