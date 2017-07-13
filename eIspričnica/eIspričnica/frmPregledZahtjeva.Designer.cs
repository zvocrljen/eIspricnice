namespace eIspričnica
{
    partial class frmPregledZahtjeva
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
            this.components = new System.ComponentModel.Container();
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviDataGridView = new System.Windows.Forms.DataGridView();
            this.ispričniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idZahtjeviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentiidPacijentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispričniceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataSource = typeof(eIspričnica.zahtjevi);
            // 
            // zahtjeviDataGridView
            // 
            this.zahtjeviDataGridView.AllowUserToAddRows = false;
            this.zahtjeviDataGridView.AutoGenerateColumns = false;
            this.zahtjeviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zahtjeviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZahtjeviDataGridViewTextBoxColumn,
            this.pacijentiidPacijentiDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumodDataGridViewTextBoxColumn,
            this.datumdoDataGridViewTextBoxColumn});
            this.zahtjeviDataGridView.DataSource = this.zahtjeviBindingSource;
            this.zahtjeviDataGridView.Location = new System.Drawing.Point(12, 12);
            this.zahtjeviDataGridView.Name = "zahtjeviDataGridView";
            this.zahtjeviDataGridView.ReadOnly = true;
            this.zahtjeviDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zahtjeviDataGridView.Size = new System.Drawing.Size(760, 220);
            this.zahtjeviDataGridView.TabIndex = 1;
            // 
            // ispričniceBindingSource
            // 
            this.ispričniceBindingSource.DataMember = "ispričnice";
            this.ispričniceBindingSource.DataSource = this.zahtjeviBindingSource;
            // 
            // idZahtjeviDataGridViewTextBoxColumn
            // 
            this.idZahtjeviDataGridViewTextBoxColumn.DataPropertyName = "idZahtjevi";
            this.idZahtjeviDataGridViewTextBoxColumn.HeaderText = "idZahtjevi";
            this.idZahtjeviDataGridViewTextBoxColumn.Name = "idZahtjeviDataGridViewTextBoxColumn";
            this.idZahtjeviDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacijentiidPacijentiDataGridViewTextBoxColumn
            // 
            this.pacijentiidPacijentiDataGridViewTextBoxColumn.DataPropertyName = "Pacijenti_idPacijenti";
            this.pacijentiidPacijentiDataGridViewTextBoxColumn.HeaderText = "Pacijenti_idPacijenti";
            this.pacijentiidPacijentiDataGridViewTextBoxColumn.Name = "pacijentiidPacijentiDataGridViewTextBoxColumn";
            this.pacijentiidPacijentiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumodDataGridViewTextBoxColumn
            // 
            this.datumodDataGridViewTextBoxColumn.DataPropertyName = "Datum_od";
            this.datumodDataGridViewTextBoxColumn.HeaderText = "Datum_od";
            this.datumodDataGridViewTextBoxColumn.Name = "datumodDataGridViewTextBoxColumn";
            this.datumodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumdoDataGridViewTextBoxColumn
            // 
            this.datumdoDataGridViewTextBoxColumn.DataPropertyName = "Datum_do";
            this.datumdoDataGridViewTextBoxColumn.HeaderText = "Datum_do";
            this.datumdoDataGridViewTextBoxColumn.Name = "datumdoDataGridViewTextBoxColumn";
            this.datumdoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPregledZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.zahtjeviDataGridView);
            this.Name = "frmPregledZahtjeva";
            this.Text = "Pregled zahtjeva";
            this.Load += new System.EventHandler(this.frmPregledZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispričniceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private System.Windows.Forms.DataGridView zahtjeviDataGridView;
        private System.Windows.Forms.BindingSource ispričniceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZahtjeviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentiidPacijentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumdoDataGridViewTextBoxColumn;
    }
}