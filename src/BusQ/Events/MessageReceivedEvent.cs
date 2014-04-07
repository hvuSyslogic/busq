﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ServiceBus.Messaging;

namespace Ringo.BusQ.ServiceBus.Messaging.Events
{
    public class MessageReceivedEvent<T> : EventBase
    {
        public T Message { get; set; }
    }
}
