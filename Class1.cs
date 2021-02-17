using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIOTAXI
{
    public class Klient
    {
        public Klient()
        {
            IdDzielnicy = 0;
            LiczbaOsob = 0;
        }


        public int IdDzielnicy { get; set; }
        public int LiczbaOsob { get; set; }
    }
}
