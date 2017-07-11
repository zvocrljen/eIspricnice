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
    public partial class frmAdmin_urediPacijenta : Form
    {
        pacijenti odabraniPacijent;
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
        public frmAdmin_urediPacijenta(pacijenti pacijent)
        {
            InitializeComponent();
            odabraniPacijent = pacijent;
        }

        private void txtLozinka_Click(object sender, EventArgs e)
        {
            txtLozinka.Clear();
        }

        private void frmAdmin_urediPacijenta_Load(object sender, EventArgs e)
        {
            if (odabraniPacijent != null)
            {
                txtID.Text = odabraniPacijent.idPacijenti.ToString();
                txtPreIme.Text = odabraniPacijent.ImePrezime.ToString();
                txtOIB.Text = odabraniPacijent.OIB.ToString();
                txtBrojPolice.Text = odabraniPacijent.BrojPoliceOsiguranja.ToString();
                txtBrojZdravstvene.Text = odabraniPacijent.BrojZdravstveneIskaznice.ToString();
                txtLozinka.Text = odabraniPacijent.lozinka.ToString();
            }
            else
            {
                txtID.Text = "-1";
                txtPreIme.Focus();
            }
        }
    }
}
