﻿using Client.Properties;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Helpers;

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

        private bool _isEmailValid = false;
        private bool _isPasswordValid = false;

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
            panel_Blank3.MouseDown += Panel_DragMouseDown;
            panel_Blank4.MouseDown += Panel_DragMouseDown;
            panel_RegisterContainer.MouseDown += Panel_DragMouseDown;
            panel_LoginProblemContainer.MouseDown += Panel_DragMouseDown;

            panel_Blank1.MouseMove += Panel_DragMouseMove;
            panel_Blank2.MouseMove += Panel_DragMouseMove;
            panel_Blank3.MouseMove += Panel_DragMouseMove;
            panel_Blank4.MouseMove += Panel_DragMouseMove;
            panel_RegisterContainer.MouseMove += Panel_DragMouseMove;
            panel_LoginProblemContainer.MouseMove += Panel_DragMouseMove;

            panel_Blank1.MouseUp += Panel_DragMouseUp;
            panel_Blank2.MouseUp += Panel_DragMouseUp;
            panel_Blank3.MouseUp += Panel_DragMouseUp;
            panel_Blank4.MouseUp += Panel_DragMouseUp;
            panel_RegisterContainer.MouseUp += Panel_DragMouseUp;
            panel_LoginProblemContainer.MouseUp += Panel_DragMouseUp;

            linkLabel_Register.Paint += LinkLabel_Register_Paint;
            linkLabel_LoginProblem.Paint += LinkLabel_LoginProblem_Paint;
        }

        private void LinkLabel_LoginProblem_Paint(object sender, PaintEventArgs e)
        {
            int x = (panel_LoginProblemContainer.Width - linkLabel_LoginProblem.Width) / 2;
            int y = (panel_LoginProblemContainer.Height - linkLabel_LoginProblem.Height) / 2;

            linkLabel_LoginProblem.Location = new Point(x, y);
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
        private void LinkLabel_Register_Paint(object sender, PaintEventArgs e)
        {
            int x = (panel_RegisterContainer.Width - linkLabel_Register.Width) / 2;
            int y = (panel_RegisterContainer.Height - linkLabel_Register.Height) / 2;

            linkLabel_Register.Location = new Point(x, y);
        }

        private void darkTextBox_Email_MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (darkTextBox_Email.Texts.Length == 0)
                {
                    if (!Clipboard.ContainsText())
                    {
                        return;
                    }

                    string tempText = Clipboard.GetText();
                    if (EmailValidator.IsValidEmail(tempText))
                    {
                        _isEmailValid = true;
                        darkTextBox_Email.Texts = tempText;
                        darkTextBox_Email.Alignment = HorizontalAlignment.Center;
                    }
                }
            }
        }

        private void darkTextBox_Email_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void darkTextBox_Email_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_Email.Texts.Contains(" "))
            {
                darkTextBox_Email.Texts = darkTextBox_Email.Texts.Replace(" ", "");
                return;
            }

            if (EmailValidator.IsValidEmail(darkTextBox_Email.Texts))
            {
                _isEmailValid = true;
                darkTextBox_Email.Alignment = HorizontalAlignment.Center;
            }
            else
            {
                _isEmailValid = false;
                darkTextBox_Email.Alignment = HorizontalAlignment.Left;
            }
        }

        private void darkTextBox_Password_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_Password.Texts.Length >= 6)
            {
                _isPasswordValid = true;
                darkTextBox_Password.Alignment = HorizontalAlignment.Center;
            }
            else
            {
                _isPasswordValid = false;
                darkTextBox_Password.Alignment = HorizontalAlignment.Left;
            }
        }

        private void primeButton_Login_Click(object sender, EventArgs e)
        {
            if (!_isEmailValid)
            {
                darkTextBox_Email.Focus();
                return;
            }

            if (!_isPasswordValid)
            {
                darkTextBox_Password.Focus();
            }

            if (_isEmailValid && _isPasswordValid)
            {
                string inputEmail = darkTextBox_Password.Texts;
                string inputPassword = PasswordHasher.HashPassword(darkTextBox_Password.Texts);
                darkTextBox_Email.Enabled = false;
                darkTextBox_Password.Enabled = false;
                primeButton_Login.Enabled = false;
                this.ActiveControl = panel_Blank2;
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

            ActiveControl = panel_Blank2;
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

        private void linkLabel_Register_Click(object sender, EventArgs e)
        {
            Action hideAction = new Action(() => {
                this.Hide();
            });
            InitializeFadeOut(hideAction);

            // 회원 가입 폼 호출
        }
    }
}
