using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace eIspričnica
{
    public partial class frmAdministracija : Form
    {
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        Sesija session = new Sesija("0",0,0);
        public frmAdministracija(Sesija sess)
        {
            InitializeComponent();
            PrikaziZaposlenike();
            session = sess;
        }
        private void PrikaziPacijente(zaposlenici zaposlenik)
        {
            BindingList<pacijenti> listaPacijenata = null;
            using(var db=new mydbEntities1())
            {
                db.zaposlenici.Attach(zaposlenik);
                listaPacijenata = new BindingList<pacijenti>(zaposlenik.pacijenti.ToList<pacijenti>());
            }
            pacijentiBindingSource.DataSource = listaPacijenata;
        }
        private void PrikaziZaposlenike()
        {
            BindingList<zaposlenici> listaZaposlenika = null;
            using(var db=new mydbEntities1())
            {
                listaZaposlenika = new BindingList<zaposlenici>(db.zaposlenici.ToList());
            }
            zaposleniciBindingSource.DataSource = listaZaposlenika;
        }

        private void FormAdministracija_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Admin_KeyDown);
        }

        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, helpLocation);
            }
        }
        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (odabraniZaposlenik != null) PrikaziPacijente(odabraniZaposlenik);
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            zaposlenici nula = null;
            Form novi = new frmAdmin_noviLiječnik(nula);
            novi.ShowDialog();
            PrikaziZaposlenike();
        }
        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Form urediZaposlenika = new frmAdmin_noviLiječnik(zaposleniciBindingSource.Current as zaposlenici);
            urediZaposlenika.ShowDialog();
            PrikaziZaposlenike();
        }
        private void btnIzbrisi1_Click(object sender, EventArgs e)
        {
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (odabraniZaposlenik != null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite izbrisati liječnika?", "eIspričnice - Potvrda brisanja liječnika",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (var db = new mydbEntities1())
                    {
                        db.zaposlenici.Attach(odabraniZaposlenik);
                        if (odabraniZaposlenik.pacijenti.Count == 0 && odabraniZaposlenik.Bolnica_idBolnica == session.Bolnica)
                        {
                            db.zaposlenici.Remove(odabraniZaposlenik);
                            db.SaveChanges();
                        }
                        else if (odabraniZaposlenik.Bolnica_idBolnica != session.Bolnica)  
                        {
                            MessageBox.Show("Niste ovlašteni obrisati zaposlenika druge bolnice!", "eIspričnice - Greška #", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati liječnike koji imaju pacijente!", "eIspričnice - Greška #", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    PrikaziZaposlenike();
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali liječnika za brisanje!", "eIspričnice - Obavijest", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            Form urediPacijenta = new frmAdmin_urediPacijenta(pacijentiBindingSource.Current as pacijenti);
            urediPacijenta.ShowDialog();
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            PrikaziPacijente(odabraniZaposlenik);
        }
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            pacijenti odabraniPacijent = pacijentiBindingSource.Current as pacijenti;
            zaposlenici odabraniZaposlenik = zaposleniciBindingSource.Current as zaposlenici;
            if (odabraniPacijent != null)
            {
                if(MessageBox.Show("Jeste li sigurni da želite izbrisati pacijenta?", "eIspričnice - Potvrda brisanja pacijenta",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (var db = new mydbEntities1())
                    {
                        db.pacijenti.Attach(odabraniPacijent);
                        db.pacijenti.Remove(odabraniPacijent);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali pacijenta za brisanje!", "eIspričnice - Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PrikaziPacijente(odabraniZaposlenik);
        }
    }
}
