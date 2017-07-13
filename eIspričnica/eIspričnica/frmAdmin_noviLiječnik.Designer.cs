namespace eIspričnica
{
    partial class frmAdmin_noviLiječnik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin_noviLiječnik));
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.cbRazinaPrava = new System.Windows.Forms.ComboBox();
            this.razinapravaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRazinaPrava = new System.Windows.Forms.Label();
            this.cbBolnica = new System.Windows.Forms.ComboBox();
            this.bolnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBolnica = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.razinapravaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolnicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(91, 56);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(207, 20);
            this.txtImePrezime.TabIndex = 2;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(91, 82);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(207, 20);
            this.txtKorIme.TabIndex = 3;
            this.txtKorIme.Click += new System.EventHandler(this.txtKorIme_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(91, 108);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(207, 20);
            this.txtLozinka.TabIndex = 4;
            this.txtLozinka.Click += new System.EventHandler(this.txtLozinka_Click);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(16, 59);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(71, 13);
            this.lblImePrezime.TabIndex = 5;
            this.lblImePrezime.Text = "Ime i prezime:";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(9, 85);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(78, 13);
            this.lblKorIme.TabIndex = 6;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(38, 111);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 7;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // cbRazinaPrava
            // 
            this.cbRazinaPrava.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.razinapravaBindingSource, "idRazinaPrava", true));
            this.cbRazinaPrava.DataSource = this.razinapravaBindingSource;
            this.cbRazinaPrava.DisplayMember = "Opis";
            this.cbRazinaPrava.FormattingEnabled = true;
            this.cbRazinaPrava.Location = new System.Drawing.Point(91, 134);
            this.cbRazinaPrava.Name = "cbRazinaPrava";
            this.cbRazinaPrava.Size = new System.Drawing.Size(207, 21);
            this.cbRazinaPrava.TabIndex = 8;
            // 
            // razinapravaBindingSource
            // 
            this.razinapravaBindingSource.DataSource = typeof(eIspričnica.razinaprava);
            // 
            // lblRazinaPrava
            // 
            this.lblRazinaPrava.AutoSize = true;
            this.lblRazinaPrava.Location = new System.Drawing.Point(14, 137);
            this.lblRazinaPrava.Name = "lblRazinaPrava";
            this.lblRazinaPrava.Size = new System.Drawing.Size(73, 13);
            this.lblRazinaPrava.TabIndex = 9;
            this.lblRazinaPrava.Text = "Razina prava:";
            // 
            // cbBolnica
            // 
            this.cbBolnica.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolnicaBindingSource, "idBolnica", true));
            this.cbBolnica.DataSource = this.bolnicaBindingSource;
            this.cbBolnica.DisplayMember = "Naziv";
            this.cbBolnica.FormattingEnabled = true;
            this.cbBolnica.Location = new System.Drawing.Point(91, 161);
            this.cbBolnica.Name = "cbBolnica";
            this.cbBolnica.Size = new System.Drawing.Size(207, 21);
            this.cbBolnica.TabIndex = 10;
            this.cbBolnica.ValueMember = "idBolnica";
            // 
            // bolnicaBindingSource
            // 
            this.bolnicaBindingSource.DataSource = typeof(eIspričnica.bolnica);
            // 
            // lblBolnica
            // 
            this.lblBolnica.AutoSize = true;
            this.lblBolnica.Location = new System.Drawing.Point(42, 164);
            this.lblBolnica.Name = "lblBolnica";
            this.lblBolnica.Size = new System.Drawing.Size(45, 13);
            this.lblBolnica.TabIndex = 11;
            this.lblBolnica.Text = "Bolnica:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(91, 203);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(207, 23);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdmin_noviLiječnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblBolnica);
            this.Controls.Add(this.cbBolnica);
            this.Controls.Add(this.lblRazinaPrava);
            this.Controls.Add(this.cbRazinaPrava);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin_noviLiječnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "eIspričnice - Dodavanje/izmjena";
            this.Load += new System.EventHandler(this.frmAdmin_novi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razinapravaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolnicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.ComboBox cbRazinaPrava;
        private System.Windows.Forms.Label lblRazinaPrava;
        private System.Windows.Forms.ComboBox cbBolnica;
        private System.Windows.Forms.Label lblBolnica;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.BindingSource razinapravaBindingSource;
        private System.Windows.Forms.BindingSource bolnicaBindingSource;
    }
}