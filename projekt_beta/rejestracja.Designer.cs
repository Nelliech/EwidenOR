namespace projekt_beta
{
    partial class rejestracja
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
            this.imie_text_rejestracja = new System.Windows.Forms.TextBox();
            this.nazwisko_text_rejestracja = new System.Windows.Forms.TextBox();
            this.login_text_rejestracja = new System.Windows.Forms.TextBox();
            this.pass_text_rejestracja = new System.Windows.Forms.TextBox();
            this.passre_text_rejestracja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rejestracja_button = new System.Windows.Forms.Button();
            this.label_alert = new System.Windows.Forms.Label();
            this.label_alert_pass = new System.Windows.Forms.Label();
            this.label_alert_login = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imie_text_rejestracja
            // 
            this.imie_text_rejestracja.BackColor = System.Drawing.SystemColors.Menu;
            this.imie_text_rejestracja.Location = new System.Drawing.Point(161, 42);
            this.imie_text_rejestracja.Name = "imie_text_rejestracja";
            this.imie_text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.imie_text_rejestracja.TabIndex = 0;
            // 
            // nazwisko_text_rejestracja
            // 
            this.nazwisko_text_rejestracja.BackColor = System.Drawing.SystemColors.Menu;
            this.nazwisko_text_rejestracja.Location = new System.Drawing.Point(161, 68);
            this.nazwisko_text_rejestracja.Name = "nazwisko_text_rejestracja";
            this.nazwisko_text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.nazwisko_text_rejestracja.TabIndex = 1;
            // 
            // login_text_rejestracja
            // 
            this.login_text_rejestracja.BackColor = System.Drawing.SystemColors.Menu;
            this.login_text_rejestracja.Location = new System.Drawing.Point(161, 94);
            this.login_text_rejestracja.Name = "login_text_rejestracja";
            this.login_text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.login_text_rejestracja.TabIndex = 2;
            this.login_text_rejestracja.Click += new System.EventHandler(this.login_text_rejestracja_Click);
            // 
            // pass_text_rejestracja
            // 
            this.pass_text_rejestracja.BackColor = System.Drawing.SystemColors.Menu;
            this.pass_text_rejestracja.Location = new System.Drawing.Point(161, 120);
            this.pass_text_rejestracja.Name = "pass_text_rejestracja";
            this.pass_text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.pass_text_rejestracja.TabIndex = 3;
            this.pass_text_rejestracja.Click += new System.EventHandler(this.pass_text_rejestracja_Click);
            // 
            // passre_text_rejestracja
            // 
            this.passre_text_rejestracja.BackColor = System.Drawing.SystemColors.Menu;
            this.passre_text_rejestracja.Location = new System.Drawing.Point(161, 146);
            this.passre_text_rejestracja.Name = "passre_text_rejestracja";
            this.passre_text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.passre_text_rejestracja.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwisko*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login(4-16)*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasło(4-8)*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Powtórz hasło*";
            // 
            // rejestracja_button
            // 
            this.rejestracja_button.Location = new System.Drawing.Point(161, 190);
            this.rejestracja_button.Name = "rejestracja_button";
            this.rejestracja_button.Size = new System.Drawing.Size(100, 33);
            this.rejestracja_button.TabIndex = 10;
            this.rejestracja_button.Text = "Załóż Konto";
            this.rejestracja_button.UseVisualStyleBackColor = true;
            this.rejestracja_button.Click += new System.EventHandler(this.rejestracja_button_Click);
            // 
            // label_alert
            // 
            this.label_alert.AutoSize = true;
            this.label_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_alert.ForeColor = System.Drawing.Color.DarkRed;
            this.label_alert.Location = new System.Drawing.Point(161, 173);
            this.label_alert.Name = "label_alert";
            this.label_alert.Size = new System.Drawing.Size(149, 15);
            this.label_alert.TabIndex = 11;
            this.label_alert.Text = "Uzupełnij wymagane pola";
            // 
            // label_alert_pass
            // 
            this.label_alert_pass.AutoSize = true;
            this.label_alert_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_alert_pass.ForeColor = System.Drawing.Color.DarkRed;
            this.label_alert_pass.Location = new System.Drawing.Point(267, 127);
            this.label_alert_pass.Name = "label_alert_pass";
            this.label_alert_pass.Size = new System.Drawing.Size(160, 15);
            this.label_alert_pass.TabIndex = 12;
            this.label_alert_pass.Text = "Niepoprawna długość hasła";
            // 
            // label_alert_login
            // 
            this.label_alert_login.AutoSize = true;
            this.label_alert_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_alert_login.ForeColor = System.Drawing.Color.DarkRed;
            this.label_alert_login.Location = new System.Drawing.Point(268, 94);
            this.label_alert_login.Name = "label_alert_login";
            this.label_alert_login.Size = new System.Drawing.Size(124, 15);
            this.label_alert_login.TabIndex = 13;
            this.label_alert_login.Text = "Taki login już istnieje!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(161, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rejestracja";
            // 
            // rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 220);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_alert_login);
            this.Controls.Add(this.label_alert_pass);
            this.Controls.Add(this.label_alert);
            this.Controls.Add(this.rejestracja_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passre_text_rejestracja);
            this.Controls.Add(this.pass_text_rejestracja);
            this.Controls.Add(this.login_text_rejestracja);
            this.Controls.Add(this.nazwisko_text_rejestracja);
            this.Controls.Add(this.imie_text_rejestracja);
            this.MaximizeBox = false;
            this.Name = "rejestracja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwidenOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie_text_rejestracja;
        private System.Windows.Forms.TextBox nazwisko_text_rejestracja;
        private System.Windows.Forms.TextBox login_text_rejestracja;
        private System.Windows.Forms.TextBox pass_text_rejestracja;
        private System.Windows.Forms.TextBox passre_text_rejestracja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rejestracja_button;
        private System.Windows.Forms.Label label_alert;
        private System.Windows.Forms.Label label_alert_pass;
        private System.Windows.Forms.Label label_alert_login;
        private System.Windows.Forms.Label label6;
    }
}