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
            this.nazwisko__text_rejestracja = new System.Windows.Forms.TextBox();
            this.login__text_rejestracja = new System.Windows.Forms.TextBox();
            this.pass__text_rejestracja = new System.Windows.Forms.TextBox();
            this.passre__text_rejestracja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rejestracja_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imie_text_rejestracja
            // 
            this.imie_text_rejestracja.Location = new System.Drawing.Point(314, 86);
            this.imie_text_rejestracja.Name = "imie_text_rejestracja";
            this.imie_text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.imie_text_rejestracja.TabIndex = 0;
            // 
            // nazwisko__text_rejestracja
            // 
            this.nazwisko__text_rejestracja.Location = new System.Drawing.Point(314, 112);
            this.nazwisko__text_rejestracja.Name = "nazwisko__text_rejestracja";
            this.nazwisko__text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.nazwisko__text_rejestracja.TabIndex = 1;
            // 
            // login__text_rejestracja
            // 
            this.login__text_rejestracja.Location = new System.Drawing.Point(314, 138);
            this.login__text_rejestracja.Name = "login__text_rejestracja";
            this.login__text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.login__text_rejestracja.TabIndex = 2;
            // 
            // pass__text_rejestracja
            // 
            this.pass__text_rejestracja.Location = new System.Drawing.Point(314, 164);
            this.pass__text_rejestracja.Name = "pass__text_rejestracja";
            this.pass__text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.pass__text_rejestracja.TabIndex = 3;
            // 
            // passre__text_rejestracja
            // 
            this.passre__text_rejestracja.Location = new System.Drawing.Point(314, 190);
            this.passre__text_rejestracja.Name = "passre__text_rejestracja";
            this.passre__text_rejestracja.Size = new System.Drawing.Size(100, 20);
            this.passre__text_rejestracja.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasło";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Powtórz hasło";
            // 
            // rejestracja_button
            // 
            this.rejestracja_button.Location = new System.Drawing.Point(328, 230);
            this.rejestracja_button.Name = "rejestracja_button";
            this.rejestracja_button.Size = new System.Drawing.Size(75, 23);
            this.rejestracja_button.TabIndex = 10;
            this.rejestracja_button.Text = "Załóż Konto";
            this.rejestracja_button.UseVisualStyleBackColor = true;
            this.rejestracja_button.Click += new System.EventHandler(this.rejestracja_button_Click);
            // 
            // rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rejestracja_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passre__text_rejestracja);
            this.Controls.Add(this.pass__text_rejestracja);
            this.Controls.Add(this.login__text_rejestracja);
            this.Controls.Add(this.nazwisko__text_rejestracja);
            this.Controls.Add(this.imie_text_rejestracja);
            this.Name = "rejestracja";
            this.Text = "rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie_text_rejestracja;
        private System.Windows.Forms.TextBox nazwisko__text_rejestracja;
        private System.Windows.Forms.TextBox login__text_rejestracja;
        private System.Windows.Forms.TextBox pass__text_rejestracja;
        private System.Windows.Forms.TextBox passre__text_rejestracja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rejestracja_button;
    }
}