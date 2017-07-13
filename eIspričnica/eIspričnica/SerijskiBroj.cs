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

        private void txtBroj1_TextChanged(object sender, EventArgs e)
        {
            txtBroj1.BackColor = Color.White;
            try
            {
                if (txtBroj1.Text.Length > 8)
                {
                    txtBroj1.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice! Prvi broj mora imati 8 znamenki!");
                }
            }
            catch(NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka, "eIspričnice - Greška 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBroj2_TextChanged(object sender, EventArgs e)
        {
            txtBroj2.BackColor = Color.White;
            try
            {
                if (txtBroj2.Text.Length > 4)
                {
                    txtBroj2.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice! Drugi broj mora imati 4 znamenke!");
                }
            }
            catch(NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }
        }
        private void txtBroj3_TextChanged(object sender, EventArgs e)
        {
            txtBroj3.BackColor = Color.White;
            try
            {
                if (txtBroj3.Text.Length > 4)
                {
                    txtBroj3.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice! Drugi broj mora imati 4 znamenke!");
                }
            }
            catch (NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }
        }

        private void txtBroj4_TextChanged(object sender, EventArgs e)
        {
            txtBroj4.BackColor = Color.White;
            try
            {
                if (txtBroj4.Text.Length > 4)
                {
                    txtBroj4.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice! Drugi broj mora imati 4 znamenke!");
                }
            }
            catch (NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }
        }

        private void txtBroj5_TextChanged(object sender, EventArgs e)
        {
            txtBroj5.BackColor = Color.White;
            try
            {
                if (txtBroj5.Text.Length > 16)
                {
                    txtBroj5.BackColor = Color.Red;
                    throw new NeispravanSerijskiBroj("Neispravan serijski broj ispričnice! Drugi broj mora imati 4 znamenke!");
                }
            }
            catch (NeispravanSerijskiBroj ex)
            {
                MessageBox.Show(ex.DodatnaPoruka);
            }
        }
        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            DBService.Login prijava = new DBService.Login();
            string rezultat = prijava.Provjera(txtBroj1.Text + "-" + txtBroj2.Text + "-" + txtBroj3.Text + "-" + txtBroj4.Text + "-" + txtBroj5.Text);
            if (rezultat == "") MessageBox.Show("Ispričnica nije pronađena u bazi podataka!", "eIspričnice - Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rezultat == "null") MessageBox.Show("Greška 3: Povezivanje na bazu nije moguće!", "eIspričnice - Greška 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Ispričnica je pronađena! Podaci: \r\n" + rezultat, "eIspričnice - Podaci o ispričnici", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
