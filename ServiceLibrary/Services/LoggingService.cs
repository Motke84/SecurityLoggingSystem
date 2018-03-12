using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using LoggingServiceLibrary.BL.Entities;
using LoggingServiceLibrary.BL.Entities.EventSubscribers;
using LoggingServiceLibrary.BL.Entities.Notifyers;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;


namespace LoggingServiceLibrary
{
    [KnownType(typeof(SeveritySecurityEvent))]
    public class LoggingService : ILoggingService
    {
        private static readonly NotifiersManager NotifiersManager;

        static LoggingService()
        {
            NotifiersManager = new NotifiersManager();
        }

        public void LogSecurityEvent(SecurityEvent securityEvent)
        {
            NotifiersManager.Notify(securityEvent);

        }
    }
}
