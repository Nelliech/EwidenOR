namespace projekt_beta
{
    partial class edycja
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
            this.ewidencje_combobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uwagi_zabieg = new System.Windows.Forms.TextBox();
            this.przyczyna_zabieg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.powrot_button = new System.Windows.Forms.Button();
            this.zapisz_button = new System.Windows.Forms.Button();
            this.edycja_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ewidencje_combobox
            // 
            this.ewidencje_combobox.FormattingEnabled = true;
            this.ewidencje_combobox.Location = new System.Drawing.Point(42, 26);
            this.ewidencje_combobox.Name = "ewidencje_combobox";
            this.ewidencje_combobox.Size = new System.Drawing.Size(703, 21);
            this.ewidencje_combobox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Uwagi";
            // 
            // uwagi_zabieg
            // 
            this.uwagi_zabieg.Location = new System.Drawing.Point(42, 350);
            this.uwagi_zabieg.Multiline = true;
            this.uwagi_zabieg.Name = "uwagi_zabieg";
            this.uwagi_zabieg.Size = new System.Drawing.Size(174, 51);
            this.uwagi_zabieg.TabIndex = 42;
            // 
            // przyczyna_zabieg
            // 
            this.przyczyna_zabieg.Location = new System.Drawing.Point(42, 256);
            this.przyczyna_zabieg.Multiline = true;
            this.przyczyna_zabieg.Name = "przyczyna_zabieg";
            this.przyczyna_zabieg.Size = new System.Drawing.Size(160, 68);
            this.przyczyna_zabieg.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Przyczyna zastosowania środka ";
            // 
            // dawka_jednostki_zabieg
            // 
            this.dawka_jednostki_zabieg.FormattingEnabled = true;
            this.dawka_jednostki_zabieg.Items.AddRange(new object[] {
            "l/ha",
            "kg/ha",
            "%"});
            this.dawka_jednostki_zabieg.Location = new System.Drawing.Point(148, 216);
            this.dawka_jednostki_zabieg.Name = "dawka_jednostki_zabieg";
            this.dawka_jednostki_zabieg.Size = new System.Drawing.Size(54, 21);
            this.dawka_jednostki_zabieg.TabIndex = 39;
            // 
            // dawka_zabieg
            // 
            this.dawka_zabieg.Location = new System.Drawing.Point(42, 216);
            this.dawka_zabieg.Name = "dawka_zabieg";
            this.dawka_zabieg.Size = new System.Drawing.Size(100, 20);
            this.dawka_zabieg.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dawka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nazwa";
            // 
            // nazwa_zabieg
            // 
            this.nazwa_zabieg.Location = new System.Drawing.Point(43, 180);
            this.nazwa_zabieg.Name = "nazwa_zabieg";
            this.nazwa_zabieg.Size = new System.Drawing.Size(100, 20);
            this.nazwa_zabieg.TabIndex = 35;
            // 
            // powierzchnia_zabieg
            // 
            this.powierzchnia_zabieg.Location = new System.Drawing.Point(42, 143);
            this.powierzchnia_zabieg.Name = "powierzchnia_zabieg";
            this.powierzchnia_zabieg.Size = new System.Drawing.Size(100, 20);
            this.powierzchnia_zabieg.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Powierzchnia, na której wykonano zabieg ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Roślina";
            // 
            // roslina_zabieg
            // 
            this.roslina_zabieg.Location = new System.Drawing.Point(42, 106);
            this.roslina_zabieg.Name = "roslina_zabieg";
            this.roslina_zabieg.Size = new System.Drawing.Size(100, 20);
            this.roslina_zabieg.TabIndex = 31;
            // 
            // data_zabieg
            // 
            this.data_zabieg.Location = new System.Drawing.Point(42, 68);
            this.data_zabieg.Name = "data_zabieg";
            this.data_zabieg.Size = new System.Drawing.Size(204, 20);
            this.data_zabieg.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Czas zabiegu";
            // 
            // powrot_button
            // 
            this.powrot_button.Location = new System.Drawing.Point(687, 401);
            this.powrot_button.Name = "powrot_button";
            this.powrot_button.Size = new System.Drawing.Size(75, 23);
            this.powrot_button.TabIndex = 44;
            this.powrot_button.Text = "Powrót";
            this.powrot_button.UseVisualStyleBackColor = true;
            this.powrot_button.Click += new System.EventHandler(this.powrot_button_Click);
            // 
            // zapisz_button
            // 
            this.zapisz_button.Location = new System.Drawing.Point(606, 401);
            this.zapisz_button.Name = "zapisz_button";
            this.zapisz_button.Size = new System.Drawing.Size(75, 23);
            this.zapisz_button.TabIndex = 45;
            this.zapisz_button.Text = "Zapisz";
            this.zapisz_button.UseVisualStyleBackColor = true;
            this.zapisz_button.Click += new System.EventHandler(this.zapisz_button_Click);
            // 
            // edycja_button
            // 
            this.edycja_button.Location = new System.Drawing.Point(670, 68);
            this.edycja_button.Name = "edycja_button";
            this.edycja_button.Size = new System.Drawing.Size(75, 23);
            this.edycja_button.TabIndex = 46;
            this.edycja_button.Text = "Edytuj";
            this.edycja_button.UseVisualStyleBackColor = true;
            this.edycja_button.Click += new System.EventHandler(this.edycja_button_Click);
            // 
            // edycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edycja_button);
            this.Controls.Add(this.zapisz_button);
            this.Controls.Add(this.powrot_button);
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
            this.Controls.Add(this.ewidencje_combobox);
            this.Name = "edycja";
            this.Text = "edycja";
            this.Load += new System.EventHandler(this.edycja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ewidencje_combobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uwagi_zabieg;
        private System.Windows.Forms.TextBox przyczyna_zabieg;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button powrot_button;
        private System.Windows.Forms.Button zapisz_button;
        private System.Windows.Forms.Button edycja_button;
    }
}