﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Event
{
    public enum PeerStatusEnum
    {
        Unknown,
        Unregistered,
        Lagged,
        Reachable,
        Unreachable,
        Rejected, // (IAX only)
        Registered
    }
}
