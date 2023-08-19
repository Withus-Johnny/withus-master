namespace Client.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_ClientArea = new System.Windows.Forms.Panel();
            this.panel_CaptionBar = new System.Windows.Forms.Panel();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.panel_ClientArea);
            this.panel_Container.Controls.Add(this.panel_CaptionBar);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(5, 5);
            this.panel_Container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(338, 734);
            this.panel_Container.TabIndex = 0;
            // 
            // panel_ClientArea
            // 
            this.panel_ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClientArea.Location = new System.Drawing.Point(0, 25);
            this.panel_ClientArea.Name = "panel_ClientArea";
            this.panel_ClientArea.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel_ClientArea.Size = new System.Drawing.Size(338, 709);
            this.panel_ClientArea.TabIndex = 1;
            // 
            // panel_CaptionBar
            // 
            this.panel_CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_CaptionBar.Location = new System.Drawing.Point(0, 0);
            this.panel_CaptionBar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_CaptionBar.Name = "panel_CaptionBar";
            this.panel_CaptionBar.Size = new System.Drawing.Size(338, 25);
            this.panel_CaptionBar.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(348, 744);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.panel_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Panel panel_CaptionBar;
        private System.Windows.Forms.Panel panel_ClientArea;
    }
}