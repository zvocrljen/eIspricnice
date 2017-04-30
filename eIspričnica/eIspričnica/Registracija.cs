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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
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

        private void Registracija_Load(object sender, EventArgs e)
        {

        }
    }
}
