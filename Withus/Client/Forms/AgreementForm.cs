using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WithusUI.Effects.FadeEffect;
using WithusUI.Forms;
using WithusUI.Win32;
using WM = WithusUI.Win32.WindowMessage;

namespace Client.Forms
{
    public partial class AgreementForm : WithusForm
    {
        IFadeEffect _fadeEffect;

        public AgreementForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;

            SubscribeToDragEventsForPanels(this);

            _fadeEffect = new FadeEffect();
        }

        private void AgreementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _fadeEffect.Dispose();
            _fadeEffect = null;
            UnsubscribeFromDragEventsForPanels(this);            
            richTextBox1.Visible = false;
            richTextBox1.Clear();
            richTextBox1.Dispose();
            this.Dispose();
        }

        private void AgreementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((ModifierKeys & Keys.Alt) != 0 && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                return;
            }
        }

        private async void button_Return_Click(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                await _fadeEffect.FormFadeOutAsync(this);
                this.Close();
            }
        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            Native.SCROLLINFO scrollInfo = new Native.SCROLLINFO
            {
                cbSize = (uint)Marshal.SizeOf(typeof(Native.SCROLLINFO)),
                fMask = WM.SIF_ALL
            };

            Native.GetScrollInfo(richTextBox1.Handle, WM.SB_VERT, ref scrollInfo);

            bool isAtBottom = scrollInfo.nPos + scrollInfo.nPage >= scrollInfo.nMax;

            if (isAtBottom)
            {
                if (!panel_Controls.Visible)
                {
                    panel_Controls.Visible = true;
                    InterfaceTimer.Stop();
                    InterfaceTimer.Dispose();
                }
            }
        }

        private void checkBox_Agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Agreement.Checked)
            {
                if (!panel_Controls.Visible)
                {
                    panel_Controls.Visible = true;
                }

                primeButton_Next.Enabled = true;
            }
            else
            {
                primeButton_Next.Enabled = false;
            }
        }
        private async void primeButton_Next_Click(object sender, EventArgs e)
        {
            await _fadeEffect.FormFadeOutAsync(this);
            this.Close();

            Program.loginForm.BeginInvoke(new Action(() => {
                Program.loginForm.InitializeRegisterForm();
            }));
        }
    }
}
