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
    public partial class Glavni_izbornik : Form
    {
        Upis_pacijenata upis = new Upis_pacijenata();
        Statistika statistika = new Statistika();
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        public Glavni_izbornik()
        {
            InitializeComponent();
        }

        private void Glavni_izbornik_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Menu_KeyDown);
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, helpLocation);
            }
        }
        private void upisButton_Click(object sender, EventArgs e)
        {
            upis.Show();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            statistika.Show();
        }

        private void predajButton_Click(object sender, EventArgs e)
        {

        }
    }
}
