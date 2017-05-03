namespace eIspričnica
{
    partial class FormAdministracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracija));
            this.inputKorisnik = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodijeli = new System.Windows.Forms.Button();
            this.outputKorisnik = new System.Windows.Forms.DataGridView();
            this.btnIzmjena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputKorisnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputKorisnik)).BeginInit();
            this.SuspendLayout();
            // 
            // inputKorisnik
            // 
            this.inputKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputKorisnik.Location = new System.Drawing.Point(12, 12);
            this.inputKorisnik.Name = "inputKorisnik";
            this.inputKorisnik.Size = new System.Drawing.Size(346, 298);
            this.inputKorisnik.TabIndex = 0;
            this.inputKorisnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputKorisnik_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 316);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(400, 345);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodijeli
            // 
            this.btnDodijeli.Location = new System.Drawing.Point(400, 374);
            this.btnDodijeli.Name = "btnDodijeli";
            this.btnDodijeli.Size = new System.Drawing.Size(99, 23);
            this.btnDodijeli.TabIndex = 3;
            this.btnDodijeli.Text = "Dodijeli liječniku";
            this.btnDodijeli.UseVisualStyleBackColor = true;
            this.btnDodijeli.Click += new System.EventHandler(this.btnDodijeli_Click);
            // 
            // outputKorisnik
            // 
            this.outputKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputKorisnik.Location = new System.Drawing.Point(400, 12);
            this.outputKorisnik.Name = "outputKorisnik";
            this.outputKorisnik.Size = new System.Drawing.Size(372, 298);
            this.outputKorisnik.TabIndex = 4;
            this.outputKorisnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputKorisnik_CellContentClick);
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(400, 316);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjena.TabIndex = 5;
            this.btnIzmjena.Text = "Izmijeni";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // FormAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.outputKorisnik);
            this.Controls.Add(this.btnDodijeli);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.inputKorisnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdministracija";
            this.Text = "eIspričnice - Administracija";
            this.Load += new System.EventHandler(this.FormAdministracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputKorisnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputKorisnik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inputKorisnik;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodijeli;
        private System.Windows.Forms.DataGridView outputKorisnik;
        private System.Windows.Forms.Button btnIzmjena;
    }
}