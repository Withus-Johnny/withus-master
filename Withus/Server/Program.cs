using Server.Environments;
using Shared.Networks;

namespace Server
{
    internal class Program
    {
        public static Envir Envir { get; private set; }
        static void Main(string[] args)
        {
            Envir = new Envir();
            Packet.IsServer = true;

            Envir.Start();

            Console.WriteLine("WITHUS SERVER END");
            Console.ReadKey();
        }
    }
}
