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
    public partial class Upis_pacijenata : Form
    {
        Registracija reg = new Registracija();
        public Upis_pacijenata()
        {
            InitializeComponent();
        }

        private void linkRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg.Show();
        }
    }
}
