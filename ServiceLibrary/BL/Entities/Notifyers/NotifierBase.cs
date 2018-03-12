using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.BL.Entities.EventSubscribers;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;
using LoggingServiceLibrary.Utils;

namespace LoggingServiceLibrary.BL.Entities.Notifyers
{
    public abstract class NotifierBase
    {
        private readonly List<EventSubscriber> _observers;

        protected NotifierBase()
        {
            _observers = new List<EventSubscriber>();
        }


        public abstract Enums.SubscriberType SubscriberType { get;  }

        public void Attach(EventSubscriber eventSubscriber)
        {
            _observers.Add(eventSubscriber);
        }

        public void Detach(EventSubscriber eventSubscriber)
        {
            _observers.Remove(eventSubscriber);
        }

        public void Notify(SecurityEvent securityEvent)
        {
            _observers.AsParallel().ForAll(eventSubscriber => 
            {
                eventSubscriber.Update(securityEvent);
            });
        }
    }
}
