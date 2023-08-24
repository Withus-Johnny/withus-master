using System;
using System.Drawing;
using System.Linq;
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


        public RegisterForm()
        {
            InitializeComponent();
            SubscribeToDragEventsForPanels(this);
            _fadeEffect = new FadeEffect();
            _defaultFont = darkTextBox_Email.Font;
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
                darkTextBox_Email.Font = new Font(DefaultFont, FontStyle.Regular);
                darkTextBox_Email.ForeColor = Colors.DarkTextBoxForeColor;
            }
        }

        private void darkTextBox_Email_Enter(object sender, EventArgs e)
        {
        }

        private void primeButton_Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Size);
        }
    }
}
