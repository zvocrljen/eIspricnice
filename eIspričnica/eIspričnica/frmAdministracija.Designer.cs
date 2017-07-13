namespace eIspričnica
{
    partial class frmAdministracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracija));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.idPacijentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojZdravstveneIskazniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.idZaposleniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korLozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razinaPravaidRazinaPravaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolnicaidBolnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZaposleniciDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn1,
            this.korImeDataGridViewTextBoxColumn,
            this.korLozinkaDataGridViewTextBoxColumn,
            this.razinaPravaidRazinaPravaDataGridViewTextBoxColumn,
            this.bolnicaidBolnicaDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 12);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(760, 238);
            this.dgvZaposlenici.TabIndex = 0;
            this.dgvZaposlenici.SelectionChanged += new System.EventHandler(this.dgvZaposlenici_SelectionChanged);
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(eIspričnica.zaposlenici);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 256);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(93, 496);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.AllowUserToAddRows = false;
            this.dgvPacijenti.AllowUserToDeleteRows = false;
            this.dgvPacijenti.AutoGenerateColumns = false;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacijentiDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn,
            this.brojZdravstveneIskazniceDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn});
            this.dgvPacijenti.DataSource = this.pacijentiBindingSource;
            this.dgvPacijenti.Location = new System.Drawing.Point(12, 285);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.ReadOnly = true;
            this.dgvPacijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacijenti.Size = new System.Drawing.Size(760, 205);
            this.dgvPacijenti.TabIndex = 4;
            // 
            // idPacijentiDataGridViewTextBoxColumn
            // 
            this.idPacijentiDataGridViewTextBoxColumn.DataPropertyName = "idPacijenti";
            this.idPacijentiDataGridViewTextBoxColumn.HeaderText = "idPacijenti";
            this.idPacijentiDataGridViewTextBoxColumn.Name = "idPacijentiDataGridViewTextBoxColumn";
            this.idPacijentiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojPoliceOsiguranjaDataGridViewTextBoxColumn
            // 
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.DataPropertyName = "BrojPoliceOsiguranja";
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.HeaderText = "BrojPoliceOsiguranja";
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.Name = "brojPoliceOsiguranjaDataGridViewTextBoxColumn";
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojZdravstveneIskazniceDataGridViewTextBoxColumn
            // 
            this.brojZdravstveneIskazniceDataGridViewTextBoxColumn.DataPropertyName = "BrojZdravstveneIskaznice";
            this.brojZdravstveneIskazniceDataGridViewTextBoxColumn.HeaderText = "BrojZdravstveneIskaznice";
            this.brojZdravstveneIskazniceDataGridViewTextBoxColumn.Name = "brojZdravstveneIskazniceDataGridViewTextBoxColumn";
            this.brojZdravstveneIskazniceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(eIspričnica.pacijenti);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(12, 496);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeni.TabIndex = 5;
            this.btnIzmjeni.Text = "Izmijeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(93, 256);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(174, 256);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 7;
            this.btnBrisi.Text = "Izbriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // idZaposleniciDataGridViewTextBoxColumn
            // 
            this.idZaposleniciDataGridViewTextBoxColumn.DataPropertyName = "idZaposlenici";
            this.idZaposleniciDataGridViewTextBoxColumn.HeaderText = "idZaposlenici";
            this.idZaposleniciDataGridViewTextBoxColumn.Name = "idZaposleniciDataGridViewTextBoxColumn";
            this.idZaposleniciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imePrezimeDataGridViewTextBoxColumn1
            // 
            this.imePrezimeDataGridViewTextBoxColumn1.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn1.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn1.Name = "imePrezimeDataGridViewTextBoxColumn1";
            this.imePrezimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // korImeDataGridViewTextBoxColumn
            // 
            this.korImeDataGridViewTextBoxColumn.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn.HeaderText = "korIme";
            this.korImeDataGridViewTextBoxColumn.Name = "korImeDataGridViewTextBoxColumn";
            this.korImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korLozinkaDataGridViewTextBoxColumn
            // 
            this.korLozinkaDataGridViewTextBoxColumn.DataPropertyName = "korLozinka";
            this.korLozinkaDataGridViewTextBoxColumn.HeaderText = "korLozinka";
            this.korLozinkaDataGridViewTextBoxColumn.Name = "korLozinkaDataGridViewTextBoxColumn";
            this.korLozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razinaPravaidRazinaPravaDataGridViewTextBoxColumn
            // 
            this.razinaPravaidRazinaPravaDataGridViewTextBoxColumn.DataPropertyName = "RazinaPrava_idRazinaPrava";
            this.razinaPravaidRazinaPravaDataGridViewTextBoxColumn.HeaderText = "RazinaPrava_idRazinaPrava";
            this.razinaPravaidRazinaPravaDataGridViewTextBoxColumn.Name = "razinaPravaidRazinaPravaDataGridViewTextBoxColumn";
            this.razinaPravaidRazinaPravaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolnicaidBolnicaDataGridViewTextBoxColumn
            // 
            this.bolnicaidBolnicaDataGridViewTextBoxColumn.DataPropertyName = "Bolnica_idBolnica";
            this.bolnicaidBolnicaDataGridViewTextBoxColumn.HeaderText = "Bolnica_idBolnica";
            this.bolnicaidBolnicaDataGridViewTextBoxColumn.Name = "bolnicaidBolnicaDataGridViewTextBoxColumn";
            this.bolnicaidBolnicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.dgvPacijenti);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvZaposlenici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eIspričnice - Administracija";
            this.Load += new System.EventHandler(this.FormAdministracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacijentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojPoliceOsiguranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojZdravstveneIskazniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZaposleniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korLozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razinaPravaidRazinaPravaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolnicaidBolnicaDataGridViewTextBoxColumn;
    }
}