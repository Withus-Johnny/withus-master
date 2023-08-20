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
            this.pictureBox_Brand = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_CaptionBar = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_Blank1 = new System.Windows.Forms.Panel();
            this.panel_Blank2 = new System.Windows.Forms.Panel();
            this.darkTextBox_Password = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox_Email = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.trayButton = new WithusUI.Controls.Buttons.TrayButton.CaptionControlButton();
            this.closeButton = new WithusUI.Controls.Buttons.TrayButton.CaptionControlButton();
            this.panel_Container.SuspendLayout();
            this.panel_ClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Brand)).BeginInit();
            this.panel_CaptionBar.SuspendLayout();
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
            this.panel_ClientArea.Controls.Add(this.darkTextBox_Password);
            this.panel_ClientArea.Controls.Add(this.panel_Blank2);
            this.panel_ClientArea.Controls.Add(this.darkTextBox_Email);
            this.panel_ClientArea.Controls.Add(this.panel_Blank1);
            this.panel_ClientArea.Controls.Add(this.pictureBox_Brand);
            this.panel_ClientArea.Controls.Add(this.panel1);
            this.panel_ClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClientArea.Location = new System.Drawing.Point(0, 25);
            this.panel_ClientArea.Name = "panel_ClientArea";
            this.panel_ClientArea.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel_ClientArea.Size = new System.Drawing.Size(338, 709);
            this.panel_ClientArea.TabIndex = 1;
            // 
            // pictureBox_Brand
            // 
            this.pictureBox_Brand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Brand.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Brand.Image")));
            this.pictureBox_Brand.Location = new System.Drawing.Point(10, 18);
            this.pictureBox_Brand.Name = "pictureBox_Brand";
            this.pictureBox_Brand.Size = new System.Drawing.Size(318, 152);
            this.pictureBox_Brand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Brand.TabIndex = 0;
            this.pictureBox_Brand.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 18);
            this.panel1.TabIndex = 1;
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
            // panel_Blank1
            // 
            this.panel_Blank1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Blank1.Location = new System.Drawing.Point(10, 170);
            this.panel_Blank1.Name = "panel_Blank1";
            this.panel_Blank1.Size = new System.Drawing.Size(318, 50);
            this.panel_Blank1.TabIndex = 0;
            this.panel_Blank1.TabStop = true;
            // 
            // panel_Blank2
            // 
            this.panel_Blank2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Blank2.Location = new System.Drawing.Point(10, 248);
            this.panel_Blank2.Name = "panel_Blank2";
            this.panel_Blank2.Size = new System.Drawing.Size(318, 21);
            this.panel_Blank2.TabIndex = 5;
            // 
            // darkTextBox_Password
            // 
            this.darkTextBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_Password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_Password.BorderRadius = 5;
            this.darkTextBox_Password.BorderSize = 1;
            this.darkTextBox_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkTextBox_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.darkTextBox_Password.Location = new System.Drawing.Point(10, 269);
            this.darkTextBox_Password.Multiline = false;
            this.darkTextBox_Password.Name = "darkTextBox_Password";
            this.darkTextBox_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.darkTextBox_Password.PasswordChar = true;
            this.darkTextBox_Password.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Password.PlaceholderText = "비밀번호";
            this.darkTextBox_Password.Size = new System.Drawing.Size(318, 28);
            this.darkTextBox_Password.TabIndex = 2;
            this.darkTextBox_Password.Tag = "PASSWORD";
            this.darkTextBox_Password.Texts = "";
            this.darkTextBox_Password.UnderlinedStyle = false;
            // 
            // darkTextBox_Email
            // 
            this.darkTextBox_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_Email.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_Email.BorderRadius = 5;
            this.darkTextBox_Email.BorderSize = 1;
            this.darkTextBox_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkTextBox_Email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.darkTextBox_Email.Location = new System.Drawing.Point(10, 220);
            this.darkTextBox_Email.Multiline = false;
            this.darkTextBox_Email.Name = "darkTextBox_Email";
            this.darkTextBox_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.darkTextBox_Email.PasswordChar = false;
            this.darkTextBox_Email.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Email.PlaceholderText = "이메일 주소";
            this.darkTextBox_Email.Size = new System.Drawing.Size(318, 28);
            this.darkTextBox_Email.TabIndex = 1;
            this.darkTextBox_Email.Tag = "EMAIL";
            this.darkTextBox_Email.Texts = "";
            this.darkTextBox_Email.UnderlinedStyle = false;
            // 
            // trayButton
            // 
            this.trayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.trayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trayButton.Location = new System.Drawing.Point(278, 0);
            this.trayButton.Name = "trayButton";
            this.trayButton.Size = new System.Drawing.Size(30, 25);
            this.trayButton.TabIndex = 1;
            this.trayButton.TabStop = false;
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
            this.closeButton.TabStop = false;
            this.closeButton.Text = "❌";
            this.closeButton.UseMnemonic = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Brand)).EndInit();
            this.panel_CaptionBar.ResumeLayout(false);
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
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_Password;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_Email;
        private System.Windows.Forms.Panel panel_Blank2;
        private System.Windows.Forms.Panel panel_Blank1;
    }
}