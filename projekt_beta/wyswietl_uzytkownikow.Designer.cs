namespace projekt_beta
{
    partial class wyswietl_uzytkownikow
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
            this.powrot_button = new System.Windows.Forms.Button();
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
            this.ArkuszDanych.TabIndex = 2;
            // 
            // powrot_button
            // 
            this.powrot_button.Location = new System.Drawing.Point(859, 459);
            this.powrot_button.Name = "powrot_button";
            this.powrot_button.Size = new System.Drawing.Size(123, 38);
            this.powrot_button.TabIndex = 3;
            this.powrot_button.Text = "Powrót";
            this.powrot_button.UseVisualStyleBackColor = true;
            this.powrot_button.Click += new System.EventHandler(this.powrot_button_Click);
            // 
            // wyswietl_uzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 509);
            this.ControlBox = false;
            this.Controls.Add(this.powrot_button);
            this.Controls.Add(this.ArkuszDanych);
            this.MaximizeBox = false;
            this.Name = "wyswietl_uzytkownikow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwidenOR";
            this.Load += new System.EventHandler(this.wyswietl_uzytkownikow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArkuszDanych)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ArkuszDanych;
        private System.Windows.Forms.Button powrot_button;
    }
}