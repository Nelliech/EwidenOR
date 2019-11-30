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
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ewidencje_combobox
            // 
            this.ewidencje_combobox.FormattingEnabled = true;
            this.ewidencje_combobox.Location = new System.Drawing.Point(42, 26);
            this.ewidencje_combobox.Name = "ewidencje_combobox";
            this.ewidencje_combobox.Size = new System.Drawing.Size(703, 21);
            this.ewidencje_combobox.TabIndex = 0;
            this.ewidencje_combobox.SelectionChangeCommitted += new System.EventHandler(this.ewidencje_combobox_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(42, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Uwagi";
            // 
            // uwagi_zabieg
            // 
            this.uwagi_zabieg.Location = new System.Drawing.Point(42, 350);
            this.uwagi_zabieg.Multiline = true;
            this.uwagi_zabieg.Name = "uwagi_zabieg";
            this.uwagi_zabieg.Size = new System.Drawing.Size(301, 74);
            this.uwagi_zabieg.TabIndex = 42;
            // 
            // przyczyna_zabieg
            // 
            this.przyczyna_zabieg.Location = new System.Drawing.Point(42, 256);
            this.przyczyna_zabieg.Multiline = true;
            this.przyczyna_zabieg.Name = "przyczyna_zabieg";
            this.przyczyna_zabieg.Size = new System.Drawing.Size(301, 68);
            this.przyczyna_zabieg.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(42, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 15);
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
            this.dawka_jednostki_zabieg.Location = new System.Drawing.Point(289, 215);
            this.dawka_jednostki_zabieg.Name = "dawka_jednostki_zabieg";
            this.dawka_jednostki_zabieg.Size = new System.Drawing.Size(54, 21);
            this.dawka_jednostki_zabieg.TabIndex = 39;
            // 
            // dawka_zabieg
            // 
            this.dawka_zabieg.Location = new System.Drawing.Point(42, 216);
            this.dawka_zabieg.Name = "dawka_zabieg";
            this.dawka_zabieg.Size = new System.Drawing.Size(241, 20);
            this.dawka_zabieg.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(42, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dawka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nazwa";
            // 
            // nazwa_zabieg
            // 
            this.nazwa_zabieg.Location = new System.Drawing.Point(43, 180);
            this.nazwa_zabieg.Name = "nazwa_zabieg";
            this.nazwa_zabieg.Size = new System.Drawing.Size(300, 20);
            this.nazwa_zabieg.TabIndex = 35;
            // 
            // powierzchnia_zabieg
            // 
            this.powierzchnia_zabieg.Location = new System.Drawing.Point(42, 143);
            this.powierzchnia_zabieg.Name = "powierzchnia_zabieg";
            this.powierzchnia_zabieg.Size = new System.Drawing.Size(301, 20);
            this.powierzchnia_zabieg.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Powierzchnia, na której wykonano zabieg (ha)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Roślina";
            // 
            // roslina_zabieg
            // 
            this.roslina_zabieg.Location = new System.Drawing.Point(42, 106);
            this.roslina_zabieg.Name = "roslina_zabieg";
            this.roslina_zabieg.Size = new System.Drawing.Size(301, 20);
            this.roslina_zabieg.TabIndex = 31;
            // 
            // data_zabieg
            // 
            this.data_zabieg.Location = new System.Drawing.Point(42, 68);
            this.data_zabieg.Name = "data_zabieg";
            this.data_zabieg.Size = new System.Drawing.Size(301, 20);
            this.data_zabieg.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Czas zabiegu";
            // 
            // powrot_button
            // 
            this.powrot_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.powrot_button.Location = new System.Drawing.Point(687, 390);
            this.powrot_button.Name = "powrot_button";
            this.powrot_button.Size = new System.Drawing.Size(97, 34);
            this.powrot_button.TabIndex = 44;
            this.powrot_button.Text = "Powrót";
            this.powrot_button.UseVisualStyleBackColor = false;
            this.powrot_button.Click += new System.EventHandler(this.powrot_button_Click);
            // 
            // zapisz_button
            // 
            this.zapisz_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zapisz_button.Location = new System.Drawing.Point(584, 390);
            this.zapisz_button.Name = "zapisz_button";
            this.zapisz_button.Size = new System.Drawing.Size(97, 34);
            this.zapisz_button.TabIndex = 45;
            this.zapisz_button.Text = "Zapisz";
            this.zapisz_button.UseVisualStyleBackColor = false;
            this.zapisz_button.Click += new System.EventHandler(this.zapisz_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(42, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ewidencje";
            // 
            // edycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
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
            this.MaximizeBox = false;
            this.Name = "edycja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwidenOR";
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
        private System.Windows.Forms.Label label8;
    }
}