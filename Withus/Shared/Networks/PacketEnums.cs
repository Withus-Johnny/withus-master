using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Networks
{
    public enum ServerPacketIds : short
    {
        Connected,
        Disconnect,
        ClientVersion,
        KeepAlive,
    }
    public enum ClientPacketIds : short
    {
        ClientVersion,
        Disconnect,
        KeepAlive,
        NewAccount
    }
}
