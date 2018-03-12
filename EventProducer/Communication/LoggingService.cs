using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventProducer.LoggingService;

namespace EventProducer.Communication
{
    public class LoggingService
    {

        private static readonly object SyncLock = new object();
        private static LoggingService _instance;


        protected LoggingService()
        {
            
        }

        public static LoggingService Instance()
        {
            
            if (_instance == null)
            {
                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoggingService();
                    }
                }
            }

            return _instance;
        }

        public void LogSecurityEvent(List<SecurityEvent> securityEvents)
        {
            try
            {
                using (var client = new LoggingServiceClient())
                {
                    client.LogSecurityEvent(securityEvents);
                }

            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
