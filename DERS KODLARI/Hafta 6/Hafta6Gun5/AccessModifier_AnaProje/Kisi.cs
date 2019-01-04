using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_AnaProje
{
   public class Kisi
    {
        public int a;
        private string AdSoyad;
        internal int Yas { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }
        protected internal int KrediliTarih { get; set; }
        protected int TcKimlik { get; set; }
        public string FullName()
        {
            //return this.Ad + this.Soyad;
            //Eklendi
            AdSoyad = this.Ad + this.Soyad;
            return AdSoyad;
        }
    }
}
