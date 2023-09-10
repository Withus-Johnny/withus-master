using Client.Networks;
using System;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Effects.FadeEffect;
using WithusUI.Forms;
using WithusUI.Helpers;
using C = ClientPackets;

namespace Client.Forms
{
    public partial class RegisterForm : WithusForm
    {
        private IFadeEffect _fadeEffect;
        private Font _defaultFont;

        private bool _isEmailValid = false;
        private bool _isPasswordValid = false;
        private bool _isUserNameValid = false;
        private bool _isPhoneValid = false;

        public RegisterForm()
        {
            InitializeComponent();
            SubscribeToDragEventsForPanels(this);
            _fadeEffect = new FadeEffect();
            _defaultFont = darkTextBox_Email.Font;
            this.Size = new Size(575, 343);
            linkLabel1_Descript.Text = "양식에 맞춰 입력을 해주세요.";
        }

        #region Control Events
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

        #endregion

        private void darkTextBox_Email_TextChangedEvent(object sender, EventArgs e)
        {
            if (EmailValidator.IsValidEmail(darkTextBox_Email.Texts))
            {
                darkTextBox_Email.Alignment = HorizontalAlignment.Center;
                darkTextBox_Email.Font = new Font(darkTextBox_Email.Font, FontStyle.Bold);
                darkTextBox_Email.ForeColor = Color.Gainsboro;
                _isEmailValid = true;
            }
            else
            {
                _isEmailValid = false;
                darkTextBox_Email.Alignment = HorizontalAlignment.Left;
                darkTextBox_Email.Font = new Font(_defaultFont, FontStyle.Regular);
                darkTextBox_Email.ForeColor = Colors.DarkTextBoxForeColor;
                linkLabel1_Descript.Text = "유효한 이메일 주소를 입력해 주세요.";
            }
        }



        private void primeButton_Submit_Click(object sender, EventArgs e)
        {
            if (!_isEmailValid)
            {
                linkLabel1_Descript.Text = "유효한 이메일 주소를 입력해 주세요.";
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

            primeButton_Submit.Enabled = false;
            button_Return.Enabled = false;

            Console.WriteLine("회원가입 패킷 전송");

            Network.Enqueue(new C.NewAccount()
            {
                UserEmail = darkTextBox_Email.Texts,
                UserPassword = darkTextBox_Password.Texts,
                UserName = darkTextBox_UserName.Texts,
                UserPhone = darkTextBox_Phone.Texts
            });
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
                    return;
                }
            }

            darkTextBox_Password.Alignment = HorizontalAlignment.Left;
            darkTextBox_ConfirmPassword.Alignment = HorizontalAlignment.Left;
            _isPasswordValid = false;
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
            linkLabel1_Descript.Text = "(선택) 추천인을 입력해 주세요.";
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

        private void darkTextBox_EmailConfirmCode_KeyDownEvent(object sender, KeyEventArgs e)
        {
            bool isDigitKey = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                              (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            if (!isDigitKey)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
