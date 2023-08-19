using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace Client.Forms
{
    public partial class LoginForm : Form
    {

        private bool _isDraging = false;
        private Point _dragStartPoint;
        private Rectangle _borderRect;

        public LoginForm()
        {
            InitializeComponent();
            this.Size = Const.LoginFormSize;
            this.Padding = new Padding(Const.LoginForm_Padding);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
            _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));

            panel_CaptionBar.MouseDown += Panel_DragMouseDown;
            panel_ClientArea.MouseDown += Panel_DragMouseDown;

            panel_CaptionBar.MouseMove += Panel_DragMouseMove;
            panel_ClientArea.MouseMove += Panel_DragMouseMove;

            panel_CaptionBar.MouseUp += Panel_DragMouseUp;
            panel_ClientArea.MouseUp += Panel_DragMouseUp;
        }

        #region Function
        private async Task FlashBorder(int duration = 300, int repeatCount = 3)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.ResetClip();

                for (int i = 0; i < repeatCount; i++)
                {
                    using (Pen pen = new Pen(Color.IndianRed))
                    {
                        g.DrawRectangle(pen, _borderRect);
                    }
                    await Task.Delay(duration);

                    using (Pen pen = new Pen(Colors.FormBorderColor))
                    {
                        g.DrawRectangle(pen, _borderRect);
                    }
                    await Task.Delay(duration);
                }
            }
        }

        private async void EnsureWindowPositionWithinScreenBounds()
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

            // 창이 화면의 상단 경계를 벗어난 경우 처리합니다.
            if (this.Top < screenBounds.Top)
            {
                newLocation.Y = screenBounds.Top;
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
                await FlashBorder();
            }
        }
        #endregion

        #region Control Events
        private void Panel_DragMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDraging = true;
                _dragStartPoint = e.Location;
            }
        }

        private void Panel_DragMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDraging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - _dragStartPoint.X, currentScreenPos.Y - _dragStartPoint.Y);
            }
        }

        private void Panel_DragMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDraging = false;
                EnsureWindowPositionWithinScreenBounds();
            }
        }
        #endregion

        #region Override Events
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            var g = e.Graphics;

            using (var p = new Pen(Colors.FormBorderColor))
            {
                g.DrawRectangle(p, _borderRect);
            }
        }
        #endregion
    }
}
