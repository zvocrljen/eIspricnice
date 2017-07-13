using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eIspričnica
{
    public partial class frmPregledZahtjeva : Form
    {

        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        Sesija session = new Sesija("0", 0, 0);
        mydbDataSetTableAdapters.ispričniceTableAdapter ispričniceTableAdapter = new mydbDataSetTableAdapters.ispričniceTableAdapter();
        public frmPregledZahtjeva(Sesija sess)
        {
            InitializeComponent();
            session = sess;
            PrikaziZahtjeve();
            
            
        }

        private void PrikaziZahtjeve()
        {
            string doktorIme = session.ImePrezime.ToString();
            this.zahtjeviTableAdapter.FillBy(this.mydbDataSet.zahtjevi, doktorIme);
            if (zahtjeviDataGridView.RowCount > 0) {
                int pacijentId = int.Parse(zahtjeviDataGridView.CurrentRow.Cells[1].Value.ToString());
                this.pacijentiTableAdapter.FillBy(this.mydbDataSet.pacijenti, pacijentId);
                this.preglediTableAdapter.FillBy(this.mydbDataSet.pregledi, pacijentId);
            }
            else
            {
                this.pacijentiTableAdapter.Fill(this.mydbDataSet.pacijenti);
                this.preglediTableAdapter.Fill(this.mydbDataSet.pregledi);
            }
        }
        
        private void frmPregledZahtjeva_Load(object sender, EventArgs e)
        {
            

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Menu_KeyDown);
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, helpLocation, HelpNavigator.Topic, "IDH_Topic40.htm");
            }
        }

        private void btnDodajPregled_Click(object sender, EventArgs e)
        {
            if (pacijentiDataGridView.RowCount > 0)
            {
                System.DateTime datum = datumPregled.Value;
                int pacijentId = int.Parse(pacijentiDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.preglediTableAdapter.InsertQuery(pacijentId, datum);
                this.preglediTableAdapter.FillBy(this.mydbDataSet.pregledi, pacijentId);

            }
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            if (zahtjeviDataGridView.RowCount > 0)
            {
                int zahtjevID = int.Parse(zahtjeviDataGridView.CurrentRow.Cells[0].Value.ToString());
                ispričniceTableAdapter.InsertQuery(zahtjevID);
                PrikaziZahtjeve();
                
            }
        }

        private void zahtjeviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zahtjeviBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void zahtjeviDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(zahtjeviDataGridView.RowCount > 0)
            {
                int pacijentId = int.Parse(zahtjeviDataGridView.CurrentRow.Cells[1].Value.ToString());
                this.pacijentiTableAdapter.FillBy(this.mydbDataSet.pacijenti, pacijentId);
            }
        }

        private void pacijentiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (pacijentiDataGridView.RowCount > 0)
            {
                int pacijentId = int.Parse(pacijentiDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.preglediTableAdapter.FillBy(this.mydbDataSet.pregledi, pacijentId);
            }
        }
    }
}
