namespace eIspričnica
{
    partial class frmAdmin_urediPacijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin_urediPacijenta));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblBrojIskaznice = new System.Windows.Forms.Label();
            this.lblBrojPolice = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtBrojPolice = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtPreIme = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBrojZdravstvene = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(105, 229);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(207, 23);
            this.btnSpremi.TabIndex = 25;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(56, 166);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 24;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblBrojIskaznice
            // 
            this.lblBrojIskaznice.AutoSize = true;
            this.lblBrojIskaznice.Location = new System.Drawing.Point(26, 139);
            this.lblBrojIskaznice.Name = "lblBrojIskaznice";
            this.lblBrojIskaznice.Size = new System.Drawing.Size(75, 13);
            this.lblBrojIskaznice.TabIndex = 22;
            this.lblBrojIskaznice.Text = "Broj iskaznice:";
            // 
            // lblBrojPolice
            // 
            this.lblBrojPolice.AutoSize = true;
            this.lblBrojPolice.Location = new System.Drawing.Point(42, 113);
            this.lblBrojPolice.Name = "lblBrojPolice";
            this.lblBrojPolice.Size = new System.Drawing.Size(59, 13);
            this.lblBrojPolice.TabIndex = 20;
            this.lblBrojPolice.Text = "Broj police:";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(73, 87);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(28, 13);
            this.lblOIB.TabIndex = 19;
            this.lblOIB.Text = "OIB:";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(30, 61);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(71, 13);
            this.lblImePrezime.TabIndex = 18;
            this.lblImePrezime.Text = "Ime i prezime:";
            // 
            // txtBrojPolice
            // 
            this.txtBrojPolice.Location = new System.Drawing.Point(105, 110);
            this.txtBrojPolice.Name = "txtBrojPolice";
            this.txtBrojPolice.Size = new System.Drawing.Size(207, 20);
            this.txtBrojPolice.TabIndex = 17;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(105, 84);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(207, 20);
            this.txtOIB.TabIndex = 16;
            // 
            // txtPreIme
            // 
            this.txtPreIme.Location = new System.Drawing.Point(105, 58);
            this.txtPreIme.Name = "txtPreIme";
            this.txtPreIme.Size = new System.Drawing.Size(207, 20);
            this.txtPreIme.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(80, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 13;
            // 
            // txtBrojZdravstvene
            // 
            this.txtBrojZdravstvene.Location = new System.Drawing.Point(105, 136);
            this.txtBrojZdravstvene.Name = "txtBrojZdravstvene";
            this.txtBrojZdravstvene.Size = new System.Drawing.Size(207, 20);
            this.txtBrojZdravstvene.TabIndex = 26;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(105, 163);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(207, 20);
            this.txtLozinka.TabIndex = 27;
            this.txtLozinka.Click += new System.EventHandler(this.txtLozinka_Click);
            // 
            // frmAdmin_urediPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 278);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtBrojZdravstvene);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblBrojIskaznice);
            this.Controls.Add(this.lblBrojPolice);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.txtBrojPolice);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtPreIme);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin_urediPacijenta";
            this.Text = "eIspričnice - Uredi pacijenta";
            this.Load += new System.EventHandler(this.frmAdmin_urediPacijenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblBrojIskaznice;
        private System.Windows.Forms.Label lblBrojPolice;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtBrojPolice;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtPreIme;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBrojZdravstvene;
        private System.Windows.Forms.TextBox txtLozinka;
    }
}