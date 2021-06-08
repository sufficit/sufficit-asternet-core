using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Event
{
    public interface QueueCallerAbandonEventInterface
    {
        string Queue { get; }
        int Position { get; }
        int HoldTime { get; }
        string CallerIdNum { get; }
        string Channel { get; }
    }
}
