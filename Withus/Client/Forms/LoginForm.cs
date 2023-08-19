using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace Client.Forms
{
    public partial class LoginForm : Form
    {
        #region Constructor
        public LoginForm()
        {
            InitializeComponent();
            this.Size = new Size(364, 783);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
        }
        #endregion

        #region Paint Region

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            var g = e.Graphics;

            using (var p = new Pen(Colors.FormBorderColor))
            {   
                var borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
                g.DrawRectangle(p, borderRect);
            }
        }

        #endregion
    }
}
