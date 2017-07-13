using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eIspričnica
{
    public partial class frmPregledZahtjeva : Form
    {

        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        Sesija session = new Sesija("0", 0, 0);
        public frmPregledZahtjeva(Sesija sess)
        {
            InitializeComponent();
            PrikaziZahtjeve();
            session = sess;
        }

        private void PrikaziZahtjeve()
        {
            
            using (var db = new mydbEntities1())
            {
               var listaZahtjeva = new BindingList<zahtjevi>(db.zahtjevi.ToList());
                zahtjeviBindingSource.DataSource = listaZahtjeva;
            }
            
        }

        private void frmPregledZahtjeva_Load(object sender, EventArgs e)
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


    }
}
