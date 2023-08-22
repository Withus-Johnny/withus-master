namespace Client.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel_Container = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_ControlContainer = new System.Windows.Forms.Panel();
            this.darkTextBox6 = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox5 = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox4 = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox3 = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox2 = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox1 = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.primeButton_Submit = new WithusUI.Controls.Buttons.PrimeButton.PrimeButton();
            this.checkBox_Agreement = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Container.SuspendLayout();
            this.panel_ControlContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.panel1);
            this.panel_Container.Controls.Add(this.panel_ControlContainer);
            this.panel_Container.Controls.Add(this.button_Return);
            this.panel_Container.Controls.Add(this.richTextBox1);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(734, 340);
            this.panel_Container.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(56, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(406, 281);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.button_Return.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Return.FlatAppearance.BorderSize = 0;
            this.button_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Return.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Return.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Return.Location = new System.Drawing.Point(0, 0);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(42, 340);
            this.button_Return.TabIndex = 7;
            this.button_Return.TabStop = false;
            this.button_Return.Text = "<";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // InterfaceTimer
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Interval = 50;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // panel_ControlContainer
            // 
            this.panel_ControlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ControlContainer.Controls.Add(this.darkTextBox6);
            this.panel_ControlContainer.Controls.Add(this.darkTextBox5);
            this.panel_ControlContainer.Controls.Add(this.darkTextBox4);
            this.panel_ControlContainer.Controls.Add(this.darkTextBox3);
            this.panel_ControlContainer.Controls.Add(this.darkTextBox2);
            this.panel_ControlContainer.Controls.Add(this.darkTextBox1);
            this.panel_ControlContainer.Controls.Add(this.primeButton_Submit);
            this.panel_ControlContainer.Enabled = false;
            this.panel_ControlContainer.Location = new System.Drawing.Point(468, 17);
            this.panel_ControlContainer.Name = "panel_ControlContainer";
            this.panel_ControlContainer.Size = new System.Drawing.Size(254, 289);
            this.panel_ControlContainer.TabIndex = 8;
            // 
            // darkTextBox6
            // 
            this.darkTextBox6.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox6.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox6.BorderRadius = 6;
            this.darkTextBox6.BorderSize = 2;
            this.darkTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox6.Location = new System.Drawing.Point(33, 195);
            this.darkTextBox6.Multiline = false;
            this.darkTextBox6.Name = "darkTextBox6";
            this.darkTextBox6.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox6.PasswordChar = false;
            this.darkTextBox6.PlaceholderText = "추천인";
            this.darkTextBox6.Size = new System.Drawing.Size(197, 28);
            this.darkTextBox6.TabIndex = 13;
            this.darkTextBox6.Texts = "";
            this.darkTextBox6.UnderlinedStyle = false;
            // 
            // darkTextBox5
            // 
            this.darkTextBox5.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox5.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox5.BorderRadius = 6;
            this.darkTextBox5.BorderSize = 2;
            this.darkTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox5.Location = new System.Drawing.Point(33, 156);
            this.darkTextBox5.Multiline = false;
            this.darkTextBox5.Name = "darkTextBox5";
            this.darkTextBox5.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox5.PasswordChar = false;
            this.darkTextBox5.PlaceholderText = "고객명";
            this.darkTextBox5.Size = new System.Drawing.Size(197, 28);
            this.darkTextBox5.TabIndex = 12;
            this.darkTextBox5.Texts = "";
            this.darkTextBox5.UnderlinedStyle = false;
            // 
            // darkTextBox4
            // 
            this.darkTextBox4.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox4.BorderRadius = 6;
            this.darkTextBox4.BorderSize = 2;
            this.darkTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox4.Location = new System.Drawing.Point(33, 122);
            this.darkTextBox4.Multiline = false;
            this.darkTextBox4.Name = "darkTextBox4";
            this.darkTextBox4.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox4.PasswordChar = false;
            this.darkTextBox4.PlaceholderText = "휴대폰 번호";
            this.darkTextBox4.Size = new System.Drawing.Size(197, 28);
            this.darkTextBox4.TabIndex = 11;
            this.darkTextBox4.Texts = "";
            this.darkTextBox4.UnderlinedStyle = false;
            // 
            // darkTextBox3
            // 
            this.darkTextBox3.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox3.BorderRadius = 6;
            this.darkTextBox3.BorderSize = 2;
            this.darkTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox3.Location = new System.Drawing.Point(33, 83);
            this.darkTextBox3.Multiline = false;
            this.darkTextBox3.Name = "darkTextBox3";
            this.darkTextBox3.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox3.PasswordChar = true;
            this.darkTextBox3.PlaceholderText = "비밀번호 확인";
            this.darkTextBox3.Size = new System.Drawing.Size(197, 28);
            this.darkTextBox3.TabIndex = 10;
            this.darkTextBox3.Texts = "";
            this.darkTextBox3.UnderlinedStyle = false;
            // 
            // darkTextBox2
            // 
            this.darkTextBox2.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox2.BorderRadius = 6;
            this.darkTextBox2.BorderSize = 2;
            this.darkTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox2.Location = new System.Drawing.Point(33, 49);
            this.darkTextBox2.Multiline = false;
            this.darkTextBox2.Name = "darkTextBox2";
            this.darkTextBox2.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox2.PasswordChar = true;
            this.darkTextBox2.PlaceholderText = "비밀 번호";
            this.darkTextBox2.Size = new System.Drawing.Size(197, 28);
            this.darkTextBox2.TabIndex = 9;
            this.darkTextBox2.Texts = "";
            this.darkTextBox2.UnderlinedStyle = false;
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox1.BorderRadius = 6;
            this.darkTextBox1.BorderSize = 2;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox1.Location = new System.Drawing.Point(33, 10);
            this.darkTextBox1.Multiline = false;
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox1.PasswordChar = false;
            this.darkTextBox1.PlaceholderText = "이메일 주소";
            this.darkTextBox1.Size = new System.Drawing.Size(197, 28);
            this.darkTextBox1.TabIndex = 8;
            this.darkTextBox1.Texts = "";
            this.darkTextBox1.UnderlinedStyle = false;
            // 
            // primeButton_Submit
            // 
            this.primeButton_Submit.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.primeButton_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.primeButton_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.BorderRadius = 6;
            this.primeButton_Submit.BorderSize = 2;
            this.primeButton_Submit.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.FlatAppearance.BorderSize = 0;
            this.primeButton_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.primeButton_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeButton_Submit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.primeButton_Submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Submit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.primeButton_Submit.Location = new System.Drawing.Point(33, 241);
            this.primeButton_Submit.Name = "primeButton_Submit";
            this.primeButton_Submit.Size = new System.Drawing.Size(197, 40);
            this.primeButton_Submit.TabIndex = 14;
            this.primeButton_Submit.Text = "가입 신청";
            this.primeButton_Submit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Submit.UseVisualStyleBackColor = false;
            // 
            // checkBox_Agreement
            // 
            this.checkBox_Agreement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Agreement.AutoSize = true;
            this.checkBox_Agreement.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Agreement.Location = new System.Drawing.Point(294, 2);
            this.checkBox_Agreement.Name = "checkBox_Agreement";
            this.checkBox_Agreement.Size = new System.Drawing.Size(128, 16);
            this.checkBox_Agreement.TabIndex = 15;
            this.checkBox_Agreement.Text = "약관을 동의합니다.";
            this.checkBox_Agreement.UseVisualStyleBackColor = true;
            this.checkBox_Agreement.CheckedChanged += new System.EventHandler(this.checkBox_Agreement_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_Agreement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(42, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 28);
            this.panel1.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 340);
            this.Controls.Add(this.panel_Container);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel_Container.ResumeLayout(false);
            this.panel_ControlContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer InterfaceTimer;
        private System.Windows.Forms.Panel panel_ControlContainer;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox6;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox5;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox4;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox3;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox2;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox1;
        private WithusUI.Controls.Buttons.PrimeButton.PrimeButton primeButton_Submit;
        private System.Windows.Forms.CheckBox checkBox_Agreement;
        private System.Windows.Forms.Panel panel1;
    }
}