namespace eIspričnica
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.picKorisnik = new System.Windows.Forms.PictureBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lnkProvjera = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picKorisnik)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(300, 299);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(200, 20);
            this.txtKorIme.TabIndex = 0;
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(297, 283);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorIme.TabIndex = 1;
            this.lblKorIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(297, 322);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(300, 338);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(200, 20);
            this.txtLozinka.TabIndex = 3;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // picKorisnik
            // 
            this.picKorisnik.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picKorisnik.ErrorImage")));
            this.picKorisnik.Image = ((System.Drawing.Image)(resources.GetObject("picKorisnik.Image")));
            this.picKorisnik.Location = new System.Drawing.Point(300, 70);
            this.picKorisnik.Name = "picKorisnik";
            this.picKorisnik.Size = new System.Drawing.Size(200, 200);
            this.picKorisnik.TabIndex = 4;
            this.picKorisnik.TabStop = false;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(365, 368);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // lnkProvjera
            // 
            this.lnkProvjera.AutoSize = true;
            this.lnkProvjera.Location = new System.Drawing.Point(313, 394);
            this.lnkProvjera.Name = "lnkProvjera";
            this.lnkProvjera.Size = new System.Drawing.Size(176, 13);
            this.lnkProvjera.TabIndex = 6;
            this.lnkProvjera.TabStop = true;
            this.lnkProvjera.Text = "Provjeri ispričnicu po serijskom broju";
            this.lnkProvjera.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProvjera_LinkClicked);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lnkProvjera);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.picKorisnik);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.txtKorIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eIspričnice - Prijava u aplikaciju";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKorisnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.PictureBox picKorisnik;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.LinkLabel lnkProvjera;
    }
}

