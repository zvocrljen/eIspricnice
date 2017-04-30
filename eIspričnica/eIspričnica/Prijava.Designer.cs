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
            this.inputKorIme = new System.Windows.Forms.TextBox();
            this.korIme = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.inputLozinka = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.linkProvjera = new System.Windows.Forms.LinkLabel();
            this.linkRegistracija = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputKorIme
            // 
            this.inputKorIme.Location = new System.Drawing.Point(300, 299);
            this.inputKorIme.Name = "inputKorIme";
            this.inputKorIme.Size = new System.Drawing.Size(200, 20);
            this.inputKorIme.TabIndex = 0;
            // 
            // korIme
            // 
            this.korIme.AutoSize = true;
            this.korIme.Location = new System.Drawing.Point(279, 283);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(75, 13);
            this.korIme.TabIndex = 1;
            this.korIme.Text = "Korisničko ime";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Location = new System.Drawing.Point(279, 322);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(44, 13);
            this.lozinka.TabIndex = 2;
            this.lozinka.Text = "Lozinka";
            // 
            // inputLozinka
            // 
            this.inputLozinka.Location = new System.Drawing.Point(300, 338);
            this.inputLozinka.Name = "inputLozinka";
            this.inputLozinka.Size = new System.Drawing.Size(200, 20);
            this.inputLozinka.TabIndex = 3;
            this.inputLozinka.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(365, 368);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 23);
            this.prijavaButton.TabIndex = 5;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // linkProvjera
            // 
            this.linkProvjera.AutoSize = true;
            this.linkProvjera.Location = new System.Drawing.Point(13, 536);
            this.linkProvjera.Name = "linkProvjera";
            this.linkProvjera.Size = new System.Drawing.Size(176, 13);
            this.linkProvjera.TabIndex = 6;
            this.linkProvjera.TabStop = true;
            this.linkProvjera.Text = "Provjeri ispričnicu po serijskom broju";
            this.linkProvjera.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelaProvjera_LinkClicked);
            // 
            // linkRegistracija
            // 
            this.linkRegistracija.AutoSize = true;
            this.linkRegistracija.Location = new System.Drawing.Point(332, 404);
            this.linkRegistracija.Name = "linkRegistracija";
            this.linkRegistracija.Size = new System.Drawing.Size(142, 13);
            this.linkRegistracija.TabIndex = 7;
            this.linkRegistracija.TabStop = true;
            this.linkRegistracija.Text = "Nemaš račun? Registriraj se!";
            this.linkRegistracija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.linkRegistracija);
            this.Controls.Add(this.linkProvjera);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputLozinka);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.inputKorIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prijava";
            this.Text = "eIspričnice - Prijava u aplikaciju";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputKorIme;
        private System.Windows.Forms.Label korIme;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.TextBox inputLozinka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.LinkLabel linkProvjera;
        private System.Windows.Forms.LinkLabel linkRegistracija;
    }
}

