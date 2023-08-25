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
            this.button_Return = new System.Windows.Forms.Button();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_InputArea = new System.Windows.Forms.Panel();
            this.panel_Recommender = new System.Windows.Forms.Panel();
            this.darkTextBox_Recommender = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_Phone = new System.Windows.Forms.Panel();
            this.darkTextBox_Phone = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_UserName = new System.Windows.Forms.Panel();
            this.darkTextBox_UserName = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_ConfirmPassword = new System.Windows.Forms.Panel();
            this.darkTextBox_ConfirmPassword = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_Password = new System.Windows.Forms.Panel();
            this.darkTextBox_Password = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_EmailValidation = new System.Windows.Forms.Panel();
            this.primeButton_EmailConfirm = new WithusUI.Controls.Buttons.PrimeButton.PrimeButton();
            this.darkTextBox_EmailConfirmCode = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_InputEmail = new System.Windows.Forms.Panel();
            this.darkTextBox_Email = new WithusUI.Controls.TextBoxs.DarkTextBox.DarkTextBox();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.linkLabel1_Descript = new WithusUI.Controls.Labels.LinkLabel();
            this.primeButton_Submit = new WithusUI.Controls.Buttons.PrimeButton.PrimeButton();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_Container.SuspendLayout();
            this.panel_InputArea.SuspendLayout();
            this.panel_Recommender.SuspendLayout();
            this.panel_Phone.SuspendLayout();
            this.panel_UserName.SuspendLayout();
            this.panel_ConfirmPassword.SuspendLayout();
            this.panel_Password.SuspendLayout();
            this.panel_EmailValidation.SuspendLayout();
            this.panel_InputEmail.SuspendLayout();
            this.panel_Controls.SuspendLayout();
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
            this.button_Return.Size = new System.Drawing.Size(32, 406);
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
            this.panel_Container.Size = new System.Drawing.Size(533, 350);
            this.panel_Container.TabIndex = 3;
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
            this.panel_InputArea.Size = new System.Drawing.Size(533, 350);
            this.panel_InputArea.TabIndex = 7;
            // 
            // panel_Recommender
            // 
            this.panel_Recommender.Controls.Add(this.darkTextBox_Recommender);
            this.panel_Recommender.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Recommender.Location = new System.Drawing.Point(10, 280);
            this.panel_Recommender.Name = "panel_Recommender";
            this.panel_Recommender.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_Recommender.Size = new System.Drawing.Size(518, 45);
            this.panel_Recommender.TabIndex = 6;
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
            this.darkTextBox_Recommender.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_Recommender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Recommender.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Recommender.Multiline = false;
            this.darkTextBox_Recommender.Name = "darkTextBox_Recommender";
            this.darkTextBox_Recommender.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Recommender.PasswordChar = false;
            this.darkTextBox_Recommender.PlaceholderText = "추천인";
            this.darkTextBox_Recommender.Size = new System.Drawing.Size(504, 33);
            this.darkTextBox_Recommender.TabIndex = 5;
            this.darkTextBox_Recommender.Texts = "";
            this.darkTextBox_Recommender.UnderlinedStyle = false;
            this.darkTextBox_Recommender.Enter += new System.EventHandler(this.darkTextBox_Recommender_Enter);
            // 
            // panel_Phone
            // 
            this.panel_Phone.Controls.Add(this.darkTextBox_Phone);
            this.panel_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Phone.Location = new System.Drawing.Point(10, 235);
            this.panel_Phone.Name = "panel_Phone";
            this.panel_Phone.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_Phone.Size = new System.Drawing.Size(518, 45);
            this.panel_Phone.TabIndex = 5;
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
            this.darkTextBox_Phone.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Phone.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Phone.Multiline = false;
            this.darkTextBox_Phone.Name = "darkTextBox_Phone";
            this.darkTextBox_Phone.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Phone.PasswordChar = false;
            this.darkTextBox_Phone.PlaceholderText = "휴대폰 번호";
            this.darkTextBox_Phone.Size = new System.Drawing.Size(504, 33);
            this.darkTextBox_Phone.TabIndex = 4;
            this.darkTextBox_Phone.Texts = "";
            this.darkTextBox_Phone.UnderlinedStyle = false;
            this.darkTextBox_Phone.TextChangedEvent += new System.EventHandler(this.darkTextBox_Phone_TextChangedEvent);
            this.darkTextBox_Phone.KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.darkTextBox_Phone_KeyDownEvent);
            this.darkTextBox_Phone.Enter += new System.EventHandler(this.darkTextBox_Phone_Enter);
            // 
            // panel_UserName
            // 
            this.panel_UserName.Controls.Add(this.darkTextBox_UserName);
            this.panel_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UserName.Location = new System.Drawing.Point(10, 190);
            this.panel_UserName.Name = "panel_UserName";
            this.panel_UserName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_UserName.Size = new System.Drawing.Size(518, 45);
            this.panel_UserName.TabIndex = 4;
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
            this.darkTextBox_UserName.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_UserName.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_UserName.Multiline = false;
            this.darkTextBox_UserName.Name = "darkTextBox_UserName";
            this.darkTextBox_UserName.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_UserName.PasswordChar = false;
            this.darkTextBox_UserName.PlaceholderText = "고객명";
            this.darkTextBox_UserName.Size = new System.Drawing.Size(504, 33);
            this.darkTextBox_UserName.TabIndex = 3;
            this.darkTextBox_UserName.Texts = "";
            this.darkTextBox_UserName.UnderlinedStyle = false;
            this.darkTextBox_UserName.TextChangedEvent += new System.EventHandler(this.darkTextBox_UserName_TextChangedEvent);
            this.darkTextBox_UserName.Enter += new System.EventHandler(this.darkTextBox_UserName_Enter);
            this.darkTextBox_UserName.Leave += new System.EventHandler(this.darkTextBox_UserName_Leave);
            // 
            // panel_ConfirmPassword
            // 
            this.panel_ConfirmPassword.Controls.Add(this.darkTextBox_ConfirmPassword);
            this.panel_ConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ConfirmPassword.Location = new System.Drawing.Point(10, 145);
            this.panel_ConfirmPassword.Name = "panel_ConfirmPassword";
            this.panel_ConfirmPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_ConfirmPassword.Size = new System.Drawing.Size(518, 45);
            this.panel_ConfirmPassword.TabIndex = 3;
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
            this.darkTextBox_ConfirmPassword.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_ConfirmPassword.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_ConfirmPassword.Multiline = false;
            this.darkTextBox_ConfirmPassword.Name = "darkTextBox_ConfirmPassword";
            this.darkTextBox_ConfirmPassword.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_ConfirmPassword.PasswordChar = true;
            this.darkTextBox_ConfirmPassword.PlaceholderText = "비밀번호 확인";
            this.darkTextBox_ConfirmPassword.Size = new System.Drawing.Size(504, 33);
            this.darkTextBox_ConfirmPassword.TabIndex = 2;
            this.darkTextBox_ConfirmPassword.Texts = "";
            this.darkTextBox_ConfirmPassword.UnderlinedStyle = false;
            this.darkTextBox_ConfirmPassword.TextChangedEvent += new System.EventHandler(this.InputPassword_TextChangedEvent);
            this.darkTextBox_ConfirmPassword.Enter += new System.EventHandler(this.darkTextBox_ConfirmPassword_Enter);
            // 
            // panel_Password
            // 
            this.panel_Password.Controls.Add(this.darkTextBox_Password);
            this.panel_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Password.Location = new System.Drawing.Point(10, 100);
            this.panel_Password.Name = "panel_Password";
            this.panel_Password.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_Password.Size = new System.Drawing.Size(518, 45);
            this.panel_Password.TabIndex = 2;
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
            this.darkTextBox_Password.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Password.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Password.Multiline = false;
            this.darkTextBox_Password.Name = "darkTextBox_Password";
            this.darkTextBox_Password.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Password.PasswordChar = true;
            this.darkTextBox_Password.PlaceholderText = "비밀번호";
            this.darkTextBox_Password.Size = new System.Drawing.Size(504, 33);
            this.darkTextBox_Password.TabIndex = 1;
            this.darkTextBox_Password.Texts = "";
            this.darkTextBox_Password.UnderlinedStyle = false;
            this.darkTextBox_Password.TextChangedEvent += new System.EventHandler(this.InputPassword_TextChangedEvent);
            this.darkTextBox_Password.Enter += new System.EventHandler(this.darkTextBox_Password_Enter);
            // 
            // panel_EmailValidation
            // 
            this.panel_EmailValidation.Controls.Add(this.primeButton_EmailConfirm);
            this.panel_EmailValidation.Controls.Add(this.darkTextBox_EmailConfirmCode);
            this.panel_EmailValidation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_EmailValidation.Location = new System.Drawing.Point(10, 55);
            this.panel_EmailValidation.Name = "panel_EmailValidation";
            this.panel_EmailValidation.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_EmailValidation.Size = new System.Drawing.Size(518, 45);
            this.panel_EmailValidation.TabIndex = 1;
            this.panel_EmailValidation.Visible = false;
            // 
            // primeButton_EmailConfirm
            // 
            this.primeButton_EmailConfirm.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.primeButton_EmailConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primeButton_EmailConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_EmailConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_EmailConfirm.BorderRadius = 4;
            this.primeButton_EmailConfirm.BorderSize = 2;
            this.primeButton_EmailConfirm.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_EmailConfirm.FlatAppearance.BorderSize = 0;
            this.primeButton_EmailConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.primeButton_EmailConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_EmailConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeButton_EmailConfirm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.primeButton_EmailConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_EmailConfirm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.primeButton_EmailConfirm.Location = new System.Drawing.Point(403, 7);
            this.primeButton_EmailConfirm.Name = "primeButton_EmailConfirm";
            this.primeButton_EmailConfirm.Size = new System.Drawing.Size(107, 31);
            this.primeButton_EmailConfirm.TabIndex = 7;
            this.primeButton_EmailConfirm.Text = "이메일 인증";
            this.primeButton_EmailConfirm.TextColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_EmailConfirm.UseVisualStyleBackColor = false;
            this.primeButton_EmailConfirm.Click += new System.EventHandler(this.primeButton_EmailConfirm_Click);
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
            this.darkTextBox_EmailConfirmCode.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_EmailConfirmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_EmailConfirmCode.Location = new System.Drawing.Point(7, 6);
            this.darkTextBox_EmailConfirmCode.Multiline = false;
            this.darkTextBox_EmailConfirmCode.Name = "darkTextBox_EmailConfirmCode";
            this.darkTextBox_EmailConfirmCode.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_EmailConfirmCode.PasswordChar = false;
            this.darkTextBox_EmailConfirmCode.PlaceholderText = "이메일 인증 버튼을 눌러주세요.";
            this.darkTextBox_EmailConfirmCode.Size = new System.Drawing.Size(390, 33);
            this.darkTextBox_EmailConfirmCode.TabIndex = 6;
            this.darkTextBox_EmailConfirmCode.Texts = "";
            this.darkTextBox_EmailConfirmCode.UnderlinedStyle = false;
            this.darkTextBox_EmailConfirmCode.TextChangedEvent += new System.EventHandler(this.darkTextBox_EmailConfirmCode_TextChangedEvent);
            this.darkTextBox_EmailConfirmCode.Enter += new System.EventHandler(this.darkTextBox_EmailConfirmCode_Enter);
            // 
            // panel_InputEmail
            // 
            this.panel_InputEmail.Controls.Add(this.darkTextBox_Email);
            this.panel_InputEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InputEmail.Location = new System.Drawing.Point(10, 10);
            this.panel_InputEmail.Name = "panel_InputEmail";
            this.panel_InputEmail.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel_InputEmail.Size = new System.Drawing.Size(518, 45);
            this.panel_InputEmail.TabIndex = 0;
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
            this.darkTextBox_Email.Font = new System.Drawing.Font("굴림", 12F);
            this.darkTextBox_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.darkTextBox_Email.Location = new System.Drawing.Point(7, 5);
            this.darkTextBox_Email.Multiline = false;
            this.darkTextBox_Email.Name = "darkTextBox_Email";
            this.darkTextBox_Email.Padding = new System.Windows.Forms.Padding(14, 7, 10, 7);
            this.darkTextBox_Email.PasswordChar = false;
            this.darkTextBox_Email.PlaceholderText = "이메일 주소";
            this.darkTextBox_Email.Size = new System.Drawing.Size(504, 33);
            this.darkTextBox_Email.TabIndex = 0;
            this.darkTextBox_Email.Texts = "";
            this.darkTextBox_Email.UnderlinedStyle = false;
            this.darkTextBox_Email.TextChangedEvent += new System.EventHandler(this.darkTextBox_Email_TextChangedEvent);
            this.darkTextBox_Email.Enter += new System.EventHandler(this.darkTextBox_Email_Enter);
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.linkLabel1_Descript);
            this.panel_Controls.Controls.Add(this.primeButton_Submit);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(37, 355);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(533, 56);
            this.panel_Controls.TabIndex = 4;
            // 
            // linkLabel1_Descript
            // 
            this.linkLabel1_Descript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1_Descript.AutoSize = true;
            this.linkLabel1_Descript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1_Descript.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.linkLabel1_Descript.ForeColor = System.Drawing.Color.Tomato;
            this.linkLabel1_Descript.Location = new System.Drawing.Point(17, 17);
            this.linkLabel1_Descript.Name = "linkLabel1_Descript";
            this.linkLabel1_Descript.Size = new System.Drawing.Size(15, 19);
            this.linkLabel1_Descript.TabIndex = 7;
            this.linkLabel1_Descript.Text = "-";
            // 
            // primeButton_Submit
            // 
            this.primeButton_Submit.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.primeButton_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.primeButton_Submit.AutoSize = true;
            this.primeButton_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.BorderRadius = 4;
            this.primeButton_Submit.BorderSize = 2;
            this.primeButton_Submit.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.FlatAppearance.BorderSize = 0;
            this.primeButton_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.primeButton_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeButton_Submit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.primeButton_Submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Submit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.primeButton_Submit.Location = new System.Drawing.Point(398, 10);
            this.primeButton_Submit.Name = "primeButton_Submit";
            this.primeButton_Submit.Size = new System.Drawing.Size(122, 36);
            this.primeButton_Submit.TabIndex = 6;
            this.primeButton_Submit.Text = "가입 신청";
            this.primeButton_Submit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Submit.UseVisualStyleBackColor = false;
            this.primeButton_Submit.Click += new System.EventHandler(this.primeButton_Submit_Click);
            // 
            // InterfaceTimer
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Interval = 1000;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BorderSize = 1;
            this.ClientSize = new System.Drawing.Size(575, 416);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.button_Return);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.panel_Container.ResumeLayout(false);
            this.panel_InputArea.ResumeLayout(false);
            this.panel_Recommender.ResumeLayout(false);
            this.panel_Phone.ResumeLayout(false);
            this.panel_UserName.ResumeLayout(false);
            this.panel_ConfirmPassword.ResumeLayout(false);
            this.panel_Password.ResumeLayout(false);
            this.panel_EmailValidation.ResumeLayout(false);
            this.panel_InputEmail.ResumeLayout(false);
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
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
        private WithusUI.Controls.Buttons.PrimeButton.PrimeButton primeButton_EmailConfirm;
        private System.Windows.Forms.Panel panel_Recommender;
        private System.Windows.Forms.Timer InterfaceTimer;
        private WithusUI.Controls.Labels.LinkLabel linkLabel1_Descript;
    }
}