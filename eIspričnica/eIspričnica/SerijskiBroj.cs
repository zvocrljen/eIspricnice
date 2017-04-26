using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eIspričnica
{
    public partial class SerijskiBroj : UserControl
    {
        public SerijskiBroj()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            try
            {
                if (textBox1.Text.Length > 3)
                {
                    textBox1.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice!");
                }
            }
            catch(NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            try
            {
                if (textBox2.Text.Length > 8)
                {
                    textBox2.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice!");
                }
            }
            catch(NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }
        }
    }
}
