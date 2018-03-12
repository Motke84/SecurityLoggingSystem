using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace LoggingServiceLibrary.Utils
{
    [DataContract]
    public class Enums
    {
        [DataContract]
        public enum DedectorType
        {
            [EnumMember]
            Fire,
            [EnumMember]
            Security,
        }

        [DataContract]
        public enum Severity
        {
            [EnumMember]
            Low,
            [EnumMember]
            Medium,
            [EnumMember]
            High,
        }

  
        public enum SubscriberType
        {
            Fire,
            Security,
            All,
        }
    }

}
