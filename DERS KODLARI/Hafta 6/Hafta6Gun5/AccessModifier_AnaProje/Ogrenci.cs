using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_AnaProje
{
    class Ogrenci : Kisi
    {
        int ogrNo;
        public Ogrenci(){
            this.TcKimlik = 213234;
            this.KrediliTarih = 24234234;
            this.ogrNo = 1234;
            a = 21;
        }
    }
}
