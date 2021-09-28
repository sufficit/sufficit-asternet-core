using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager
{
    public interface IManagerConnection
    {
        int ReconnectIntervalMax { get; set; }
        bool FireAllEvents { get; set; }
        int PingInterval { get; set; }
        string Hostname { get; set; }
        int Port { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        int SleepTime { get; set; }
        int DefaultEventTimeout { get; set; }
        int ReconnectIntervalFast { get; set; }
        bool KeepAliveAfterAuthenticationFailure { get; set; }
        bool KeepAlive { get; set; }
        Encoding SocketEncoding { get; set; }
        int SocketReceiveBufferSize { get; set; }
        string Version { get; }
        int DefaultResponseTimeout { get; set; }
        int ReconnectRetryMax { get; set; }
        AsteriskVersion AsteriskVersion { get; }
        int ReconnectRetryFast { get; set; }
    }
}
