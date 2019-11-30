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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logowanie));
            this.login_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.zaloguj_button = new System.Windows.Forms.Button();
            this.zalozkonto_button = new System.Windows.Forms.Button();
            this.wiadomosc_logowania = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(56, 24);
            this.login_text.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(322, 23);
            this.login_text.TabIndex = 0;
            this.login_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_text_KeyPress);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(465, 24);
            this.password_text.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(345, 23);
            this.password_text.TabIndex = 1;
            this.password_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_text_KeyPress);
            // 
            // zaloguj_button
            // 
            this.zaloguj_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zaloguj_button.Location = new System.Drawing.Point(709, 59);
            this.zaloguj_button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.zaloguj_button.Name = "zaloguj_button";
            this.zaloguj_button.Size = new System.Drawing.Size(101, 38);
            this.zaloguj_button.TabIndex = 2;
            this.zaloguj_button.Text = "Zaloguj się ";
            this.zaloguj_button.UseVisualStyleBackColor = false;
            this.zaloguj_button.Click += new System.EventHandler(this.zaloguj_button_Click);
            // 
            // zalozkonto_button
            // 
            this.zalozkonto_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zalozkonto_button.Location = new System.Drawing.Point(710, 107);
            this.zalozkonto_button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.zalozkonto_button.Name = "zalozkonto_button";
            this.zalozkonto_button.Size = new System.Drawing.Size(101, 38);
            this.zalozkonto_button.TabIndex = 3;
            this.zalozkonto_button.Text = "Załóż Konto";
            this.zalozkonto_button.UseVisualStyleBackColor = false;
            this.zalozkonto_button.Click += new System.EventHandler(this.zalozkonto_button_Click);
            // 
            // wiadomosc_logowania
            // 
            this.wiadomosc_logowania.AutoSize = true;
            this.wiadomosc_logowania.ForeColor = System.Drawing.Color.Red;
            this.wiadomosc_logowania.Location = new System.Drawing.Point(348, 59);
            this.wiadomosc_logowania.Name = "wiadomosc_logowania";
            this.wiadomosc_logowania.Size = new System.Drawing.Size(111, 16);
            this.wiadomosc_logowania.TabIndex = 4;
            this.wiadomosc_logowania.Text = "Niepoprawne dane!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.wiadomosc_logowania);
            this.groupBox1.Controls.Add(this.login_text);
            this.groupBox1.Controls.Add(this.zalozkonto_button);
            this.groupBox1.Controls.Add(this.password_text);
            this.groupBox1.Controls.Add(this.zaloguj_button);
            this.groupBox1.Location = new System.Drawing.Point(2, 423);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(826, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(825, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "logowanie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwidenOR";
            this.Load += new System.EventHandler(this.logowanie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button zaloguj_button;
        private System.Windows.Forms.Button zalozkonto_button;
        private System.Windows.Forms.Label wiadomosc_logowania;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}