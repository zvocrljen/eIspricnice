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
    public partial class Provjera : Form
    {
        string helpLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\help.chm";
        public Provjera()
        {
            InitializeComponent();
        }
        private void Provjera_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Provjera_KeyDown);
        }
        private void Provjera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(null, helpLocation);
            }
        }
    }
}
