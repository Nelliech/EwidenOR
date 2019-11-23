namespace projekt_beta
{
    partial class logowanie
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
            this.login_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.zaloguj_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(306, 41);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(100, 20);
            this.login_text.TabIndex = 0;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(306, 79);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(100, 20);
            this.password_text.TabIndex = 1;
            // 
            // zaloguj_button
            // 
            this.zaloguj_button.Location = new System.Drawing.Point(306, 128);
            this.zaloguj_button.Name = "zaloguj_button";
            this.zaloguj_button.Size = new System.Drawing.Size(87, 31);
            this.zaloguj_button.TabIndex = 2;
            this.zaloguj_button.Text = "Zaloguj się ";
            this.zaloguj_button.UseVisualStyleBackColor = true;
            this.zaloguj_button.Click += new System.EventHandler(this.zaloguj_button_Click);
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 284);
            this.Controls.Add(this.zaloguj_button);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_text);
            this.Name = "logowanie";
            this.Text = "logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button zaloguj_button;
    }
}