using LoggingServiceLibrary.BL.Entities.SecurityEvents;

namespace LoggingServiceLibrary.BL.Entities.EventSubscribers
{
    public abstract class EventSubscriber
    {
        public abstract void Update(SecurityEvent securityEvent);
    }
}