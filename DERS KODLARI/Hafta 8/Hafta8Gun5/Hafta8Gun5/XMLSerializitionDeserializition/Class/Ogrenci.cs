using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializitionDeserializition
{
    public class Ogrenci
    {
        public Guid ID { get; set; }
        public string  Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public Ogrenci()
        {
            this.ID = Guid.NewGuid();

        }
        public override string ToString()
        {
            return Ad;
        }
    }
}
