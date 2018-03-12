﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventProducer.LoggingService;

namespace EventProducer.Entities
{
    public abstract class Observer
    {
        public abstract void Update(SecurityEvent securityEvent);
    }
}