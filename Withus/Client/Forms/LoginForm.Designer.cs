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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_ClientArea = new System.Windows.Forms.Panel();
            this.panel_CaptionBar = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox_Brand = new System.Windows.Forms.PictureBox();
            this.trayButton = new WithusUI.Controls.Buttons.TrayButton.CaptionControlButton();
            this.closeButton = new WithusUI.Controls.Buttons.TrayButton.CaptionControlButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Container.SuspendLayout();
            this.panel_ClientArea.SuspendLayout();
            this.panel_CaptionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Brand)).BeginInit();
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
            this.panel_ClientArea.Controls.Add(this.pictureBox_Brand);
            this.panel_ClientArea.Controls.Add(this.panel1);
            this.panel_ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClientArea.Location = new System.Drawing.Point(0, 25);
            this.panel_ClientArea.Name = "panel_ClientArea";
            this.panel_ClientArea.Size = new System.Drawing.Size(338, 709);
            this.panel_ClientArea.TabIndex = 1;
            // 
            // panel_CaptionBar
            // 
            this.panel_CaptionBar.Controls.Add(this.trayButton);
            this.panel_CaptionBar.Controls.Add(this.closeButton);
            this.panel_CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_CaptionBar.Location = new System.Drawing.Point(0, 0);
            this.panel_CaptionBar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_CaptionBar.Name = "panel_CaptionBar";
            this.panel_CaptionBar.Size = new System.Drawing.Size(338, 25);
            this.panel_CaptionBar.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox_Brand
            // 
            this.pictureBox_Brand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Brand.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Brand.Image")));
            this.pictureBox_Brand.Location = new System.Drawing.Point(0, 18);
            this.pictureBox_Brand.Name = "pictureBox_Brand";
            this.pictureBox_Brand.Size = new System.Drawing.Size(338, 152);
            this.pictureBox_Brand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Brand.TabIndex = 0;
            this.pictureBox_Brand.TabStop = false;
            // 
            // trayButton
            // 
            this.trayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.trayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trayButton.Location = new System.Drawing.Point(278, 0);
            this.trayButton.Name = "trayButton";
            this.trayButton.Size = new System.Drawing.Size(30, 25);
            this.trayButton.TabIndex = 1;
            this.trayButton.Text = "─";
            this.trayButton.UseMnemonic = false;
            this.trayButton.UseVisualStyleBackColor = false;
            this.trayButton.Click += new System.EventHandler(this.trayButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.ButtonType = WithusUI.Controls.Buttons.CaptionControls.ButtonType.Close;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(308, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "❌";
            this.closeButton.UseMnemonic = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 18);
            this.panel1.TabIndex = 1;
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
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel_Container.ResumeLayout(false);
            this.panel_ClientArea.ResumeLayout(false);
            this.panel_CaptionBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Brand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Panel panel_CaptionBar;
        private System.Windows.Forms.Panel panel_ClientArea;
        private WithusUI.Controls.Buttons.TrayButton.CaptionControlButton trayButton;
        private WithusUI.Controls.Buttons.TrayButton.CaptionControlButton closeButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox_Brand;
        private System.Windows.Forms.Panel panel1;
    }
}