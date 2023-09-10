using Client.Controllers;
using Client.Forms;
using Client.Networks;
using Shared.Networks;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {

        public static LoginForm loginForm;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Packet.IsServer = false;
            SystemController.Instance.InitializeNetwork();
            Application.Run(loginForm = new LoginForm());
            SystemController.Instance.Stop();
        }
    }
}
