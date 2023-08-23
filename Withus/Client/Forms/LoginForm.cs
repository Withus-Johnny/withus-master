using Client.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Effects.FadeEffect;
using WithusUI.Effects.FlashBoarder;
using WithusUI.Helpers;

namespace Client.Forms
{
    public partial class LoginForm : Form
    {
        private bool _isDraging = false;

        private Point _dragStartPoint;
        private Rectangle _borderRect;

        private bool _isEmailValid = false;
        private bool _isPasswordValid = false;

        IFadeEffect fadeEffect;
        IFlashBorder flashBorder;

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
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            UpdateStyles();

            _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));

            #region 이벤트 구독
            panel_CaptionBar.MouseDown += Panel_DragMouseDown;
            panel_ClientArea.MouseDown += Panel_DragMouseDown;
            pictureBox_Brand.MouseDown += Panel_DragMouseDown;

            panel_CaptionBar.MouseMove += Panel_DragMouseMove;
            panel_ClientArea.MouseMove += Panel_DragMouseMove;
            pictureBox_Brand.MouseMove += Panel_DragMouseMove;

            panel_CaptionBar.MouseUp += Panel_DragMouseUp;
            panel_ClientArea.MouseUp += Panel_DragMouseUp;
            pictureBox_Brand.MouseUp += Panel_DragMouseUp;

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
            #endregion

            fadeEffect = new FadeEffect();
            flashBorder = new FlashBorder();
        }

        #region Control Events

        private void linkLabel_Register_Click(object sender, EventArgs e)
        {
            Program.agreementForm = new AgreementForm();
            Program.agreementForm.ShowDialog();
        }

        private void LinkLabel_LoginProblem_Paint(object sender, PaintEventArgs e)
        {
            int x = (panel_LoginProblemContainer.Width - linkLabel_LoginProblem.Width) / 2;
            int y = (panel_LoginProblemContainer.Height - linkLabel_LoginProblem.Height) / 2;

            linkLabel_LoginProblem.Location = new Point(x, y);
        }

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
                if (fadeEffect.IsFading()) return;
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

                Screen currentScreen = Screen.FromControl(this);
                Rectangle screenBounds = currentScreen.WorkingArea;
                Rectangle formBounds = new Rectangle(this.Location, this.Size);

                bool isOutOfBounds = !screenBounds.Contains(formBounds);

                if (isOutOfBounds)
                {
                    formBounds.X = Math.Max(screenBounds.Left, Math.Min(formBounds.X, screenBounds.Right - formBounds.Width));
                    formBounds.Y = Math.Max(screenBounds.Top, Math.Min(formBounds.Y, screenBounds.Bottom - formBounds.Height));

                    this.Location = formBounds.Location;
                    this.Invalidate();

                    flashBorder.SetOption(150, 3, Color.IndianRed).Flush(this);
                }
            }
        }

        private async void trayButton_Click(object sender, EventArgs e)
        {
            if (fadeEffect.IsFading()) return;

            await fadeEffect.FormFadeOutAsync(this);
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (fadeEffect.IsFading())
            {
                fadeEffect.Abort();
            }

            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            fadeEffect.FormFadeIn(this);
            ActiveControl = panel_Blank2;
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

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && this.Opacity == 1)
            {
                this.Opacity = 0;
                fadeEffect.FormFadeIn(this);
            }
        }
    }
}