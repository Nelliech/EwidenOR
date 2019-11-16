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
            this.import_excel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // historia_ewidencji
            // 
            this.historia_ewidencji.Location = new System.Drawing.Point(523, 145);
            this.historia_ewidencji.Name = "historia_ewidencji";
            this.historia_ewidencji.Size = new System.Drawing.Size(238, 57);
            this.historia_ewidencji.TabIndex = 0;
            this.historia_ewidencji.Text = "Historia Ewidencji";
            this.historia_ewidencji.UseVisualStyleBackColor = true;
            this.historia_ewidencji.Click += new System.EventHandler(this.historia_ewidencji_Click);
            // 
            // dodaj_ewidencje
            // 
            this.dodaj_ewidencje.Location = new System.Drawing.Point(158, 145);
            this.dodaj_ewidencje.Name = "dodaj_ewidencje";
            this.dodaj_ewidencje.Size = new System.Drawing.Size(187, 57);
            this.dodaj_ewidencje.TabIndex = 1;
            this.dodaj_ewidencje.Text = "Dodaj nową ewidencje";
            this.dodaj_ewidencje.UseVisualStyleBackColor = true;
            this.dodaj_ewidencje.Click += new System.EventHandler(this.dodaj_ewidencje_Click);
            // 
            // import_excel
            // 
            this.import_excel.Location = new System.Drawing.Point(307, 303);
            this.import_excel.Name = "import_excel";
            this.import_excel.Size = new System.Drawing.Size(251, 77);
            this.import_excel.TabIndex = 2;
            this.import_excel.Text = "Importuj do Excel\'a";
            this.import_excel.UseVisualStyleBackColor = true;
            this.import_excel.Click += new System.EventHandler(this.import_excel_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 547);
            this.Controls.Add(this.import_excel);
            this.Controls.Add(this.dodaj_ewidencje);
            this.Controls.Add(this.historia_ewidencji);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button historia_ewidencji;
        private System.Windows.Forms.Button dodaj_ewidencje;
        private System.Windows.Forms.Button import_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}