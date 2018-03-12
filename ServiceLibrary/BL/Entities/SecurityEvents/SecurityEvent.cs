using System.Runtime.Serialization;
using LoggingServiceLibrary.Utils;

namespace LoggingServiceLibrary.BL.Entities.SecurityEvents
{
    [DataContract]
    [KnownType(typeof(SeveritySecurityEvent))]
    public class SecurityEvent
    {
        [DataMember]
        public Enums.DedectorType DetectorType { get; set; }

        [DataMember]
        public int DetectorId { get; set; }

        [DataMember]
        public string EventDescription { get; set; }

        [DataMember]
        public string PhysicalLocation { get; set; }

        public override string ToString()
        {
            return $"{DetectorId}, {DetectorType}, {PhysicalLocation}, {EventDescription}";
        }
    }
}
