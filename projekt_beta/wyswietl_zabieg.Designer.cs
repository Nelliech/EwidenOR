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
            this.druk = new System.Windows.Forms.Button();
            this.edytuj_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArkuszDanych)).BeginInit();
            this.SuspendLayout();
            // 
            // ArkuszDanych
            // 
            this.ArkuszDanych.AllowUserToAddRows = false;
            this.ArkuszDanych.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArkuszDanych.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ArkuszDanych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArkuszDanych.Location = new System.Drawing.Point(12, 12);
            this.ArkuszDanych.Name = "ArkuszDanych";
            this.ArkuszDanych.Size = new System.Drawing.Size(985, 441);
            this.ArkuszDanych.TabIndex = 1;
            // 
            // powrot_wyswietl
            // 
            this.powrot_wyswietl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.powrot_wyswietl.Location = new System.Drawing.Point(876, 459);
            this.powrot_wyswietl.Name = "powrot_wyswietl";
            this.powrot_wyswietl.Size = new System.Drawing.Size(121, 38);
            this.powrot_wyswietl.TabIndex = 2;
            this.powrot_wyswietl.Text = "Powrót";
            this.powrot_wyswietl.UseVisualStyleBackColor = false;
            this.powrot_wyswietl.Click += new System.EventHandler(this.powrot_wyswietl_Click);
            // 
            // druk
            // 
            this.druk.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.druk.Location = new System.Drawing.Point(424, 459);
            this.druk.Name = "druk";
            this.druk.Size = new System.Drawing.Size(148, 45);
            this.druk.TabIndex = 3;
            this.druk.Text = "Konwertuj do PDF\'a";
            this.druk.UseVisualStyleBackColor = false;
            this.druk.Click += new System.EventHandler(this.druk_Click);
            // 
            // edytuj_button
            // 
            this.edytuj_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.edytuj_button.Location = new System.Drawing.Point(12, 459);
            this.edytuj_button.Name = "edytuj_button";
            this.edytuj_button.Size = new System.Drawing.Size(148, 45);
            this.edytuj_button.TabIndex = 4;
            this.edytuj_button.Text = "Edytuj ";
            this.edytuj_button.UseVisualStyleBackColor = false;
            this.edytuj_button.Click += new System.EventHandler(this.edytuj_button_Click);
            // 
            // wyswietl_zabieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 509);
            this.Controls.Add(this.edytuj_button);
            this.Controls.Add(this.druk);
            this.Controls.Add(this.powrot_wyswietl);
            this.Controls.Add(this.ArkuszDanych);
            this.MaximizeBox = false;
            this.Name = "wyswietl_zabieg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwidenOR";
            this.Load += new System.EventHandler(this.wyswietl_zabieg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArkuszDanych)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ArkuszDanych;
        private System.Windows.Forms.Button powrot_wyswietl;
        private System.Windows.Forms.Button druk;
        private System.Windows.Forms.Button edytuj_button;
    }
}