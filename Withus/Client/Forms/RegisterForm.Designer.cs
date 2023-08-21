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
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.button_Return = new System.Windows.Forms.Button();
            this.panel_Container.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.panel_Header);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(699, 529);
            this.panel_Container.TabIndex = 0;
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.button_Return);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(699, 40);
            this.panel_Header.TabIndex = 0;
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.Transparent;
            this.button_Return.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Return.FlatAppearance.BorderSize = 0;
            this.button_Return.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Return.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Return.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Return.Location = new System.Drawing.Point(0, 0);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(46, 40);
            this.button_Return.TabIndex = 0;
            this.button_Return.Text = "<";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 529);
            this.Controls.Add(this.panel_Container);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel_Container.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Button button_Return;
    }
}