﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Environments
{
    public static class Settings
    {
        public const int Day = 24 * Hour, Hour = 60 * Minute, Minute = 60 * Second, Second = 1000;

        // 네트워크
        public static string IPAddress = "127.0.0.1";

        public static ushort Port = 7777,
                             TimeOut = 10 * Second,
                             MaxUser = 100,
                             MaxIP = 1,
                             MaxPacket = 50;
    }
}
