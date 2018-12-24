using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmaKayit.Bilgi;// Bu olmasaydı bilgi içerisindeki formların başına hep bilgi yazmamız lazımdı


namespace FirmaKayit.Hangar
{
    class Formlar
    {
        #region Firma İslemleri
        public void FrmGir()
        {
            FrmFirmaGiris frm = new FrmFirmaGiris();//Ramde oluşturduğumuz alanı oluşturup bu alanı kullanmak amacımız
            frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
            //Anasayfa kısmında mdiContainer olarak tanımladığımızda parente sensin yanı kimseyi ezme sende ezilme
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public int FrmListe(bool secim=false)
        {
            FrmFirmaListe fl = new FrmFirmaListe();
            if (secim)
            {
                fl.Secim = true;
                fl.ShowDialog();
            }
            else
            {
                fl.MdiParent = Form.ActiveForm;// Mdi olarak tanımladığımız kısımda aktif form olarak gösteriyoruz.
                fl.Show();
            }
            return AnaSayfa.Aktarma;
        }
        #endregion
    }
}
