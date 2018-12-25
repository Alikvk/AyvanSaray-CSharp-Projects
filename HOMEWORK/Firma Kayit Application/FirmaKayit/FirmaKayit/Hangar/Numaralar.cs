using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaKayit.Hangar
{
    class Numaralar
    {
        DbFirmaDataContext _db = new DbFirmaDataContext();
        public string FirNo()
        {
            try
            {
                var numara = (from s in _db.bgFirmaKayits orderby s.Id descending select s ).First().Fno; // En son kaydı bulmak için
                numara++;
                string num = numara.ToString().PadLeft(7,'0');
                return num;
            }
            catch (Exception)
            {
                return ("0000001");// Null execption içine atınca boş olmaması için bu değeri döndürüyoruz
            }
        }
    }
}
