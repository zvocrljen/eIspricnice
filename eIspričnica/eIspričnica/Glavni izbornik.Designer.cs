namespace eIspričnica
{
    partial class Glavni_izbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni_izbornik));
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregled
            // 
            this.btnPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPregled.Location = new System.Drawing.Point(84, 59);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(613, 69);
            this.btnPregled.TabIndex = 0;
            this.btnPregled.Text = "Pregled zahtjeva za ispričnicom";
            this.btnPregled.UseVisualStyleBackColor = true;
            // 
            // btnUpis
            // 
            this.btnUpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpis.Location = new System.Drawing.Point(84, 134);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(613, 69);
            this.btnUpis.TabIndex = 1;
            this.btnUpis.Text = "Upis pacijenta u Bazu Podataka";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.upisButton_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStats.Location = new System.Drawing.Point(84, 209);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(613, 69);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Statistika";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.statButton_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOdjava.Location = new System.Drawing.Point(246, 436);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(296, 69);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.odjavaButton_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Enabled = false;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdmin.Location = new System.Drawing.Point(246, 361);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(296, 69);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administracija korisnika";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Glavni_izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnUpis);
            this.Controls.Add(this.btnPregled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glavni_izbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eIspričnice - Glavni izbornik";
            this.Load += new System.EventHandler(this.Glavni_izbornik_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnAdmin;
    }
}