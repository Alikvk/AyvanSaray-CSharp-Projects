using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{ // Burada Static Polymorphisizm uygulanmıştır
   
        enum CanliTipi
        {
            Insan=0,
            Hayvan=1
        }
        enum Hareket
        {
            Havla=0,
            KuyrukSall=1,
            PatiUzat=2
        }
        class Canli
        {
            static public void Konus(CanliTipi c,string ifade)
            {
                Console.WriteLine("{0} der ki '{1}' ",c,ifade);
            }
            static public void Konus(string ifade)
            {
                Console.WriteLine(ifade);
            }
            static public void Konus(CanliTipi c,Hareket h)
            {
                Console.WriteLine("{0} şunu yaptı : {1}",c,h);
            }
        
    }
}
