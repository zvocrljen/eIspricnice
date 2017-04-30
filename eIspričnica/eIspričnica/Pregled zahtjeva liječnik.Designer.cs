namespace eIspričnica
{
    partial class Pregled_zahtjeva_liječnik
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
            this.neodobreno = new System.Windows.Forms.ListBox();
            this.odobreno = new System.Windows.Forms.ListBox();
            this.odabirZahtjeva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neodobreno
            // 
            this.neodobreno.FormattingEnabled = true;
            this.neodobreno.Location = new System.Drawing.Point(47, 75);
            this.neodobreno.Name = "neodobreno";
            this.neodobreno.Size = new System.Drawing.Size(250, 446);
            this.neodobreno.TabIndex = 0;
            // 
            // odobreno
            // 
            this.odobreno.FormattingEnabled = true;
            this.odobreno.Location = new System.Drawing.Point(351, 75);
            this.odobreno.Name = "odobreno";
            this.odobreno.Size = new System.Drawing.Size(250, 446);
            this.odobreno.TabIndex = 1;
            // 
            // odabirZahtjeva
            // 
            this.odabirZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.odabirZahtjeva.Location = new System.Drawing.Point(658, 473);
            this.odabirZahtjeva.Name = "odabirZahtjeva";
            this.odabirZahtjeva.Size = new System.Drawing.Size(100, 48);
            this.odabirZahtjeva.TabIndex = 2;
            this.odabirZahtjeva.Text = "Odabir";
            this.odabirZahtjeva.UseVisualStyleBackColor = true;
            // 
            // Pregled_zahtjeva_liječnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.odabirZahtjeva);
            this.Controls.Add(this.odobreno);
            this.Controls.Add(this.neodobreno);
            this.Name = "Pregled_zahtjeva_liječnik";
            this.Text = "Pregled_zahtjeva_liječnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox neodobreno;
        private System.Windows.Forms.ListBox odobreno;
        private System.Windows.Forms.Button odabirZahtjeva;
    }
}