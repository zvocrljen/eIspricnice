using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eIspričnica
{
    public partial class frmAdmin_noviLiječnik : Form
    {
        zaposlenici odabraniZaposlenik;
        public static string sha256(string rijec)
        {
            byte[] poljeByteova = Encoding.UTF8.GetBytes(rijec);
            SHA256Managed hashRijec = new SHA256Managed();
            byte[] hash = hashRijec.ComputeHash(poljeByteova);
            string izlaz = "";
            foreach (byte b in hash)
            {
                izlaz += String.Format("{0:x2}", b);
            }
            return izlaz;
        }
        public frmAdmin_noviLiječnik(zaposlenici zaposlenik)
        {
            InitializeComponent();
            odabraniZaposlenik = zaposlenik;
            BindingList<razinaprava> razine = null;
            using(var db = new mydbEntities1())
            {
                razine = new BindingList<razinaprava>(db.razinaprava.ToList());
            }
            cbRazinaPrava.DataSource = razine;
            BindingList<bolnica> bolnice = null;
            using(var db = new mydbEntities1())
            {
                bolnice = new BindingList<bolnica>(db.bolnica.ToList());
            }
            cbBolnica.DataSource = bolnice;
        }

        private void frmAdmin_novi_Load(object sender, EventArgs e)
        {
            if (odabraniZaposlenik != null)
            {
                txtID.Text = odabraniZaposlenik.idZaposlenici.ToString();
                txtPreIme.Text = odabraniZaposlenik.ImePrezime.ToString();
                txtKorIme.Text = odabraniZaposlenik.korIme.ToString();
                txtLozinka.Text = odabraniZaposlenik.korLozinka.ToString();
                cbRazinaPrava.SelectedIndex = Convert.ToInt32(odabraniZaposlenik.RazinaPrava_idRazinaPrava.ToString())-1;
                cbBolnica.SelectedIndex = Convert.ToInt32(odabraniZaposlenik.Bolnica_idBolnica.ToString())-1;
            }
            else
            {
                txtID.Text = "-1";
                txtPreIme.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new mydbEntities1())
            {
                if (odabraniZaposlenik != null)
                {
                    db.zaposlenici.Attach(odabraniZaposlenik);
                    odabraniZaposlenik.ImePrezime = txtPreIme.Text;
                    odabraniZaposlenik.korIme = sha256(txtKorIme.Text);
                    odabraniZaposlenik.korLozinka = sha256(txtLozinka.Text);
                    odabraniZaposlenik.RazinaPrava_idRazinaPrava = cbRazinaPrava.SelectedIndex + 1;
                    odabraniZaposlenik.Bolnica_idBolnica = cbBolnica.SelectedIndex + 1;
                    db.SaveChanges();
                }
                else
                {
                    zaposlenici zaposlenik = new zaposlenici
                    {
                        ImePrezime = txtPreIme.Text,
                        korIme = sha256(txtKorIme.Text),
                        korLozinka = sha256(txtLozinka.Text),
                        RazinaPrava_idRazinaPrava = cbRazinaPrava.SelectedIndex + 1,
                        Bolnica_idBolnica = cbBolnica.SelectedIndex + 1
                    };
                    db.zaposlenici.Add(zaposlenik);
                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}
