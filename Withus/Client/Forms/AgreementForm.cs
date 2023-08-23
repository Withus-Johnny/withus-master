using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Effects.FadeEffect;
using WithusUI.Forms;

namespace Client.Forms
{
    public partial class AgreementForm : WithusForm
    {
        IFadeEffect _fadeEffect;       

        public AgreementForm()
        {
            InitializeComponent();
            SubscribeToDragEventsForPanels(this);
            _fadeEffect = new FadeEffect();
        }

        private async void AgreementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            else
            {
                if (this.Opacity == 1)
                {
                    await _fadeEffect.FormFadeOutAsync(this);
                }

                if (_fadeEffect != null)
                {
                    _fadeEffect.Dispose();
                    _fadeEffect = null;
                }

                UnsubscribeFromDragEventsForPanels(this);
                Program.agreementForm = null;
                this.Dispose();
            }
        }

        private async void AgreementForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                await _fadeEffect.FormFadeOutAsync(this);
                this.Close();
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            AgreementForm_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }
    }
}
