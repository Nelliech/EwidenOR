namespace projekt_beta
{
    partial class Start
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
            this.historia_ewidencji = new System.Windows.Forms.Button();
            this.dodaj_ewidencje = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.wylogowanie_button = new System.Windows.Forms.Button();
            this.edytuj_ewidencje_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historia_ewidencji
            // 
            this.historia_ewidencji.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.historia_ewidencji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historia_ewidencji.Location = new System.Drawing.Point(561, 199);
            this.historia_ewidencji.Name = "historia_ewidencji";
            this.historia_ewidencji.Size = new System.Drawing.Size(252, 75);
            this.historia_ewidencji.TabIndex = 0;
            this.historia_ewidencji.Text = "Historia Ewidencji";
            this.historia_ewidencji.UseVisualStyleBackColor = false;
            this.historia_ewidencji.Click += new System.EventHandler(this.historia_ewidencji_Click);
            // 
            // dodaj_ewidencje
            // 
            this.dodaj_ewidencje.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodaj_ewidencje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_ewidencje.Location = new System.Drawing.Point(12, 199);
            this.dodaj_ewidencje.Name = "dodaj_ewidencje";
            this.dodaj_ewidencje.Size = new System.Drawing.Size(252, 75);
            this.dodaj_ewidencje.TabIndex = 1;
            this.dodaj_ewidencje.Text = "Dodaj nową ewidencje";
            this.dodaj_ewidencje.UseVisualStyleBackColor = false;
            this.dodaj_ewidencje.Click += new System.EventHandler(this.dodaj_ewidencje_Click);
            // 
            // wylogowanie_button
            // 
            this.wylogowanie_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wylogowanie_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wylogowanie_button.Location = new System.Drawing.Point(706, 531);
            this.wylogowanie_button.Name = "wylogowanie_button";
            this.wylogowanie_button.Size = new System.Drawing.Size(117, 36);
            this.wylogowanie_button.TabIndex = 2;
            this.wylogowanie_button.Text = "Wyloguj się";
            this.wylogowanie_button.UseVisualStyleBackColor = false;
            this.wylogowanie_button.Click += new System.EventHandler(this.wylogowanie_button_Click);
            // 
            // edytuj_ewidencje_button
            // 
            this.edytuj_ewidencje_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.edytuj_ewidencje_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytuj_ewidencje_button.Location = new System.Drawing.Point(288, 199);
            this.edytuj_ewidencje_button.Name = "edytuj_ewidencje_button";
            this.edytuj_ewidencje_button.Size = new System.Drawing.Size(252, 75);
            this.edytuj_ewidencje_button.TabIndex = 3;
            this.edytuj_ewidencje_button.Text = "Edytuj Ewydencje";
            this.edytuj_ewidencje_button.UseVisualStyleBackColor = false;
            this.edytuj_ewidencje_button.Click += new System.EventHandler(this.edytuj_ewidencje_button_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 569);
            this.Controls.Add(this.edytuj_ewidencje_button);
            this.Controls.Add(this.wylogowanie_button);
            this.Controls.Add(this.dodaj_ewidencje);
            this.Controls.Add(this.historia_ewidencji);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwidenOR";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button historia_ewidencji;
        private System.Windows.Forms.Button dodaj_ewidencje;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button wylogowanie_button;
        private System.Windows.Forms.Button edytuj_ewidencje_button;
    }
}