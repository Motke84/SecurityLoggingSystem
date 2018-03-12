using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventProducer.LoggingService;

namespace EventProducer.Entities
{
    public class EventProducerManager : Observer
    {
        public override void Update(SecurityEvent securityEvent)
        {
            Communication.LoggingService.Instance().LogSecurityEvent(new List<SecurityEvent>() { securityEvent });
        }
    }
}
