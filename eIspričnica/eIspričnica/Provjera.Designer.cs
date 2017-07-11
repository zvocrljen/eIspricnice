namespace eIspričnica
{
    partial class Provjera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provjera));
            this.ucSerBr = new System.Windows.Forms.Label();
            this.serijskiBroj1 = new eIspričnica.SerijskiBroj();
            this.SuspendLayout();
            // 
            // ucSerBr
            // 
            this.ucSerBr.AutoSize = true;
            this.ucSerBr.Location = new System.Drawing.Point(144, 163);
            this.ucSerBr.Name = "ucSerBr";
            this.ucSerBr.Size = new System.Drawing.Size(63, 13);
            this.ucSerBr.TabIndex = 0;
            this.ucSerBr.Text = "Serijski broj:";
            // 
            // serijskiBroj1
            // 
            this.serijskiBroj1.Location = new System.Drawing.Point(147, 181);
            this.serijskiBroj1.Name = "serijskiBroj1";
            this.serijskiBroj1.Size = new System.Drawing.Size(409, 92);
            this.serijskiBroj1.TabIndex = 2;
            // 
            // Provjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.serijskiBroj1);
            this.Controls.Add(this.ucSerBr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Provjera";
            this.Text = "eIspričnice - Provjera po serijskom broju";
            this.Load += new System.EventHandler(this.Provjera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ucSerBr;
        private SerijskiBroj serijskiBroj1;
    }
}