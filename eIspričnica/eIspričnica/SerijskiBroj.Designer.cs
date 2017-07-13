namespace eIspričnica
{
    partial class SerijskiBroj
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBroj1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBroj2 = new System.Windows.Forms.TextBox();
            this.txtBroj3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBroj5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.txtBroj4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBroj1
            // 
            this.txtBroj1.Location = new System.Drawing.Point(3, 3);
            this.txtBroj1.Name = "txtBroj1";
            this.txtBroj1.Size = new System.Drawing.Size(73, 20);
            this.txtBroj1.TabIndex = 0;
            this.txtBroj1.TextChanged += new System.EventHandler(this.txtBroj1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // txtBroj2
            // 
            this.txtBroj2.Location = new System.Drawing.Point(98, 3);
            this.txtBroj2.Name = "txtBroj2";
            this.txtBroj2.Size = new System.Drawing.Size(42, 20);
            this.txtBroj2.TabIndex = 1;
            this.txtBroj2.TextChanged += new System.EventHandler(this.txtBroj2_TextChanged);
            // 
            // txtBroj3
            // 
            this.txtBroj3.Location = new System.Drawing.Point(162, 3);
            this.txtBroj3.Name = "txtBroj3";
            this.txtBroj3.Size = new System.Drawing.Size(42, 20);
            this.txtBroj3.TabIndex = 2;
            this.txtBroj3.TextChanged += new System.EventHandler(this.txtBroj3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // txtBroj5
            // 
            this.txtBroj5.Location = new System.Drawing.Point(290, 3);
            this.txtBroj5.Name = "txtBroj5";
            this.txtBroj5.Size = new System.Drawing.Size(111, 20);
            this.txtBroj5.TabIndex = 4;
            this.txtBroj5.TextChanged += new System.EventHandler(this.txtBroj4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Location = new System.Drawing.Point(3, 44);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(75, 23);
            this.btnProvjeri.TabIndex = 5;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // txtBroj4
            // 
            this.txtBroj4.Location = new System.Drawing.Point(226, 3);
            this.txtBroj4.Name = "txtBroj4";
            this.txtBroj4.Size = new System.Drawing.Size(42, 20);
            this.txtBroj4.TabIndex = 3;
            this.txtBroj4.TextChanged += new System.EventHandler(this.txtBroj5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // SerijskiBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBroj4);
            this.Controls.Add(this.btnProvjeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBroj5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBroj3);
            this.Controls.Add(this.txtBroj2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBroj1);
            this.Name = "SerijskiBroj";
            this.Size = new System.Drawing.Size(409, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBroj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBroj2;
        private System.Windows.Forms.TextBox txtBroj3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBroj5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProvjeri;
        private System.Windows.Forms.TextBox txtBroj4;
        private System.Windows.Forms.Label label4;
    }
}
