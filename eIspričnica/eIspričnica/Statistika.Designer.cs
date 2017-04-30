namespace eIspričnica
{
    partial class Statistika
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
            this.inputPretraživanje = new System.Windows.Forms.TextBox();
            this.pretraživanje = new System.Windows.Forms.Label();
            this.pacijentiIDoktoriDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PDFButton = new System.Windows.Forms.Button();
            this.ispisButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiIDoktoriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPretraživanje
            // 
            this.inputPretraživanje.Location = new System.Drawing.Point(131, 67);
            this.inputPretraživanje.Name = "inputPretraživanje";
            this.inputPretraživanje.Size = new System.Drawing.Size(147, 20);
            this.inputPretraživanje.TabIndex = 0;
            // 
            // pretraživanje
            // 
            this.pretraživanje.AutoSize = true;
            this.pretraživanje.Location = new System.Drawing.Point(128, 51);
            this.pretraživanje.Name = "pretraživanje";
            this.pretraživanje.Size = new System.Drawing.Size(68, 13);
            this.pretraživanje.TabIndex = 1;
            this.pretraživanje.Text = "Pretraživanje";
            // 
            // pacijentiIDoktoriDataGridView
            // 
            this.pacijentiIDoktoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacijentiIDoktoriDataGridView.Location = new System.Drawing.Point(131, 122);
            this.pacijentiIDoktoriDataGridView.Name = "pacijentiIDoktoriDataGridView";
            this.pacijentiIDoktoriDataGridView.Size = new System.Drawing.Size(240, 150);
            this.pacijentiIDoktoriDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis pacijenata i doktora";
            // 
            // PDFButton
            // 
            this.PDFButton.Location = new System.Drawing.Point(131, 299);
            this.PDFButton.Name = "PDFButton";
            this.PDFButton.Size = new System.Drawing.Size(102, 23);
            this.PDFButton.TabIndex = 4;
            this.PDFButton.Text = "PDF dokument";
            this.PDFButton.UseVisualStyleBackColor = true;
            // 
            // ispisButton
            // 
            this.ispisButton.Location = new System.Drawing.Point(269, 299);
            this.ispisButton.Name = "ispisButton";
            this.ispisButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ispisButton.Size = new System.Drawing.Size(102, 23);
            this.ispisButton.TabIndex = 5;
            this.ispisButton.Text = "Ispis";
            this.ispisButton.UseVisualStyleBackColor = true;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 405);
            this.Controls.Add(this.ispisButton);
            this.Controls.Add(this.PDFButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pacijentiIDoktoriDataGridView);
            this.Controls.Add(this.pretraživanje);
            this.Controls.Add(this.inputPretraživanje);
            this.Name = "Statistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiIDoktoriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPretraživanje;
        private System.Windows.Forms.Label pretraživanje;
        private System.Windows.Forms.DataGridView pacijentiIDoktoriDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PDFButton;
        private System.Windows.Forms.Button ispisButton;
    }
}