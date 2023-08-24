using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Effects.FadeEffect;
using WithusUI.Forms;
using WithusUI.Helpers;

namespace Client.Forms
{
    public partial class RegisterForm : WithusForm
    {
        private IFadeEffect _fadeEffect;
        private Font _defaultFont;
        private int _masterCode;
        private const int Email_Confirm_Delay = 120;
        private Stopwatch _stopwatch;
        private bool _isSent = false;
        private bool _isCertified = false;

        public RegisterForm()
        {
            InitializeComponent();
            SubscribeToDragEventsForPanels(this);
            _fadeEffect = new FadeEffect();
            _defaultFont = darkTextBox_Email.Font;
            _stopwatch = new Stopwatch();
        }

        private void RegisterForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if ((ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                return;
            }
        }
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnsubscribeFromDragEventsForPanels(this);
            _fadeEffect.Dispose();
            _fadeEffect = null;
            this.Dispose();
        }

        private async void button_Return_Click(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                await _fadeEffect.FormFadeOutAsync(this);
                this.Close();
            }
        }

        private void darkTextBox_Email_TextChangedEvent(object sender, EventArgs e)
        {
            if (EmailValidator.IsValidEmail(darkTextBox_Email.Texts))
            {
                darkTextBox_Email.Alignment = HorizontalAlignment.Center;
                darkTextBox_Email.Font = new Font(darkTextBox_Email.Font, FontStyle.Bold);
                darkTextBox_Email.ForeColor = Color.Gainsboro;
                panel_EmailValidation.Visible = true;
                this.Height = this.Height + 45;
            }
            else
            {
                darkTextBox_Email.Alignment = HorizontalAlignment.Left;
                darkTextBox_Email.Font = new Font(_defaultFont, FontStyle.Regular);
                darkTextBox_Email.ForeColor = Colors.DarkTextBoxForeColor;

                if (panel_EmailValidation.Visible)
                {
                    panel_EmailValidation.Visible = false;
                    this.Height = this.Height - 45;
                }
            }
        }

        private void primeButton_Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Size);
        }

        private void primeButton_EmailConfirm_Click(object sender, EventArgs e)
        {
            darkTextBox_Email.Enabled = false;
            primeButton_EmailConfirm.Enabled = false;            
            
            Random rand = new Random();
            _masterCode = rand.Next(100000, 999999);
            darkTextBox_EmailConfirmCode.PlaceholderText = "인증 코드를 입력하세요.";
            Console.WriteLine(_masterCode);

            _isSent = true;
            InterfaceTimer.Start();
            _stopwatch.Start();
        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            if (_isSent)
            {
                if (_isCertified)
                {
                    primeButton_EmailConfirm.Text = "인증 완료";
                    darkTextBox_EmailConfirmCode.Enabled = false;
                    primeButton_EmailConfirm.BackColor = Color.Green;
                    InterfaceTimer.Stop();
                    _stopwatch.Reset();
                    _stopwatch.Stop();
                    return;
                }

                if (_stopwatch.Elapsed.Seconds == Email_Confirm_Delay)
                {
                    primeButton_EmailConfirm.Text = "재전송 하기";                    
                    InterfaceTimer.Stop();
                    _stopwatch.Reset();
                    _stopwatch.Stop();
                    darkTextBox_Email.Enabled = true;
                    primeButton_EmailConfirm.Enabled = true;
                    darkTextBox_EmailConfirmCode.Texts = "";
                }
                else
                {
                    primeButton_EmailConfirm.Text = $"{Email_Confirm_Delay - _stopwatch.Elapsed.Seconds}";
                }
            }
        }

        private void darkTextBox_EmailConfirmCode_Enter(object sender, EventArgs e)
        {
            if (_masterCode == default(int))
            {
                this.ActiveControl = primeButton_EmailConfirm;
            }
        }

        private void darkTextBox_EmailConfirmCode_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_EmailConfirmCode.Texts.Length == 6)
            {
                if (darkTextBox_EmailConfirmCode.Texts == _masterCode.ToString())
                {
                    panel_EmailValidation.Enabled = false;                    
                    _isCertified = true;
                }
                else
                {
                    darkTextBox_EmailConfirmCode.Texts = "";
                }
            }
        }

        private void InputPassword_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_Password.Texts.Length >= 6 && 
                darkTextBox_ConfirmPassword.Texts.Length >= 6)
            {
                if (darkTextBox_Password.Texts == darkTextBox_ConfirmPassword.Texts)
                {
                    darkTextBox_Password.Alignment = HorizontalAlignment.Center;
                    darkTextBox_ConfirmPassword.Alignment = HorizontalAlignment.Center;
                    return;
                }                
            }
            else
            {
                darkTextBox_Password.Alignment = HorizontalAlignment.Left;
                darkTextBox_ConfirmPassword.Alignment = HorizontalAlignment.Left;
            }            
        }

        private void darkTextBox_UserName_Leave(object sender, EventArgs e)
        {
            if (darkTextBox_UserName.Texts.Length >= 2)
            {
                darkTextBox_UserName.Alignment = HorizontalAlignment.Center;
            }
            else
            {
                darkTextBox_UserName.Alignment = HorizontalAlignment.Left;
            }
        }

        private void darkTextBox_UserName_Enter(object sender, EventArgs e)
        {
            if (darkTextBox_UserName.Alignment == HorizontalAlignment.Center)
            {
                darkTextBox_UserName.Alignment = HorizontalAlignment.Left;
            }
        }
    }
}
