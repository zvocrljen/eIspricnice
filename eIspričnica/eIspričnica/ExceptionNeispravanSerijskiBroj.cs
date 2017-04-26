using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eIspričnica
{
    public class NeispravanSerijskiBroj : ApplicationException
    {
        public NeispravanSerijskiBroj(string poruka)
        {
            DodatnaPoruka = poruka;
        }
        public string DodatnaPoruka
        {
            get;
            set;
        }
    }
}
