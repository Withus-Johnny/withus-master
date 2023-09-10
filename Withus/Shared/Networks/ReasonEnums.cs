using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Networks
{
    public enum DisconnectReason : byte
    {
        TimeOut,
        ClientShutDown,
        ClientExit,
        Maintainance
    }
}
