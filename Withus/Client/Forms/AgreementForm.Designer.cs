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
            this.button_Return = new System.Windows.Forms.Button();
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
            this.button_Return.Size = new System.Drawing.Size(51, 440);
            this.button_Return.TabIndex = 0;
            this.button_Return.Text = "<";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // AgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderSize = 3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Return);
            this.Name = "AgreementForm";
            this.Text = "AgreementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgreementForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgreementForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Return;
    }
}