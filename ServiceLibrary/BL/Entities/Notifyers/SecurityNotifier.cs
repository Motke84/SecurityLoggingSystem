using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.Utils;

namespace LoggingServiceLibrary.BL.Entities.Notifyers
{
    public class SecurityNotifier : NotifierBase
    {
        public override Enums.SubscriberType SubscriberType => Enums.SubscriberType.Security;
    }
}

