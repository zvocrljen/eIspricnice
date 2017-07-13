using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DBService
{
    public class Login
    {
        private MySql.Data.MySqlClient.MySqlConnection konekcija = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Port=3306;Database=mydb;Uid=root;Pwd=root;");
        public static string sha256(string rijec)
        {
            byte[] poljeByteova = Encoding.UTF8.GetBytes(rijec);
            SHA256Managed hashRijec = new SHA256Managed();
            byte[] hash = hashRijec.ComputeHash(poljeByteova);
            string izlaz = "";
            foreach (byte b in hash)
            {
                izlaz += String.Format("{0:x2}", b);
            }
            return izlaz;
        }
        public string DohvatiKorisnika(string Username, string Password)
        {
            try
            {
                string cmdText = "select imeprezime, RazinaPrava_idRazinaPrava, (select datum_prijave from prijave where zaposlenici_idzaposlenici=(select idzaposlenici from zaposlenici where korIme=@korIme and korLozinka=@lozinka)), bolnica_idbolnica from zaposlenici where korIme=@korIme and korLozinka=@lozinka;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(cmdText, konekcija);
                konekcija.Open();
                cmd.Parameters.AddWithValue("@korIme", sha256(Username));
                cmd.Parameters.AddWithValue("@lozinka", sha256(Password));
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader[0].ToString() + ";" + reader[1].ToString() + ";" + reader[2].ToString() + ";" + reader[3].ToString();
                }
                else return "";
            }
            catch
            {
                return "null";
            }
        }
        public string Provjera(string SerijskiBroj)
        {
            try
            {
                string cmdText = "select imeprezime, (select datum_odobrenja from ispričnice where idIspričnica=@serijskibroj) from pacijenti where idpacijenti=(select pacijenti_idpacijenti from zahtjevi where idzahtjevi=(select zahtjevi_idzahtjevi from ispričnice where idIspričnica=@serijskibroj));";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(cmdText, konekcija);
                konekcija.Open();
                cmd.Parameters.AddWithValue("@serijskibroj", SerijskiBroj);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader[0].ToString() + "\r\n" + reader[1].ToString();
                }
                else return "";
            }
            catch
            {
                return "null";
            }
        }
    }
}
