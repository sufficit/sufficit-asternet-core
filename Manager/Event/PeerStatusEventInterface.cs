using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Event
{
    public interface PeerStatusEventInterface
    {
        ChannelTypeEnum ChannelType { get; }

        string Peer { get; }

        PeerStatusEnum PeerStatus { get; }

        DateTime DateReceived { get; }

        string Address { get; }

        PeerStatusCauseEnum Cause { get; }

        int Time { get; }
    }
}
