using System;
using System.Collections.Generic;
using EventProducerBL.LoggingService;

namespace EventProducerBL.Communication
{
    public class EventProducer
    {

        private static readonly object SyncLock = new object();
        private static EventProducer _instance;


        protected EventProducer()
        {
            
        }

        public static EventProducer Instance()
        {
            
            if (_instance == null)
            {
                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new EventProducer();
                    }
                }
            }

            return _instance;
        }

        public void LogSecurityEvent(SecurityEvent securityEvent)
        {
            try
            {
                using (var client = new LoggingServiceClient())
                {
                    client.LogSecurityEvent(securityEvent);
                }

            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
