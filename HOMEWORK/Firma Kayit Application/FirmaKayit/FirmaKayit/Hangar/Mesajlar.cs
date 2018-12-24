using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Form özelliklerini Kullanmak için

namespace FirmaKayit.Hangar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj ,"Yeni Kayit Giris",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {

            return MessageBox.Show("Seçili olan kayıt güncellenecektir\nGüncelleme işlemini onaylıyormusunuz?","Güncelleme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili kayit silinecektir","Silme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt Güncellnmiştir","Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message,"Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
