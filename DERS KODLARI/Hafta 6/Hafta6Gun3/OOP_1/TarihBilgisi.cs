using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class TarihBilgisi
    {
        private DateTime _tarih;// pricate variable tanımlarken _ çiz ile başlaması standarttır
        public string GecerliTarih { set { _tarih = Convert.ToDateTime(value); } }
        private double GunOlarakTarihFarki(DateTime farkiAlinacakTarih)
        {
            return (farkiAlinacakTarih - _tarih).TotalDays;
        }
        public string GunFarki(string YeniTarih)
        {
            return GunOlarakTarihFarki(Convert.ToDateTime(YeniTarih)).ToString() + "gün farkı var";
        }
    }
}
