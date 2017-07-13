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
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace eIspričnica
{
    public partial class Prijava : Form
    {
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        public Prijava()
        {
            InitializeComponent();
        }
        private void Prijava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Prijava_KeyDown);
        }
        private void Prijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, helpLocation, HelpNavigator.Topic, "IDH_Topic10.htm");
            }
        }
        private void lnkProvjera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Provjera provjera = new Provjera();
            provjera.ShowDialog();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "" || txtLozinka.Text == "")
            {
                MessageBox.Show("Greška 1: Popunite prazne redove!", "eIspričnice - Greška 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBService.Login prijava = new DBService.Login();
            string rezultat = prijava.DohvatiKorisnika(txtKorIme.Text, txtLozinka.Text);
            if (rezultat == "")
            {
                MessageBox.Show("Greška 2: Neispravno korisničko ime ili lozinka!", "eIspričnice - Greška 4", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rezultat == "null")
            {
                MessageBox.Show("Greška 3: Povezivanje na bazu nije moguće!", "eIspričnice - Greška 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] rez = rezultat.Split(';');
                Sesija session = new Sesija(rez[0].ToString(), Convert.ToInt32(rez[1]), Convert.ToInt32(rez[3]));
                MessageBox.Show("Uspješna prijava!" + "\r\nPosljednja prijava: " + rez[2].ToString(), "eIspričnice - Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                Glavni_izbornik mm = new Glavni_izbornik(session);
                mm.ShowDialog();
                this.Close();
            }
         }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "Return")
            {
                prijavaButton_Click(sender, e);
            }
        }
    }
}
