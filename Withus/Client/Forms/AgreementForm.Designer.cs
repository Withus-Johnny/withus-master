namespace Client.Forms
{
    partial class AgreementForm
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
            this.checkBox_Agreement = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.primeButton_Next = new WithusUI.Controls.Buttons.PrimeButton.PrimeButton();
            this.panel_Container.SuspendLayout();
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
            this.button_Return.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.button_Return.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Return.Location = new System.Drawing.Point(5, 5);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(51, 448);
            this.button_Return.TabIndex = 0;
            this.button_Return.Text = "<";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.checkBox_Agreement);
            this.panel_Container.Controls.Add(this.richTextBox1);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(56, 5);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(583, 396);
            this.panel_Container.TabIndex = 1;
            // 
            // checkBox_Agreement
            // 
            this.checkBox_Agreement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Agreement.AutoSize = true;
            this.checkBox_Agreement.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_Agreement.Location = new System.Drawing.Point(435, 376);
            this.checkBox_Agreement.Name = "checkBox_Agreement";
            this.checkBox_Agreement.Size = new System.Drawing.Size(140, 16);
            this.checkBox_Agreement.TabIndex = 6;
            this.checkBox_Agreement.Text = "서비스 이용약관 동의";
            this.checkBox_Agreement.UseVisualStyleBackColor = true;
            this.checkBox_Agreement.CheckedChanged += new System.EventHandler(this.checkBox_Agreement_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(14, 14);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(554, 350);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // InterfaceTimer
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Interval = 10;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.primeButton_Next);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(56, 401);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(583, 52);
            this.panel_Controls.TabIndex = 2;
            this.panel_Controls.Visible = false;
            // 
            // primeButton_Next
            // 
            this.primeButton_Next.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.primeButton_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.primeButton_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Next.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Next.BorderRadius = 6;
            this.primeButton_Next.BorderSize = 2;
            this.primeButton_Next.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Next.Enabled = false;
            this.primeButton_Next.FlatAppearance.BorderSize = 0;
            this.primeButton_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.primeButton_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(224)))));
            this.primeButton_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeButton_Next.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.primeButton_Next.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Next.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.primeButton_Next.Location = new System.Drawing.Point(443, 3);
            this.primeButton_Next.Name = "primeButton_Next";
            this.primeButton_Next.Size = new System.Drawing.Size(127, 40);
            this.primeButton_Next.TabIndex = 6;
            this.primeButton_Next.Text = "다음";
            this.primeButton_Next.TextColor = System.Drawing.Color.WhiteSmoke;
            this.primeButton_Next.UseVisualStyleBackColor = false;
            this.primeButton_Next.Click += new System.EventHandler(this.primeButton_Next_Click);
            // 
            // AgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderSize = 3;
            this.ClientSize = new System.Drawing.Size(644, 458);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.button_Return);
            this.Name = "AgreementForm";
            this.Text = "AgreementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgreementForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgreementForm_FormClosed);
            this.panel_Container.ResumeLayout(false);
            this.panel_Container.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.CheckBox checkBox_Agreement;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer InterfaceTimer;
        private System.Windows.Forms.Panel panel_Controls;
        private WithusUI.Controls.Buttons.PrimeButton.PrimeButton primeButton_Next;
    }
}