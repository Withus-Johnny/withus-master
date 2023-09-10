using Client.Controllers;
using Client.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Effects.FadeEffect;
using WithusUI.Forms;
using WithusUI.Helpers;

namespace Client.Forms
{
    public partial class LoginForm : WithusForm
    {
        private bool _isEmailValid = false;
        private bool _isPasswordValid = false;

        IFadeEffect _fadeEffect;

        public AgreementForm _agreementForm;
        public RegisterForm _registerForm;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "위더스 - 로그인";
            this.Icon = Resources.Icon_Withus;
            this.Size = Const.LoginFormSize;

            SubscribeToDragEventsForPanels(this);

            linkLabel_Register.Paint += LinkLabel_Register_Paint;
            linkLabel_LoginProblem.Paint += LinkLabel_LoginProblem_Paint;

            _fadeEffect = new FadeEffect();
        }

        public void InitializeAgreementForm()
        {
            if (_agreementForm != null) return;
            _agreementForm = new AgreementForm();
            _agreementForm.FormClosed += _agreementForm_FormClosed;
            _agreementForm.ShowDialog(this);
        }

        public void InitializeRegisterForm()
        {
            if (_registerForm != null) return;
            _registerForm = new RegisterForm();
            _registerForm.FormClosed += _registerForm_FormClosed;
            _registerForm.ShowDialog(this);
        }


        #region Control Events
        private void _registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_registerForm == null) return;
            _registerForm.FormClosed -= _registerForm_FormClosed;
            _registerForm = null;
        }

        private void linkLabel_Register_Click(object sender, EventArgs e)
        {
            if (_agreementForm == null)
            {
                InitializeAgreementForm();
            }
        }

        private void _agreementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _agreementForm.FormClosed -= _agreementForm_FormClosed;
            _agreementForm = null;
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

        private async void trayButton_Click(object sender, EventArgs e)
        {
            if (_fadeEffect.IsFading()) return;

            await _fadeEffect.FormFadeOutAsync(this);
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (_fadeEffect.IsFading())
            {
                _fadeEffect.Abort();
            }

            SystemController.Instance.Stop();
            Application.Exit();
        }
        #endregion

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && this.Opacity == 1)
            {
                this.Opacity = 0;
                _fadeEffect.FormFadeIn(this);
            }
        }
    }
}