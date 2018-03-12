using System.Runtime.Serialization;
using LoggingServiceLibrary.Utils;

namespace LoggingServiceLibrary.BL.Entities.SecurityEvents
{
    
    public class SeveritySecurityEvent : SecurityEvent
    {
        [DataMember]
        public Enums.Severity Severity { get; set; }

        public override string ToString()
        {
            return $"{DetectorId}, {DetectorType}, {PhysicalLocation}, {EventDescription}, {Severity}";
        }
    }
}
