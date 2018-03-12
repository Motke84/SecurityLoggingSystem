using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.BL.Entities.EventSubscribers;
using LoggingServiceLibrary.BL.Entities.Notifyers;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;
using LoggingServiceLibrary.Utils;

namespace LoggingServiceLibrary.BL.Entities
{
    public class NotifiersManager
    {
        private readonly Dictionary<Enums.SubscriberType, NotifierBase> _notifiers;

        public NotifiersManager()
        {
            _notifiers = new Dictionary<Enums.SubscriberType, NotifierBase>();

            var allEventSubscribernew = new AllEventSubscriber();

            var securityNotifier = new SecurityNotifier();
            securityNotifier.Attach(new SecurityEventSubscriber());
            securityNotifier.Attach(allEventSubscribernew);
            _notifiers.Add(Enums.SubscriberType.Security, securityNotifier);

            var fireNotifier = new FireNotifier();
            fireNotifier.Attach(new FireEventSubscriber());
            fireNotifier.Attach(allEventSubscribernew);
            _notifiers.Add(Enums.SubscriberType.Fire, fireNotifier);
        }

        public void Notify(SecurityEvent securityEvent)
        {
            switch (securityEvent.DetectorType)
            {
                case Enums.DedectorType.Fire:
                    _notifiers[Enums.SubscriberType.Fire].Notify(securityEvent);
                    break;
                case Enums.DedectorType.Security:
                    _notifiers[Enums.SubscriberType.Security].Notify(securityEvent);
                    break;
                default:
                    Console.WriteLine("Not defined yet");
                    break;
            }
        }
    }
}
