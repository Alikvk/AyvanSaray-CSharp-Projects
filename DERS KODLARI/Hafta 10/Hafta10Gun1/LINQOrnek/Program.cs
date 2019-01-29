using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqOrnekleri_VeriKaynagi.Class1; // Aşağıdali ogrencilergetir fonksiyonunu çağırırken önüne class1 şeklinde değer yazmamak için static yazıp class ismini kullanıyoruz.

namespace LINQOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = OgrencileriGetir();

            var genderList = studentList.GroupBy(student => student.Cinsiyet);

            var clubList = studentList.GroupBy(student => student.Kulup);
            //key değeri içinde {student.Cinsiyet, student.Kulup} değerler vardır.
            var genderAndClubList = studentList.GroupBy(
                student => new { student.Cinsiyet, student.Kulup }, 
                //anonymus typr aşağıdakinin adlandırıldığı tür
                (key, studentListGroup) =>
                 {
                     return new
                     {
                         Count = studentListGroup.Count(),
                         Student = studentListGroup
                                  .Select(singleS => singleS.Adi + " " + singleS.Soyadi)
                                  .OrderBy(x => x)
                     };
                 }

                );

        }
    }
}
