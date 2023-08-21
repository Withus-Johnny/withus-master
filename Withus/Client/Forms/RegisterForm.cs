using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace Client.Forms
{
    public partial class RegisterForm : Form
    {
        private Timer _fadeTimer = new Timer();
        private const int FADE_TICK_VALUE = 25;
        private const double FADE_OPACITY_VALUE = 0.050;

        private Rectangle _borderRect;

        private bool _isDraging = false;
        private Point _dragStartPoint;

        private bool _isDragging = false;

        private const int GRIP_SIZE = 15;
        private Rectangle gripRect;
        private bool _isResizing = false;
        private Point _lastMousePosition;

        private bool _isFading = false;

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
            this.Padding = new Padding(Const.RegisterForm_Padding);
            _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
            gripRect = new Rectangle(this.Width - GRIP_SIZE, this.Height - GRIP_SIZE, GRIP_SIZE, GRIP_SIZE);

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Load += RegisterForm_Load;
            this.Activated += RegisterForm_Activated;

            panel_Container.MouseDown += Panel_DragMouseDown;
            panel_Container.MouseMove += Panel_DragMouseMove;
            panel_Container.MouseUp += Panel_DragMouseUp;

            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
        }

        #region Functions

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
        #endregion

        #region Control Events
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Fade In 처리를 위한 사전 설정
            this.Opacity = 0;
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegisterForm_Activated(object sender, EventArgs e)
        {
            InitializeFadeIn();
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

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0)
            {
                _fadeTimer.Tick -= FadeOutTimer_Tick;
                _fadeTimer.Stop();
                _isFading = false;
                if (((Action)_fadeTimer.Tag != null))
                {
                    ((Action)_fadeTimer.Tag).Invoke();
                }

            }
            else
            {
                this.Opacity -= FADE_OPACITY_VALUE;
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            Action returnAction = new Action(() =>
            {
                this.Hide();
                Program.loginForm.Show();
                Program.loginForm.InitializeFadeIn();
                this.Close();
            });
            InitializeFadeOut(returnAction);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_isResizing && e.Button == MouseButtons.Left)
            {
                if (gripRect.Contains(e.Location))
                {
                    _isResizing = true;
                    _lastMousePosition = e.Location;
                }
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None && !_isResizing)
            {
                if (gripRect.Contains(e.Location))
                {
                    this.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }

            if (_isResizing)
            {
                this.Width += e.X - _lastMousePosition.X;
                this.Height += e.Y - _lastMousePosition.Y;
                if (_lastMousePosition != e.Location)
                {
                    _lastMousePosition = e.Location;

                    _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
                    gripRect = new Rectangle(this.Width - GRIP_SIZE, this.Height - GRIP_SIZE, GRIP_SIZE, GRIP_SIZE);

                    this.Invalidate();
                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                _isDragging = false;
            }

            if (_isResizing)
            {
                _isResizing = false;
            }
        }

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

            if (!_isResizing)
            {
                this.Cursor = Cursors.Default;
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
                g.FillRectangle(Brushes.Gray, gripRect);
            }
        }

        #endregion
    }
}
