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
    public partial class Prijava : Form
    {
        Provjera provjera = new Provjera();
        Registracija reg = new Registracija();
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
                Help.ShowHelp(null, helpLocation);
            }
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
