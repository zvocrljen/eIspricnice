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
    public partial class Registracija : Form
    {
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Registracija_KeyDown);
        }

        private void Registracija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, helpLocation);
            }
        }

        private void inputOIB_TextChanged(object sender, EventArgs e)
        {
            inputOIB.BackColor = Color.White;
        }

        private void registracijaButton_Click_1(object sender, EventArgs e)
        {
            if (inputOIB.Text.Length != 13)
            {
                MessageBox.Show("OIB mora sadržavati točno 13 brojki!");
                inputOIB.BackColor = Color.Red;
            }
        }
    }
}
