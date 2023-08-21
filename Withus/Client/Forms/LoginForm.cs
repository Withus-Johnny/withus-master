using Client.Properties;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace Client.Forms
{
    public partial class LoginForm : Form
    {

        private Timer _fadeTimer = new Timer();
        private const int FADE_TICK_VALUE = 25;
        private const double FADE_OPACITY_VALUE = 0.050;

        private bool _isDraging = false;
        private bool _isFading = false;

        private Point _dragStartPoint;
        private Rectangle _borderRect;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "위더스 - 로그인";
            this.Icon = Resources.Icon_Withus;
            this.Size = Const.LoginFormSize;
            this.Padding = new Padding(Const.LoginForm_Padding);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
            _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));

            panel_CaptionBar.MouseDown += Panel_DragMouseDown;
            panel_ClientArea.MouseDown += Panel_DragMouseDown;
            pictureBox_Brand.MouseDown += Panel_DragMouseDown;

            panel_CaptionBar.MouseMove += Panel_DragMouseMove;
            panel_ClientArea.MouseMove += Panel_DragMouseMove;
            pictureBox_Brand.MouseMove += Panel_DragMouseMove;

            panel_CaptionBar.MouseUp += Panel_DragMouseUp;
            panel_ClientArea.MouseUp += Panel_DragMouseUp;
            pictureBox_Brand.MouseUp += Panel_DragMouseUp;            

            this.Activated += LoginForm_Activated;

            panel_Blank1.MouseDown += Panel_DragMouseDown;
            panel_Blank2.MouseDown += Panel_DragMouseDown;

            panel_Blank1.MouseMove += Panel_DragMouseMove;
            panel_Blank2.MouseMove += Panel_DragMouseMove;

            panel_Blank1.MouseUp += Panel_DragMouseUp;
            panel_Blank2.MouseUp += Panel_DragMouseUp;
        }

        #region Function
        private async Task FlashBorder(int duration = 150, int repeatCount = 3)
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
        private void InitializeFadeIn()
        {
            this.WindowState = FormWindowState.Normal;
            _isFading = true;
            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeInTimer_Tick;
            _fadeTimer.Start();
        }
        private void InitializeFadeOut(Action callBackAction)
        {
            _isFading = true;
            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tag = callBackAction;
            _fadeTimer.Tick += FadeOutTimer_Tick;
            _fadeTimer.Start();
        }
        #endregion

        #region Function Event
        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0)
            {
                _fadeTimer.Tick -= FadeOutTimer_Tick;
                _fadeTimer.Stop();
                _isFading = false;
                ((Action)_fadeTimer.Tag).Invoke();
            }
            else
            {
                this.Opacity -= FADE_OPACITY_VALUE;
            }
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                _fadeTimer.Tick -= FadeInTimer_Tick;
                _fadeTimer.Stop();
                _isFading = false;
            }
            else
            {
                this.Opacity += FADE_OPACITY_VALUE;
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

        private void trayButton_Click(object sender, EventArgs e)
        {
            if (!_isFading)
            {
                Action tryAction = new Action(() =>
                {
                    this.WindowState = FormWindowState.Minimized;
                });
                InitializeFadeOut(tryAction);
                return;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (_fadeTimer.Enabled)
                return;

            string exitConfirmationMessage = string.Format(SystemLanguage.ExitConfirmation_Message, this.Text);
            DialogResult exitConfirmResult = MessageBox.Show(exitConfirmationMessage, SystemLanguage.Caption_System, MessageBoxButtons.YesNo);
            if (exitConfirmResult == DialogResult.No)
            {
                return;
            }
            else
            {
                Action exitAction = new Action(() =>
                {
                    Application.Exit();
                });
                InitializeFadeOut(exitAction);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Fade In 처리를 위한 사전 설정
            this.Opacity = 0;
            this.WindowState = FormWindowState.Minimized;

            ActiveControl = panel_Blank1;
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            if (!_isFading && this.Opacity == 0 && this.WindowState == FormWindowState.Minimized)
            {
                InitializeFadeIn();
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
