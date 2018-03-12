using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggingServiceLibrary.Utils;


namespace LoggingServiceLibrary.BL.Entities.Notifyers
{
    public class FireNotifier : NotifierBase
    {
        public override Enums.SubscriberType SubscriberType => Enums.SubscriberType.Fire;
    }
}

