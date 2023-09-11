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
        NewAccountSuccess,
        NewAccountFailure,
    }

    public enum ClientPacketIds : short
    {
        ClientVersion,
        Disconnect,
        KeepAlive,
        NewAccount
    }
}
