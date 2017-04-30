namespace eIspričnica
{
    partial class Pregled_zahtjeva
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
            this.listaZahtjeva = new System.Windows.Forms.ListBox();
            this.odabirZahtjeva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaZahtjeva
            // 
            this.listaZahtjeva.FormattingEnabled = true;
            this.listaZahtjeva.Location = new System.Drawing.Point(53, 35);
            this.listaZahtjeva.Name = "listaZahtjeva";
            this.listaZahtjeva.Size = new System.Drawing.Size(352, 472);
            this.listaZahtjeva.TabIndex = 0;
            // 
            // odabirZahtjeva
            // 
            this.odabirZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.odabirZahtjeva.Location = new System.Drawing.Point(535, 461);
            this.odabirZahtjeva.Name = "odabirZahtjeva";
            this.odabirZahtjeva.Size = new System.Drawing.Size(125, 46);
            this.odabirZahtjeva.TabIndex = 1;
            this.odabirZahtjeva.Text = "Odabir";
            this.odabirZahtjeva.UseVisualStyleBackColor = true;
            // 
            // Pregled_zahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 541);
            this.Controls.Add(this.odabirZahtjeva);
            this.Controls.Add(this.listaZahtjeva);
            this.Name = "Pregled_zahtjeva";
            this.Text = "Pregled_zahtjeva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaZahtjeva;
        private System.Windows.Forms.Button odabirZahtjeva;
    }
}