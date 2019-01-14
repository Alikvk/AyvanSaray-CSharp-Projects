using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKurlari
{
    class Doviz
    {
        public int Birim { get; set; }
        public string DovizAdi { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatiFiyati { get; set; }

        public override string ToString()
        {// toString Methodu object içinden olduğunda heryerden ulaşılmaktadır.
            // Böylelikle ToString methodunu override edebilmekteyiz
            return DovizAdi + " " + Birim;
        }
    }
}
