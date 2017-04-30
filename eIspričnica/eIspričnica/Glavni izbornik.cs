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
    public partial class Glavni_izbornik : Form
    {
        Upis_pacijenata upis = new Upis_pacijenata();
        Statistika statistika = new Statistika();
        public Glavni_izbornik()
        {
            InitializeComponent();
        }

        private void upisButton_Click(object sender, EventArgs e)
        {
            upis.Show();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            statistika.Show();
        }

        private void Glavni_izbornik_Load(object sender, EventArgs e)
        {

        }
    }
}
