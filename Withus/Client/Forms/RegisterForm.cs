using System.Windows.Forms;
using WithusUI.Effects.FadeEffect;
using WithusUI.Forms;

namespace Client.Forms
{
    public partial class RegisterForm : WithusForm
    {
        IFadeEffect _fadeEffect;
        public RegisterForm()
        {
            InitializeComponent();
            SubscribeToDragEventsForPanels(this);
            _fadeEffect = new FadeEffect();
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

        private async void button_Return_Click(object sender, System.EventArgs e)
        {
            if (IsLoaded)
            {
                await _fadeEffect.FormFadeOutAsync(this);
                this.Close();

                Program.loginForm.InitializeAgreementForm();
            }
        }
    }
}
