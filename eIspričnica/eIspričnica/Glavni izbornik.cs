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
            SkiravnjeGumba(sess);
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
                Help.ShowHelp(null, helpLocation, HelpNavigator.Topic, "IDH_Topic40.htm");
            }
        }
        private void SkiravnjeGumba(Sesija sess)
        {
            if (sess.RazinaPrava == 2) btnAdmin.Enabled = true;
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

        private void adminButton_Click(object sender, EventArgs e)
<<<<<<< Updated upstream
=======
        {
            frmAdministracija admin = new frmAdministracija(session);
            admin.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPregled_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            frmPregledZahtjeva zahtjev = new frmPregledZahtjeva(session);
            zahtjev.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
