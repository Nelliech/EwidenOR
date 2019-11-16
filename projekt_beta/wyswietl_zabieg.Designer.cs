namespace projekt_beta
{
    partial class wyswietl_zabieg
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
            this.ArkuszDanych = new System.Windows.Forms.DataGridView();
            this.powrot_wyswietl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArkuszDanych)).BeginInit();
            this.SuspendLayout();
            // 
            // ArkuszDanych
            // 
            this.ArkuszDanych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArkuszDanych.Location = new System.Drawing.Point(12, 12);
            this.ArkuszDanych.Name = "ArkuszDanych";
            this.ArkuszDanych.Size = new System.Drawing.Size(985, 441);
            this.ArkuszDanych.TabIndex = 1;
            // 
            // powrot_wyswietl
            // 
            this.powrot_wyswietl.Location = new System.Drawing.Point(455, 473);
            this.powrot_wyswietl.Name = "powrot_wyswietl";
            this.powrot_wyswietl.Size = new System.Drawing.Size(95, 24);
            this.powrot_wyswietl.TabIndex = 2;
            this.powrot_wyswietl.Text = "button2";
            this.powrot_wyswietl.UseVisualStyleBackColor = true;
            this.powrot_wyswietl.Click += new System.EventHandler(this.powrot_wyswietl_Click);
            // 
            // wyswietl_zabieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 509);
            this.Controls.Add(this.powrot_wyswietl);
            this.Controls.Add(this.ArkuszDanych);
            this.Name = "wyswietl_zabieg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.wyswietl_zabieg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArkuszDanych)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ArkuszDanych;
        private System.Windows.Forms.Button powrot_wyswietl;
    }
}