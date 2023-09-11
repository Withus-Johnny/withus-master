using Client.Networks;
using ServerPackets;
using Shared.Networks;
using System;
using System.Diagnostics;
using System.Threading;
using C = ClientPackets;
using S = ServerPackets;

namespace Client.Controllers
{
    public class SystemController
    {
        private static readonly SystemController instance = new SystemController();
        public static SystemController Instance { get { return instance; } }

        private Thread networkThread;
        public bool isRunning { get; set; }

        public Stopwatch Timer = Stopwatch.StartNew();
        public DateTime StartTime = DateTime.UtcNow;
        public DateTime Now { get { return StartTime.AddMilliseconds(Time); } }
        public static long Time;

        public static double BytesSent, BytesReceived;

        public void InitializeNetwork()
        {
            networkThread = new Thread(new ThreadStart(Running));
            networkThread.IsBackground = true;
            networkThread.Start();
        }

        private void Running()
        {
            Timer = Stopwatch.StartNew();
            StartTime = DateTime.UtcNow;

            isRunning = true;
            Network.Connect();

            try
            {
                while (isRunning)
                {
                    Time = Timer.ElapsedMilliseconds;
                    Network.Process();
                }

                Time = 0;
                BytesSent = 0;
                BytesReceived = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Stop()
        {
            try
            {
                if (isRunning)
                {
                    Network.Enqueue(new C.Disconnect());
                }

                isRunning = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void ProcessPacket(Packet p)
        {
            switch (p.Index)
            {
                case (short)ServerPacketIds.Connected:
                    Network.Connected = true;
                    break;
                case (short)ServerPacketIds.KeepAlive:
                    KeepAlive((S.KeepAlive)p);
                    break;
                case (short)ServerPacketIds.NewAccountSuccess:
                    NewAccountSuccess((S.NewAccountSuccess)p);
                    break;
                case (short)ServerPacketIds.NewAccountFailure:
                    NewAccountFailure((S.NewAccountFailure)p);
                    break;
                default:
                    Console.WriteLine($"미개발 : {p.Index}");
                    break;
            }
        }

        private void NewAccountFailure(NewAccountFailure p)
        {
            switch ((NewAccountReason)p.Reason)
            {
                case NewAccountReason.RegistrationStopped:
                    Program.loginForm.RegisterForm.NewAccountFailure("지금은 회원가입을 진행 할 수 없습니다");
                    break;
            }
        }

        private void NewAccountSuccess(S.NewAccountSuccess p)
        {
            Console.WriteLine("회원가입 승인");
        }

        private void KeepAlive(S.KeepAlive p)
        {
            if (p.Time == 0) return;
            Network.PingTime = (Time - p.Time);
        }
    }
}