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
    public partial class FormAdministracija : Form
    {
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        public FormAdministracija()
        {
            InitializeComponent();
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

        private void inputKorisnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void outputKorisnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnDodijeli_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {

        }
    }
}
