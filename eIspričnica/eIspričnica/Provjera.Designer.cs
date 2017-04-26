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
            this.SerBr = new System.Windows.Forms.Label();
            this.serijskiBroj1 = new eIspričnica.SerijskiBroj();
            this.provjeriButton = new System.Windows.Forms.Button();
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
            this.serijskiBroj1.Size = new System.Drawing.Size(184, 27);
            this.serijskiBroj1.TabIndex = 1;
            // 
            // provjeriButton
            // 
            this.provjeriButton.Location = new System.Drawing.Point(147, 221);
            this.provjeriButton.Name = "provjeriButton";
            this.provjeriButton.Size = new System.Drawing.Size(75, 23);
            this.provjeriButton.TabIndex = 2;
            this.provjeriButton.Text = "Provjeri";
            this.provjeriButton.UseVisualStyleBackColor = true;
            this.provjeriButton.Click += new System.EventHandler(this.provjeriButton_Click);
            // 
            // Provjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.provjeriButton);
            this.Controls.Add(this.serijskiBroj1);
            this.Controls.Add(this.SerBr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Provjera";
            this.Text = "eIspričnice - Provjera po serijskom broju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SerBr;
        private SerijskiBroj serijskiBroj1;
        private System.Windows.Forms.Button provjeriButton;
    }
}