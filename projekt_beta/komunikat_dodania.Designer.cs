namespace projekt_beta
{
    partial class komunikat_dodania
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
            this.powrot_z_dodania = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powrot_z_dodania
            // 
            this.powrot_z_dodania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrot_z_dodania.Location = new System.Drawing.Point(107, 60);
            this.powrot_z_dodania.Name = "powrot_z_dodania";
            this.powrot_z_dodania.Size = new System.Drawing.Size(106, 37);
            this.powrot_z_dodania.TabIndex = 0;
            this.powrot_z_dodania.Text = "Dalej";
            this.powrot_z_dodania.UseVisualStyleBackColor = true;
            this.powrot_z_dodania.Click += new System.EventHandler(this.powrot_z_dodania_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ewidencja została dodana!";
            // 
            // komunikat_dodania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrot_z_dodania);
            this.Name = "komunikat_dodania";
            this.Text = "Koniec";
            this.Load += new System.EventHandler(this.komunikat_dodania_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot_z_dodania;
        private System.Windows.Forms.Label label1;
    }
}