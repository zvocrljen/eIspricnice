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
            this.btnDodajPregled = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.datumPregled = new System.Windows.Forms.DateTimePicker();
            this.zahtjeviDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new eIspričnica.mydbDataSet();
            this.zahtjeviTableAdapter = new eIspričnica.mydbDataSetTableAdapters.zahtjeviTableAdapter();
            this.tableAdapterManager = new eIspričnica.mydbDataSetTableAdapters.TableAdapterManager();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacijentiTableAdapter = new eIspričnica.mydbDataSetTableAdapters.pacijentiTableAdapter();
            this.pacijentiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preglediBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preglediTableAdapter = new eIspričnica.mydbDataSetTableAdapters.preglediTableAdapter();
            this.preglediDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preglediBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preglediDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajPregled
            // 
            this.btnDodajPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPregled.Location = new System.Drawing.Point(272, 428);
            this.btnDodajPregled.Name = "btnDodajPregled";
            this.btnDodajPregled.Size = new System.Drawing.Size(112, 37);
            this.btnDodajPregled.TabIndex = 2;
            this.btnDodajPregled.Text = "Dodaj pregled";
            this.btnDodajPregled.UseVisualStyleBackColor = true;
            this.btnDodajPregled.Click += new System.EventHandler(this.btnDodajPregled_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdobri.Location = new System.Drawing.Point(616, 71);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(128, 71);
            this.btnOdobri.TabIndex = 3;
            this.btnOdobri.Text = "Odobri zahtjev";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // datumPregled
            // 
            this.datumPregled.Location = new System.Drawing.Point(41, 445);
            this.datumPregled.Name = "datumPregled";
            this.datumPregled.Size = new System.Drawing.Size(200, 20);
            this.datumPregled.TabIndex = 4;
            // 
            // zahtjeviDataGridView
            // 
            this.zahtjeviDataGridView.AllowUserToAddRows = false;
            this.zahtjeviDataGridView.AutoGenerateColumns = false;
            this.zahtjeviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zahtjeviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.zahtjeviDataGridView.DataSource = this.zahtjeviBindingSource;
            this.zahtjeviDataGridView.Location = new System.Drawing.Point(12, 53);
            this.zahtjeviDataGridView.Name = "zahtjeviDataGridView";
            this.zahtjeviDataGridView.ReadOnly = true;
            this.zahtjeviDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zahtjeviDataGridView.Size = new System.Drawing.Size(543, 178);
            this.zahtjeviDataGridView.TabIndex = 5;
            this.zahtjeviDataGridView.SelectionChanged += new System.EventHandler(this.zahtjeviDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idZahtjevi";
            this.dataGridViewTextBoxColumn1.HeaderText = "idZahtjevi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pacijenti_idPacijenti";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pacijenti_idPacijenti";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum_od";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum_od";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Datum_do";
            this.dataGridViewTextBoxColumn5.HeaderText = "Datum_do";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataMember = "zahtjevi";
            this.zahtjeviBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjeviTableAdapter
            // 
            this.zahtjeviTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bolnicaTableAdapter = null;
            this.tableAdapterManager.ispričniceTableAdapter = null;
            this.tableAdapterManager.pacijentiTableAdapter = null;
            this.tableAdapterManager.povijestbolestiTableAdapter = null;
            this.tableAdapterManager.preglediTableAdapter = null;
            this.tableAdapterManager.prijaveTableAdapter = null;
            this.tableAdapterManager.razinapravaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eIspričnica.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zahtjeviTableAdapter = this.zahtjeviTableAdapter;
            this.tableAdapterManager.zaposleniciTableAdapter = null;
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataMember = "pacijenti";
            this.pacijentiBindingSource.DataSource = this.mydbDataSet;
            // 
            // pacijentiTableAdapter
            // 
            this.pacijentiTableAdapter.ClearBeforeFill = true;
            // 
            // pacijentiDataGridView
            // 
            this.pacijentiDataGridView.AllowUserToAddRows = false;
            this.pacijentiDataGridView.AllowUserToDeleteRows = false;
            this.pacijentiDataGridView.AutoGenerateColumns = false;
            this.pacijentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacijentiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.pacijentiDataGridView.DataSource = this.pacijentiBindingSource;
            this.pacijentiDataGridView.Location = new System.Drawing.Point(12, 286);
            this.pacijentiDataGridView.Name = "pacijentiDataGridView";
            this.pacijentiDataGridView.ReadOnly = true;
            this.pacijentiDataGridView.Size = new System.Drawing.Size(444, 46);
            this.pacijentiDataGridView.TabIndex = 5;
            this.pacijentiDataGridView.SelectionChanged += new System.EventHandler(this.pacijentiDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idPacijenti";
            this.dataGridViewTextBoxColumn6.HeaderText = "idPacijenti";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ImePrezime";
            this.dataGridViewTextBoxColumn7.HeaderText = "ImePrezime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OIB";
            this.dataGridViewTextBoxColumn8.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BrojPoliceOsiguranja";
            this.dataGridViewTextBoxColumn9.HeaderText = "BrojPoliceOsiguranja";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BrojZdravstveneIskaznice";
            this.dataGridViewTextBoxColumn10.HeaderText = "BrojZdravstveneIskaznice";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "lozinka";
            this.dataGridViewTextBoxColumn11.HeaderText = "lozinka";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Zaposlenici_idZaposlenici";
            this.dataGridViewTextBoxColumn12.HeaderText = "Zaposlenici_idZaposlenici";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // zahtjevi
            // 
            this.zahtjevi.AutoSize = true;
            this.zahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zahtjevi.Location = new System.Drawing.Point(9, 20);
            this.zahtjevi.Name = "zahtjevi";
            this.zahtjevi.Size = new System.Drawing.Size(64, 20);
            this.zahtjevi.TabIndex = 6;
            this.zahtjevi.Text = "Zahtjevi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pacijent";
            // 
            // preglediBindingSource
            // 
            this.preglediBindingSource.DataMember = "pregledi";
            this.preglediBindingSource.DataSource = this.mydbDataSet;
            // 
            // preglediTableAdapter
            // 
            this.preglediTableAdapter.ClearBeforeFill = true;
            // 
            // preglediDataGridView
            // 
            this.preglediDataGridView.AutoGenerateColumns = false;
            this.preglediDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preglediDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.preglediDataGridView.DataSource = this.preglediBindingSource;
            this.preglediDataGridView.Location = new System.Drawing.Point(528, 286);
            this.preglediDataGridView.Name = "preglediDataGridView";
            this.preglediDataGridView.Size = new System.Drawing.Size(244, 220);
            this.preglediDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "idPregledi";
            this.dataGridViewTextBoxColumn13.HeaderText = "idPregledi";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Pacijenti_idPacijenti";
            this.dataGridViewTextBoxColumn14.HeaderText = "Pacijenti_idPacijenti";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Datum_pregleda";
            this.dataGridViewTextBoxColumn15.HeaderText = "Datum_pregleda";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // frmPregledZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.preglediDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zahtjevi);
            this.Controls.Add(this.pacijentiDataGridView);
            this.Controls.Add(this.zahtjeviDataGridView);
            this.Controls.Add(this.datumPregled);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.btnDodajPregled);
            this.Name = "frmPregledZahtjeva";
            this.Text = "Pregled zahtjeva";
            this.Load += new System.EventHandler(this.frmPregledZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preglediBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preglediDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajPregled;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.DateTimePicker datumPregled;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private mydbDataSetTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zahtjeviDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private mydbDataSetTableAdapters.pacijentiTableAdapter pacijentiTableAdapter;
        private System.Windows.Forms.DataGridView pacijentiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label zahtjevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource preglediBindingSource;
        private mydbDataSetTableAdapters.preglediTableAdapter preglediTableAdapter;
        private System.Windows.Forms.DataGridView preglediDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}