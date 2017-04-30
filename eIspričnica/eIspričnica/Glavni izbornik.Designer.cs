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
            this.predajButton = new System.Windows.Forms.Button();
            this.pregledButton = new System.Windows.Forms.Button();
            this.upisButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.odjavaButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // predajButton
            // 
            this.predajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.predajButton.Location = new System.Drawing.Point(84, 61);
            this.predajButton.Name = "predajButton";
            this.predajButton.Size = new System.Drawing.Size(613, 69);
            this.predajButton.TabIndex = 0;
            this.predajButton.Text = "Predaja zahtjeva za ispričnicom";
            this.predajButton.UseVisualStyleBackColor = true;
            // 
            // pregledButton
            // 
            this.pregledButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pregledButton.Location = new System.Drawing.Point(84, 136);
            this.pregledButton.Name = "pregledButton";
            this.pregledButton.Size = new System.Drawing.Size(613, 69);
            this.pregledButton.TabIndex = 1;
            this.pregledButton.Text = "Pregled zahtjeva za ispričnicom";
            this.pregledButton.UseVisualStyleBackColor = true;
            // 
            // upisButton
            // 
            this.upisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.upisButton.Location = new System.Drawing.Point(84, 211);
            this.upisButton.Name = "upisButton";
            this.upisButton.Size = new System.Drawing.Size(613, 69);
            this.upisButton.TabIndex = 2;
            this.upisButton.Text = "Upis pacijenta u Bazu Podataka";
            this.upisButton.UseVisualStyleBackColor = true;
            // 
            // statButton
            // 
            this.statButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statButton.Location = new System.Drawing.Point(84, 286);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(613, 69);
            this.statButton.TabIndex = 3;
            this.statButton.Text = "Statistika";
            this.statButton.UseVisualStyleBackColor = true;
            // 
            // odjavaButton
            // 
            this.odjavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odjavaButton.Location = new System.Drawing.Point(246, 436);
            this.odjavaButton.Name = "odjavaButton";
            this.odjavaButton.Size = new System.Drawing.Size(296, 69);
            this.odjavaButton.TabIndex = 4;
            this.odjavaButton.Text = "Odjavi se";
            this.odjavaButton.UseVisualStyleBackColor = true;
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminButton.Location = new System.Drawing.Point(246, 361);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(296, 69);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "Administracija korisnika";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // Glavni_izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.odjavaButton);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.upisButton);
            this.Controls.Add(this.pregledButton);
            this.Controls.Add(this.predajButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glavni_izbornik";
            this.Text = "eIspričnice - Glavni izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button predajButton;
        private System.Windows.Forms.Button pregledButton;
        private System.Windows.Forms.Button upisButton;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.Button odjavaButton;
        private System.Windows.Forms.Button adminButton;
    }
}