using System;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;

namespace WithusUI.Controls.Labels
{
    public class LinkLabel : Label
    {
        private bool _isHover;
        private bool _isActive;

        public LinkLabel()
        {
            this.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
            this.ForeColor = Colors.ServiceLabelForeColor;

            this.MouseDown += LinkLabel_MouseDown;
            this.MouseUp += LinkLabel_MouseUp;
            this.MouseLeave += LinkLabel_MouseLeave;
        }

        private void LinkLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ForeColor = Colors.ServiceLabelForeColor;
            }
        }

        private void LinkLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isActive = true;
                this.ForeColor = Colors.ServiceLabelActiveColor;
            }
        }

        private void LinkLabel_MouseLeave(object sender, EventArgs e)
        {
            if (_isHover)
            {
                _isHover = false;
                _isActive = false;
                this.ForeColor = Colors.ServiceLabelForeColor;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.None)
            {
                if (this.ClientRectangle.Contains(e.Location))
                {
                    if (!_isHover && !_isActive)
                    {
                        _isHover = true;
                        this.ForeColor = Colors.ServiceLabelHoverForeColor;
                    }
                }
            }
        }
    }
}
