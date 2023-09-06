using Shared.Networks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ServerPackets
{
    public sealed class Connected : Packet
    {
        public override short Index
        {
            get { return (short)ServerPacketIds.Connected; }
        }

        protected override void ReadPacket(BinaryReader reader)
        {
        }

        protected override void WritePacket(BinaryWriter writer)
        {
        }
    }
}
