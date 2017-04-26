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
            this.SerBr = new System.Windows.Forms.Label();
            this.serijskiBroj1 = new eIspričnica.SerijskiBroj();
            this.SuspendLayout();
            // 
            // SerBr
            // 
            this.SerBr.AutoSize = true;
            this.SerBr.Location = new System.Drawing.Point(144, 172);
            this.SerBr.Name = "SerBr";
            this.SerBr.Size = new System.Drawing.Size(63, 13);
            this.SerBr.TabIndex = 0;
            this.SerBr.Text = "Serijski broj:";
            // 
            // serijskiBroj1
            // 
            this.serijskiBroj1.Location = new System.Drawing.Point(147, 188);
            this.serijskiBroj1.Name = "serijskiBroj1";
            this.serijskiBroj1.Size = new System.Drawing.Size(186, 29);
            this.serijskiBroj1.TabIndex = 1;
            // 
            // Provjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.serijskiBroj1);
            this.Controls.Add(this.SerBr);
            this.Name = "Provjera";
            this.Text = "labe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SerBr;
        private SerijskiBroj serijskiBroj1;
    }
}