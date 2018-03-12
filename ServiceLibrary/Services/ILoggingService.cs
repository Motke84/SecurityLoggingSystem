using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LoggingServiceLibrary.BL.Entities;
using LoggingServiceLibrary.BL.Entities.SecurityEvents;

namespace LoggingServiceLibrary
{
    [ServiceContract]
    public interface ILoggingService
    {
        [OperationContract]
        void LogSecurityEvent(SecurityEvent securityEvent);
    }

    
}
