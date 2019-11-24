namespace projekt_beta
{
    partial class dodaj_zabieg
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dawka_jednostki_zabieg = new System.Windows.Forms.ComboBox();
            this.dawka_zabieg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazwa_zabieg = new System.Windows.Forms.TextBox();
            this.powierzchnia_zabieg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roslina_zabieg = new System.Windows.Forms.TextBox();
            this.data_zabieg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.przyczyna_zabieg = new System.Windows.Forms.TextBox();
            this.uwagi_zabieg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.powrot_zabieg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dawka_jednostki_zabieg
            // 
            this.dawka_jednostki_zabieg.FormattingEnabled = true;
            this.dawka_jednostki_zabieg.Items.AddRange(new object[] {
            "l/ha",
            "kg/ha",
            "%"});
            this.dawka_jednostki_zabieg.Location = new System.Drawing.Point(118, 174);
            this.dawka_jednostki_zabieg.Name = "dawka_jednostki_zabieg";
            this.dawka_jednostki_zabieg.Size = new System.Drawing.Size(48, 21);
            this.dawka_jednostki_zabieg.TabIndex = 24;
            // 
            // dawka_zabieg
            // 
            this.dawka_zabieg.Location = new System.Drawing.Point(12, 174);
            this.dawka_zabieg.Name = "dawka_zabieg";
            this.dawka_zabieg.Size = new System.Drawing.Size(100, 20);
            this.dawka_zabieg.TabIndex = 23;
            this.dawka_zabieg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dawka_zabieg_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dawka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nazwa";
            // 
            // nazwa_zabieg
            // 
            this.nazwa_zabieg.Location = new System.Drawing.Point(13, 138);
            this.nazwa_zabieg.Name = "nazwa_zabieg";
            this.nazwa_zabieg.Size = new System.Drawing.Size(100, 20);
            this.nazwa_zabieg.TabIndex = 20;
            // 
            // powierzchnia_zabieg
            // 
            this.powierzchnia_zabieg.Location = new System.Drawing.Point(12, 101);
            this.powierzchnia_zabieg.Name = "powierzchnia_zabieg";
            this.powierzchnia_zabieg.Size = new System.Drawing.Size(100, 20);
            this.powierzchnia_zabieg.TabIndex = 19;
            this.powierzchnia_zabieg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.powierzchnia_zabieg_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Powierzchnia, na której wykonano zabieg ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Roślina";
            // 
            // roslina_zabieg
            // 
            this.roslina_zabieg.Location = new System.Drawing.Point(12, 64);
            this.roslina_zabieg.Name = "roslina_zabieg";
            this.roslina_zabieg.Size = new System.Drawing.Size(100, 20);
            this.roslina_zabieg.TabIndex = 16;
            // 
            // data_zabieg
            // 
            this.data_zabieg.Location = new System.Drawing.Point(12, 26);
            this.data_zabieg.Name = "data_zabieg";
            this.data_zabieg.Size = new System.Drawing.Size(204, 20);
            this.data_zabieg.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Czas zabiegu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Przyczyna zastosowania środka ";
            // 
            // przyczyna_zabieg
            // 
            this.przyczyna_zabieg.Location = new System.Drawing.Point(12, 214);
            this.przyczyna_zabieg.Multiline = true;
            this.przyczyna_zabieg.Name = "przyczyna_zabieg";
            this.przyczyna_zabieg.Size = new System.Drawing.Size(160, 68);
            this.przyczyna_zabieg.TabIndex = 26;
            // 
            // uwagi_zabieg
            // 
            this.uwagi_zabieg.Location = new System.Drawing.Point(12, 308);
            this.uwagi_zabieg.Multiline = true;
            this.uwagi_zabieg.Name = "uwagi_zabieg";
            this.uwagi_zabieg.Size = new System.Drawing.Size(174, 51);
            this.uwagi_zabieg.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Uwagi";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(278, 336);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 29;
            this.dodaj.Text = "Dodaj zabieg";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // powrot_zabieg
            // 
            this.powrot_zabieg.Location = new System.Drawing.Point(192, 336);
            this.powrot_zabieg.Name = "powrot_zabieg";
            this.powrot_zabieg.Size = new System.Drawing.Size(75, 23);
            this.powrot_zabieg.TabIndex = 30;
            this.powrot_zabieg.Text = "Powrót";
            this.powrot_zabieg.UseVisualStyleBackColor = true;
            this.powrot_zabieg.Click += new System.EventHandler(this.powrot_zabieg_Click);
            // 
            // dodaj_zabieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 365);
            this.Controls.Add(this.powrot_zabieg);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uwagi_zabieg);
            this.Controls.Add(this.przyczyna_zabieg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dawka_jednostki_zabieg);
            this.Controls.Add(this.dawka_zabieg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazwa_zabieg);
            this.Controls.Add(this.powierzchnia_zabieg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roslina_zabieg);
            this.Controls.Add(this.data_zabieg);
            this.Controls.Add(this.label1);
            this.Name = "dodaj_zabieg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.dodaj_zabieg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dawka_jednostki_zabieg;
        private System.Windows.Forms.TextBox dawka_zabieg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazwa_zabieg;
        private System.Windows.Forms.TextBox powierzchnia_zabieg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roslina_zabieg;
        private System.Windows.Forms.DateTimePicker data_zabieg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox przyczyna_zabieg;
        private System.Windows.Forms.TextBox uwagi_zabieg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button powrot_zabieg;
    }
}

