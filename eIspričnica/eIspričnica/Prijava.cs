using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eIspričnica
{
    public partial class Prijava : Form
    {
        Provjera provjera = new Provjera();
        Registracija reg = new Registracija();
        public Prijava()
        {
            InitializeComponent();
        }

        private void labelaProvjera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            provjera.Show();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg.Show();
        }
    }
}
