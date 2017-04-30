namespace eIspričnica
{
    partial class Upis_pacijenata
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
            this.inputPretraživanje = new System.Windows.Forms.TextBox();
            this.pretraživanje = new System.Windows.Forms.Label();
            this.registriraniPacijentiDataGridView = new System.Windows.Forms.DataGridView();
            this.registriraniPacijenti = new System.Windows.Forms.Label();
            this.spremiButton = new System.Windows.Forms.Button();
            this.linkRegistracija = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.registriraniPacijentiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPretraživanje
            // 
            this.inputPretraživanje.Location = new System.Drawing.Point(118, 77);
            this.inputPretraživanje.Name = "inputPretraživanje";
            this.inputPretraživanje.Size = new System.Drawing.Size(251, 20);
            this.inputPretraživanje.TabIndex = 0;
            // 
            // pretraživanje
            // 
            this.pretraživanje.AutoSize = true;
            this.pretraživanje.Location = new System.Drawing.Point(118, 61);
            this.pretraživanje.Name = "pretraživanje";
            this.pretraživanje.Size = new System.Drawing.Size(68, 13);
            this.pretraživanje.TabIndex = 1;
            this.pretraživanje.Text = "Pretraživanje";
            // 
            // registriraniPacijentiDataGridView
            // 
            this.registriraniPacijentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registriraniPacijentiDataGridView.Location = new System.Drawing.Point(118, 136);
            this.registriraniPacijentiDataGridView.Name = "registriraniPacijentiDataGridView";
            this.registriraniPacijentiDataGridView.Size = new System.Drawing.Size(251, 150);
            this.registriraniPacijentiDataGridView.TabIndex = 2;
            // 
            // registriraniPacijenti
            // 
            this.registriraniPacijenti.AutoSize = true;
            this.registriraniPacijenti.Location = new System.Drawing.Point(118, 120);
            this.registriraniPacijenti.Name = "registriraniPacijenti";
            this.registriraniPacijenti.Size = new System.Drawing.Size(101, 13);
            this.registriraniPacijenti.TabIndex = 3;
            this.registriraniPacijenti.Text = "Registrirani pacijenti";
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(201, 311);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 23);
            this.spremiButton.TabIndex = 4;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            // 
            // linkRegistracija
            // 
            this.linkRegistracija.AutoSize = true;
            this.linkRegistracija.Location = new System.Drawing.Point(135, 351);
            this.linkRegistracija.Name = "linkRegistracija";
            this.linkRegistracija.Size = new System.Drawing.Size(208, 13);
            this.linkRegistracija.TabIndex = 5;
            this.linkRegistracija.TabStop = true;
            this.linkRegistracija.Text = "Pacijent nema račun? Registriraj pacijenta!";
            this.linkRegistracija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistracija_LinkClicked);
            // 
            // Upis_pacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 416);
            this.Controls.Add(this.linkRegistracija);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.registriraniPacijenti);
            this.Controls.Add(this.registriraniPacijentiDataGridView);
            this.Controls.Add(this.pretraživanje);
            this.Controls.Add(this.inputPretraživanje);
            this.Name = "Upis_pacijenata";
            this.Text = "Upis_pacijenata";
            ((System.ComponentModel.ISupportInitialize)(this.registriraniPacijentiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPretraživanje;
        private System.Windows.Forms.Label pretraživanje;
        private System.Windows.Forms.DataGridView registriraniPacijentiDataGridView;
        private System.Windows.Forms.Label registriraniPacijenti;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.LinkLabel linkRegistracija;
    }
}