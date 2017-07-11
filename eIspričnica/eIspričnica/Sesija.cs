using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eIspričnica
{
    public class Sesija
    {
        public string ImePrezime { get; set; }
        public int RazinaPrava { get; set; }
        public int Bolnica { get; set; }
        public Sesija(string preime, int razina, int bolnica)
        {
            ImePrezime = preime;
            RazinaPrava = razina;
            Bolnica = bolnica;
        }
    }
}
