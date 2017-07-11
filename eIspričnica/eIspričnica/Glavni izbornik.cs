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
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        Sesija session = new Sesija("0", 0, 0);
        public Glavni_izbornik(Sesija sess)
        {
            InitializeComponent();
            if (sess.RazinaPrava == 2) btnAdmin.Enabled=true;
            session = sess;
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
            Upis_pacijenata upis = new Upis_pacijenata();
            upis.ShowDialog();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            Statistika statistika = new Statistika();
            statistika.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            frmAdministracija admin = new frmAdministracija(session);
            admin.ShowDialog();
        }
    }
}
