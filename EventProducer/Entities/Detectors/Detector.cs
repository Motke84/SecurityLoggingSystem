using System.Collections.Generic;
using EventProducer.LoggingService;

namespace EventProducer.Entities.Detectors
{
    public abstract class Detector
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public string DetectorType { get; set; }

        public int DetectorId { get; set; }

        public string EventDescription { get; set; }

        public string PhysicalLocation { get; set; }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            var securityEvent = CreateSecurityEvent();

            foreach (Observer o in _observers)
            {
                o.Update(securityEvent);
            }
        }

        protected virtual SecurityEvent CreateSecurityEvent()
        {
            return new SecurityEvent()
            {
                DetectorId = DetectorId,
                DetectorType = DetectorType,
                EventDescription = EventDescription,
                PhysicalLocation = PhysicalLocation
            };
        }
    }
}
