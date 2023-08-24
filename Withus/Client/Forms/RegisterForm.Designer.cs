﻿namespace Client.Forms
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
            this.button_Return = new System.Windows.Forms.Button();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.darkTextBox_Recommender = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox_Phone = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox_UserName = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox_ConfirmPassword = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox_Password = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.darkTextBox_Email = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.primeButton_Submit = new WithusUI.Controls.Buttons.PrimeButton.PrimeButton();
            this.panel_InputArea = new System.Windows.Forms.Panel();
            this.panel_InputEmail = new System.Windows.Forms.Panel();
            this.panel_EmailValidation = new System.Windows.Forms.Panel();
            this.panel_Password = new System.Windows.Forms.Panel();
            this.panel_ConfirmPassword = new System.Windows.Forms.Panel();
            this.panel_UserName = new System.Windows.Forms.Panel();
            this.panel_Phone = new System.Windows.Forms.Panel();
            this.darkTextBox_EmailConfirmCode = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.primeButton1 = new WithusUI.Controls.Buttons.PrimeButton.PrimeButton();
            this.panel_Recommender = new System.Windows.Forms.Panel();
            this.panel_Container.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            this.panel_InputArea.SuspendLayout();
            this.panel_InputEmail.SuspendLayout();
            this.panel_EmailValidation.SuspendLayout();
            this.panel_Password.SuspendLayout();
            this.panel_ConfirmPassword.SuspendLayout();
            this.panel_UserName.SuspendLayout();
            this.panel_Phone.SuspendLayout();
            this.panel_Recommender.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Return
            // 
            this.button_Return.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Return.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.button_Return.FlatAppearance.BorderSize = 0;
            this.button_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.button_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Return.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.button_Return.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Return.Location = new System.Drawing.Point(5, 5);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(32, 257);
            this.button_Return.TabIndex = 1;
            this.button_Return.Text = "<";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.panel_InputArea);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(37, 5);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(533, 201);
            this.panel_Container.TabIndex = 3;
            // 
            // darkTextBox_Recommender
            // 
            this.darkTextBox_Recommender.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox_Recommender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_Recommender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_Recommender.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_Recommender.BorderRadius = 4;
            this.darkTextBox_Recommender.BorderSize = 1;
            this.darkTextBox_Recommender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_Recommender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Recommender.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Recommender.Multiline = false;
            this.darkTextBox_Recommender.Name = "darkTextBox_Recommender";
            this.darkTextBox_Recommender.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Recommender.PasswordChar = false;
            this.darkTextBox_Recommender.PlaceholderText = "추천인";
            this.darkTextBox_Recommender.Size = new System.Drawing.Size(504, 28);
            this.darkTextBox_Recommender.TabIndex = 5;
            this.darkTextBox_Recommender.Texts = "";
            this.darkTextBox_Recommender.UnderlinedStyle = false;
            // 
            // darkTextBox_Phone
            // 
            this.darkTextBox_Phone.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_Phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_Phone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_Phone.BorderRadius = 4;
            this.darkTextBox_Phone.BorderSize = 1;
            this.darkTextBox_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Phone.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Phone.Multiline = false;
            this.darkTextBox_Phone.Name = "darkTextBox_Phone";
            this.darkTextBox_Phone.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Phone.PasswordChar = false;
            this.darkTextBox_Phone.PlaceholderText = "휴대폰 번호";
            this.darkTextBox_Phone.Size = new System.Drawing.Size(504, 28);
            this.darkTextBox_Phone.TabIndex = 4;
            this.darkTextBox_Phone.Texts = "";
            this.darkTextBox_Phone.UnderlinedStyle = false;
            // 
            // darkTextBox_UserName
            // 
            this.darkTextBox_UserName.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_UserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_UserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_UserName.BorderRadius = 4;
            this.darkTextBox_UserName.BorderSize = 1;
            this.darkTextBox_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_UserName.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_UserName.Multiline = false;
            this.darkTextBox_UserName.Name = "darkTextBox_UserName";
            this.darkTextBox_UserName.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_UserName.PasswordChar = false;
            this.darkTextBox_UserName.PlaceholderText = "고객명";
            this.darkTextBox_UserName.Size = new System.Drawing.Size(504, 28);
            this.darkTextBox_UserName.TabIndex = 3;
            this.darkTextBox_UserName.Texts = "";
            this.darkTextBox_UserName.UnderlinedStyle = false;
            // 
            // darkTextBox_ConfirmPassword
            // 
            this.darkTextBox_ConfirmPassword.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox_ConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_ConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_ConfirmPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_ConfirmPassword.BorderRadius = 4;
            this.darkTextBox_ConfirmPassword.BorderSize = 1;
            this.darkTextBox_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_ConfirmPassword.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_ConfirmPassword.Multiline = false;
            this.darkTextBox_ConfirmPassword.Name = "darkTextBox_ConfirmPassword";
            this.darkTextBox_ConfirmPassword.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_ConfirmPassword.PasswordChar = true;
            this.darkTextBox_ConfirmPassword.PlaceholderText = "비밀번호 확인";
            this.darkTextBox_ConfirmPassword.Size = new System.Drawing.Size(504, 28);
            this.darkTextBox_ConfirmPassword.TabIndex = 2;
            this.darkTextBox_ConfirmPassword.Texts = "";
            this.darkTextBox_ConfirmPassword.UnderlinedStyle = false;
            // 
            // darkTextBox_Password
            // 
            this.darkTextBox_Password.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_Password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_Password.BorderRadius = 4;
            this.darkTextBox_Password.BorderSize = 1;
            this.darkTextBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Password.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Password.Multiline = false;
            this.darkTextBox_Password.Name = "darkTextBox_Password";
            this.darkTextBox_Password.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Password.PasswordChar = true;
            this.darkTextBox_Password.PlaceholderText = "비밀번호";
            this.darkTextBox_Password.Size = new System.Drawing.Size(504, 28);
            this.darkTextBox_Password.TabIndex = 1;
            this.darkTextBox_Password.Texts = "";
            this.darkTextBox_Password.UnderlinedStyle = false;
            // 
            // darkTextBox_Email
            // 
            this.darkTextBox_Email.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.darkTextBox_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_Email.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_Email.BorderRadius = 4;
            this.darkTextBox_Email.BorderSize = 1;
            this.darkTextBox_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkTextBox_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Email.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Email.Multiline = false;
            this.darkTextBox_Email.Name = "darkTextBox_Email";
            this.darkTextBox_Email.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Email.PasswordChar = false;
            this.darkTextBox_Email.PlaceholderText = "이메일 주소";
            this.darkTextBox_Email.Size = new System.Drawing.Size(504, 28);
            this.darkTextBox_Email.TabIndex = 0;
            this.darkTextBox_Email.Texts = "";
            this.darkTextBox_Email.UnderlinedStyle = false;
            this.darkTextBox_Email.TextChangedEvent += new System.EventHandler(this.darkTextBox_Email_TextChangedEvent);
            this.darkTextBox_Email.Enter += new System.EventHandler(this.darkTextBox_Email_Enter);
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.primeButton_Submit);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(37, 206);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.panel_Controls.Size = new System.Drawing.Size(533, 56);
            this.panel_Controls.TabIndex = 4;
            // 
            // primeButton_Submit
            // 
            this.primeButton_Submit.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.primeButton_Submit.AutoSize = true;
            this.primeButton_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.BorderRadius = 4;
            this.primeButton_Submit.BorderSize = 2;
            this.primeButton_Submit.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primeButton_Submit.FlatAppearance.BorderSize = 0;
            this.primeButton_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.primeButton_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeButton_Submit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.primeButton_Submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Submit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.primeButton_Submit.Location = new System.Drawing.Point(100, 10);
            this.primeButton_Submit.Name = "primeButton_Submit";
            this.primeButton_Submit.Size = new System.Drawing.Size(333, 36);
            this.primeButton_Submit.TabIndex = 6;
            this.primeButton_Submit.Text = "가입 신청";
            this.primeButton_Submit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Submit.UseVisualStyleBackColor = false;
            this.primeButton_Submit.Click += new System.EventHandler(this.primeButton_Submit_Click);
            // 
            // panel_InputArea
            // 
            this.panel_InputArea.Controls.Add(this.panel_Recommender);
            this.panel_InputArea.Controls.Add(this.panel_Phone);
            this.panel_InputArea.Controls.Add(this.panel_UserName);
            this.panel_InputArea.Controls.Add(this.panel_ConfirmPassword);
            this.panel_InputArea.Controls.Add(this.panel_Password);
            this.panel_InputArea.Controls.Add(this.panel_EmailValidation);
            this.panel_InputArea.Controls.Add(this.panel_InputEmail);
            this.panel_InputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_InputArea.Location = new System.Drawing.Point(0, 0);
            this.panel_InputArea.Name = "panel_InputArea";
            this.panel_InputArea.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.panel_InputArea.Size = new System.Drawing.Size(533, 201);
            this.panel_InputArea.TabIndex = 7;
            // 
            // panel_InputEmail
            // 
            this.panel_InputEmail.Controls.Add(this.darkTextBox_Email);
            this.panel_InputEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InputEmail.Location = new System.Drawing.Point(10, 10);
            this.panel_InputEmail.Name = "panel_InputEmail";
            this.panel_InputEmail.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_InputEmail.Size = new System.Drawing.Size(518, 39);
            this.panel_InputEmail.TabIndex = 0;
            // 
            // panel_EmailValidation
            // 
            this.panel_EmailValidation.Controls.Add(this.primeButton1);
            this.panel_EmailValidation.Controls.Add(this.darkTextBox_EmailConfirmCode);
            this.panel_EmailValidation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_EmailValidation.Location = new System.Drawing.Point(10, 49);
            this.panel_EmailValidation.Name = "panel_EmailValidation";
            this.panel_EmailValidation.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_EmailValidation.Size = new System.Drawing.Size(518, 42);
            this.panel_EmailValidation.TabIndex = 1;
            this.panel_EmailValidation.Visible = false;
            // 
            // panel_Password
            // 
            this.panel_Password.Controls.Add(this.darkTextBox_Password);
            this.panel_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Password.Location = new System.Drawing.Point(10, 91);
            this.panel_Password.Name = "panel_Password";
            this.panel_Password.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_Password.Size = new System.Drawing.Size(518, 39);
            this.panel_Password.TabIndex = 2;
            // 
            // panel_ConfirmPassword
            // 
            this.panel_ConfirmPassword.Controls.Add(this.darkTextBox_ConfirmPassword);
            this.panel_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ConfirmPassword.Location = new System.Drawing.Point(10, 130);
            this.panel_ConfirmPassword.Name = "panel_ConfirmPassword";
            this.panel_ConfirmPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_ConfirmPassword.Size = new System.Drawing.Size(518, 39);
            this.panel_ConfirmPassword.TabIndex = 3;
            this.panel_ConfirmPassword.Visible = false;
            // 
            // panel_UserName
            // 
            this.panel_UserName.Controls.Add(this.darkTextBox_UserName);
            this.panel_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UserName.Location = new System.Drawing.Point(10, 169);
            this.panel_UserName.Name = "panel_UserName";
            this.panel_UserName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_UserName.Size = new System.Drawing.Size(518, 39);
            this.panel_UserName.TabIndex = 4;
            // 
            // panel_Phone
            // 
            this.panel_Phone.Controls.Add(this.darkTextBox_Phone);
            this.panel_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Phone.Location = new System.Drawing.Point(10, 208);
            this.panel_Phone.Name = "panel_Phone";
            this.panel_Phone.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_Phone.Size = new System.Drawing.Size(518, 39);
            this.panel_Phone.TabIndex = 5;
            // 
            // darkTextBox_EmailConfirmCode
            // 
            this.darkTextBox_EmailConfirmCode.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.darkTextBox_EmailConfirmCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTextBox_EmailConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.darkTextBox_EmailConfirmCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.darkTextBox_EmailConfirmCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.darkTextBox_EmailConfirmCode.BorderRadius = 4;
            this.darkTextBox_EmailConfirmCode.BorderSize = 1;
            this.darkTextBox_EmailConfirmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_EmailConfirmCode.Location = new System.Drawing.Point(7, 7);
            this.darkTextBox_EmailConfirmCode.Multiline = false;
            this.darkTextBox_EmailConfirmCode.Name = "darkTextBox_EmailConfirmCode";
            this.darkTextBox_EmailConfirmCode.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_EmailConfirmCode.PasswordChar = false;
            this.darkTextBox_EmailConfirmCode.PlaceholderText = "인증코드";
            this.darkTextBox_EmailConfirmCode.Size = new System.Drawing.Size(390, 28);
            this.darkTextBox_EmailConfirmCode.TabIndex = 6;
            this.darkTextBox_EmailConfirmCode.Texts = "";
            this.darkTextBox_EmailConfirmCode.UnderlinedStyle = false;
            // 
            // primeButton1
            // 
            this.primeButton1.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.primeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton1.BorderRadius = 4;
            this.primeButton1.BorderSize = 2;
            this.primeButton1.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton1.FlatAppearance.BorderSize = 0;
            this.primeButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.primeButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeButton1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.primeButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.primeButton1.Location = new System.Drawing.Point(403, 7);
            this.primeButton1.Name = "primeButton1";
            this.primeButton1.Size = new System.Drawing.Size(107, 28);
            this.primeButton1.TabIndex = 7;
            this.primeButton1.Text = "이메일 인증";
            this.primeButton1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton1.UseVisualStyleBackColor = false;
            // 
            // panel_Recommender
            // 
            this.panel_Recommender.Controls.Add(this.darkTextBox_Recommender);
            this.panel_Recommender.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Recommender.Location = new System.Drawing.Point(10, 247);
            this.panel_Recommender.Name = "panel_Recommender";
            this.panel_Recommender.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_Recommender.Size = new System.Drawing.Size(518, 39);
            this.panel_Recommender.TabIndex = 6;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BorderSize = 1;
            this.ClientSize = new System.Drawing.Size(575, 267);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.button_Return);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.panel_Container.ResumeLayout(false);
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
            this.panel_InputArea.ResumeLayout(false);
            this.panel_InputEmail.ResumeLayout(false);
            this.panel_EmailValidation.ResumeLayout(false);
            this.panel_Password.ResumeLayout(false);
            this.panel_ConfirmPassword.ResumeLayout(false);
            this.panel_UserName.ResumeLayout(false);
            this.panel_Phone.ResumeLayout(false);
            this.panel_Recommender.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Panel panel_Controls;
        private WithusUI.Controls.Buttons.PrimeButton.PrimeButton primeButton_Submit;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_Password;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_Email;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_Recommender;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_Phone;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_UserName;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_ConfirmPassword;
        private System.Windows.Forms.Panel panel_InputArea;
        private System.Windows.Forms.Panel panel_InputEmail;
        private System.Windows.Forms.Panel panel_EmailValidation;
        private System.Windows.Forms.Panel panel_Password;
        private System.Windows.Forms.Panel panel_ConfirmPassword;
        private System.Windows.Forms.Panel panel_UserName;
        private System.Windows.Forms.Panel panel_Phone;
        private WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox darkTextBox_EmailConfirmCode;
        private WithusUI.Controls.Buttons.PrimeButton.PrimeButton primeButton1;
        private System.Windows.Forms.Panel panel_Recommender;
    }
}