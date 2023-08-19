using System;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Win32;

namespace Client.Forms
{
	public partial class LoginForm : Form
	{
		private Rectangle _borderRect;

		public LoginForm()
		{
			InitializeComponent();
			this.Size = new Size(364, 783);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.FormBorderStyle = FormBorderStyle.None;
			this.BackColor = Colors.FormBackGroundColor;
			_borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			switch (m.Msg)
			{
				case WindowMessages.WM_NCLBUTTONDOWN:
					this.BeginInvoke(new MethodInvoker(EnsureWindowPositionWithinScreenBounds));
					break;
				case WindowMessages.WM_NCHITTEST:
					if ((int)m.Result == WindowMessages.HTCLIENT)
					{
						m.Result = (IntPtr)WindowMessages.HTCAPTION;
					}
					return;
			}
		}

		private void EnsureWindowPositionWithinScreenBounds()
		{
			// 현재 창이 속한 스크린을 가져옵니다.
			Screen currentScreen = Screen.FromControl(this);

			// 스크린의 작업 영역을 가져옵니다.
			Rectangle screenBounds = currentScreen.WorkingArea;

			// 창이 화면 영역 밖으로 나가는지 여부를 나타내는 변수입니다.
			bool outOfBounds = false;

			// 현재 창의 위치를 새 위치로 업데이트할 변수를 생성합니다.
			Point newLocation = this.Location;

			// 창이 화면의 왼쪽 경계를 벗어난 경우 처리합니다.
			if (this.Left < screenBounds.Left)
			{
				newLocation.X = screenBounds.Left;
				outOfBounds = true;
			}

			// 창이 화면의 오른쪽 경계를 벗어난 경우 처리합니다.
			if (this.Right > screenBounds.Right)
			{
				newLocation.X = screenBounds.Right - this.Width;
				outOfBounds = true;
			}

			// 창이 화면의 아래쪽 경계를 벗어난 경우 처리합니다.
			if (this.Bottom > screenBounds.Bottom)
			{
				newLocation.Y = screenBounds.Bottom - this.Height;
				outOfBounds = true;
			}

			// 창이 화면 영역을 벗어났다면 새 위치로 이동합니다.
			if (outOfBounds)
			{
				this.Location = newLocation;
			}
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			var g = e.Graphics;

			using (var p = new Pen(Colors.FormBorderColor))
			{
				g.DrawRectangle(p, _borderRect);
			}
		}
	}
}
