using Client.Controllers;
using Client.Forms;
using Client.Networks;
using Shared.Networks;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public static class Program
    {        
        public static Guid guid = Guid.NewGuid();
        public static LoginForm loginForm;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Test Envir
            FileInfo serverFileInfo = new FileInfo(@"d:\Server.lnk");

			if (serverFileInfo.Exists)
			{
				Process[] processes = Process.GetProcessesByName("Server");
				if (processes.Length == 0)
				{
                    serverFileInfo = null;
                    Process serverProcess = Process.Start(@"D:\Debug\Server\Server.exe");
					Application.ApplicationExit += (o1, e1) => {
						serverProcess.Kill();
						serverProcess = null;
					};
				}
			}

			#endregion
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Packet.IsServer = false;
            SystemController.Instance.InitializeNetwork();
            Application.Run(loginForm = new LoginForm());
            SystemController.Instance.Stop();
        }
	}
}
