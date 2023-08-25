using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Controls.TextBoxs.DarkTextBox;
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

        private bool _isEmailCertified = false;
        private bool _isPasswordValid = false;
        private bool _isUserNameValid = false;
        private bool _isPhoneValid = false;

        public RegisterForm()
        {
            InitializeComponent();
            SubscribeToDragEventsForPanels(this);
            _fadeEffect = new FadeEffect();
            _defaultFont = darkTextBox_Email.Font;
            _stopwatch = new Stopwatch();
            this.Size = new Size(575, 343);
            linkLabel1_Descript.Text = "양식에 맞춰 입력을 해주세요.";
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
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
                var dialogResult = MessageBox.Show("회원가입을 취소하고 돌아가시겠습니까?", "시스템", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await _fadeEffect.FormFadeOutAsync(this);
                    this.Close();
                }
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
                primeButton_EmailConfirm.Focus();
                linkLabel1_Descript.Text = "이메일 인증을 진행해 주세요.";
            }
            else
            {
                darkTextBox_Email.Alignment = HorizontalAlignment.Left;
                darkTextBox_Email.Font = new Font(_defaultFont, FontStyle.Regular);
                darkTextBox_Email.ForeColor = Colors.DarkTextBoxForeColor;
                linkLabel1_Descript.Text = "유효한 이메일 주소를 입력해 주세요.";

                if (panel_EmailValidation.Visible)
                {
                    panel_EmailValidation.Visible = false;
                    this.Height = this.Height - 45;
                }
            }
        }

        private void primeButton_Submit_Click(object sender, EventArgs e)
        {
            if (!_isEmailCertified)
            {
                linkLabel1_Descript.Text = "이메일 인증을 진행해 주세요.";
                return;
            }

            if (!_isPasswordValid)
            {
                linkLabel1_Descript.Text = "비밀번호 및 재확인을 진행해 주세요.";
                return;
            }

            if (!_isUserNameValid)
            {
                linkLabel1_Descript.Text = "고객명을 입력해 주세요.";
                return;
            }

            if (!_isPhoneValid)
            {
                linkLabel1_Descript.Text = "휴대폰 번호를 입력해 주세요.";
                return;
            }

            darkTextBox_Email.Enabled = false;
            darkTextBox_Password.Enabled = false;
            darkTextBox_ConfirmPassword.Enabled = false;
            darkTextBox_UserName.Enabled = false;
            darkTextBox_Phone.Enabled = false;
            darkTextBox_Recommender.Enabled = false;

            primeButton_Submit.Enabled = false;
            button_Return.Enabled = false;
            Console.WriteLine("회원가입 패킷 전송");
        }

        private void primeButton_EmailConfirm_Click(object sender, EventArgs e)
        {
            if (_isSent)
            {
                linkLabel1_Descript.Text = "지금은 인증코드를 재발송 할 수 없습니다.";
                return;
            }

            _isSent = true;

            darkTextBox_Email.Enabled = false;

            Random rand = new Random();
            _masterCode = rand.Next(100000, 999999);
            darkTextBox_EmailConfirmCode.PlaceholderText = "인증 코드를 입력하세요.";
            Console.WriteLine(_masterCode);

            InterfaceTimer.Start();
            _stopwatch.Start();

            linkLabel1_Descript.Text = "인증 코드를 발송했습니다. 확인 후 입력해 주세요.";
            this.ActiveControl = darkTextBox_EmailConfirmCode;
        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            if (_isSent)
            {
                if (_isEmailCertified)
                {
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
                linkLabel1_Descript.Text = "이메일 인증을 진행해 주세요.";
                primeButton_EmailConfirm.Focus();
            }
            else
            {
                linkLabel1_Descript.Text = "해당 이메일로 발송된 인증 코드를 입력해 주세요.";
            }
        }

        private void darkTextBox_EmailConfirmCode_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_EmailConfirmCode.Texts.Length == 6)
            {
                if (darkTextBox_EmailConfirmCode.Texts == _masterCode.ToString())
                {
                    panel_EmailValidation.Enabled = false;
                    _isEmailCertified = true;
                    primeButton_EmailConfirm.Text = "인증 완료";
                    darkTextBox_EmailConfirmCode.Enabled = false;
                    primeButton_EmailConfirm.BackColor = Color.Green;

                    panel_EmailValidation.Visible = false;
                    this.Height = this.Height - 45;
                    this.ActiveControl = darkTextBox_Password;
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

                    if (darkTextBox_UserName.Texts.Length == 0)
                    {
                        darkTextBox_UserName.Focus();
                        _isPasswordValid = true;
                    }
                }
            }
            else
            {
                darkTextBox_Password.Alignment = HorizontalAlignment.Left;
                darkTextBox_ConfirmPassword.Alignment = HorizontalAlignment.Left;
                _isPasswordValid = false;
            }
        }

        private void darkTextBox_Email_Enter(object sender, EventArgs e)
        {
            if (darkTextBox_Email.Texts.Length == 0)
            {
                linkLabel1_Descript.Text = "유효한 이메일 주소를 입력해 주세요.";
                return;
            }
        }

        private void darkTextBox_Password_Enter(object sender, EventArgs e)
        {
            linkLabel1_Descript.Text = "공백 제외 6자리 이상의 비밀번호를 입력해 주세요.";
        }

        private void darkTextBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (darkTextBox_Password.Texts.Length > 0)
            {
                if (darkTextBox_Password.Texts == darkTextBox_ConfirmPassword.Texts)
                {
                    linkLabel1_Descript.Text = "비밀번호 재확인 검증 완료 상태입니다.";
                }
                else
                {
                    linkLabel1_Descript.Text = "확인을 위해 비밀번호 재 입력해 주세요.";
                }
            }
            else
            {
                linkLabel1_Descript.Text = "비밀번호 재확인 입력란입니다.";
            }
        }

        private void darkTextBox_UserName_Enter(object sender, EventArgs e)
        {
            linkLabel1_Descript.Text = "성함을 입력해 주세요.";
        }

        private void darkTextBox_Phone_Enter(object sender, EventArgs e)
        {
            if (_isPhoneValid)
            {
                linkLabel1_Descript.Text = "휴대폰 번호 입력 완료 상태입니다.";
                darkTextBox_Phone.Alignment = HorizontalAlignment.Center;
            }
            else
            {
                linkLabel1_Descript.Text = "유효한 휴대폰 번호를 입력해 주세요.";
                darkTextBox_Phone.Alignment = HorizontalAlignment.Left;
            }
        }

        private void darkTextBox_Recommender_Enter(object sender, EventArgs e)
        {
            linkLabel1_Descript.Text = "추천인을 입력해 주세요.";
        }

        private void darkTextBox_UserName_Leave(object sender, EventArgs e)
        {
            if (darkTextBox_UserName.Texts.Length >= 2)
            {
                darkTextBox_UserName.Alignment = HorizontalAlignment.Center;
                _isUserNameValid = true;
                if (darkTextBox_Phone.Texts.Length == 0)
                {
                    this.ActiveControl = darkTextBox_Phone;
                }
            }
            else
            {
                _isUserNameValid = false;
            }
        }

        private void darkTextBox_Phone_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_Phone.Texts.Length == 11)
            {
                if (Int32.TryParse(darkTextBox_Phone.Texts.Substring(0, 3), out int identifyingNumber))
                {
                    if (identifyingNumber == 010)
                    {
                        _isPhoneValid = true;
                        linkLabel1_Descript.Text = "휴대폰 번호 입력 완료 상태입니다.";
                        darkTextBox_Phone.Alignment = HorizontalAlignment.Center;
                        darkTextBox_Recommender.Focus();
                        return;
                    }
                }
            }

            _isPhoneValid = false;
            linkLabel1_Descript.Text = "유효한 휴대폰 번호를 입력해 주세요.";
            darkTextBox_Phone.Alignment = HorizontalAlignment.Left;
        }

        private void darkTextBox_Phone_KeyDownEvent(object sender, KeyEventArgs e)
        {
            bool isDigitKey = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                              (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isBackspaceOrDelete = e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete;
            bool isUtilKeys = e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Home || e.KeyCode == Keys.End;


            int currentLength = darkTextBox_Phone.Texts.Length;
            int limitLength = 11;

            if (!isDigitKey && !isBackspaceOrDelete && !isUtilKeys)
            {
                e.SuppressKeyPress = true;
                return;
            }

            if (currentLength >= limitLength)
            {
                if (isDigitKey)
                {
                    e.SuppressKeyPress = true;
                    return;
                }
            }
        }

        private void darkTextBox_UserName_TextChangedEvent(object sender, EventArgs e)
        {
            if (darkTextBox_UserName.Texts.Length >= 2)
            {
                _isUserNameValid = true;
            }
            else
            {
                _isUserNameValid = false;
            }
        }
    }
}
