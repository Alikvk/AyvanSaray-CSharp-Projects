using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmaKayit.Hangar;
namespace FirmaKayit.Bilgi
{
    public partial class FrmFirmaGiris : Form
    {
        DbFirmaDataContext _db = new DbFirmaDataContext();// Databasedeki tablolara ulaşabilmemizi sağlar

        Formlar _f = new Formlar();
        Mesajlar _m = new Mesajlar();

        bool _edit = false;
        public FrmFirmaGiris()
        {
            InitializeComponent();
        }

        private void FrmFirmaGiris_Load(object sender, EventArgs e)
        {
            Temizle();
            Combo();

        }
        void Temizle()
        {
            foreach (Control ct in splitContainer1.Panel1.Controls)
            {

                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
            _edit = false;
        }

        void Combo()
        {
            cbFirmaTip.Items.Clear();
            cbFirmaTip.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var ct = _db.bgFirmaTipis.Select(x => x.Ftipi).Distinct();// Eğer aynı kayılar var ise distinct ile tek bir tane yazdırıyoruz
            foreach (string ftip in ct)
            {
                veri.Add(ftip);
                cbFirmaTip.Items.Add(ftip);
            }
            cbFirmaTip.AutoCompleteCustomSource = veri;//otomatik olarak yazıyı tamamlama özelliğini ekliyoruz
        }
        void YeniKayit()
        {
            bgFirmaKayit fk = new bgFirmaKayit()
            {

                Fadi = txtFirmaAdi.Text,
                Fno = int.Parse(txtFirmaNo.Text),
                Fadres = txtAdres.Text,
                Ffaks = txtFaks.Text,
                Ftel1 = txtTel1.Text,
                Ftel2 = txtTel2.Text,
                Femail = txtEposta.Text,
                Fvd = txtVergiDairesi.Text,
                Fvno=txtVTCNo.Text,
                Fyetkili=txtYetkili.Text,
                Fweb=txtWebAdresi.Text,
                Fdepartman=txtDepartman.Text,
                Ftipi=_db.bgFirmaTipis.First(x=>x.Ftipi==cbFirmaTip.Text).Id,
                saveDate=DateTime.Now,
                saveUser=-1 // Burada kullanıcı girişi olmadığı için hata vermemesi adına -1 kullandık
            };
            _db.bgFirmaKayits.InsertOnSubmit(fk); // Geçici Bir tablo oluşturmamızı sağlayıp o alana atıyoruz
            _db.SubmitChanges(); // Kesin kayıt için kullanıyoruz. Geri Dönüşü olmuyor
            _m.YeniKayit("Kayıt Başarılı Bir Şekilde oluşturuldu");
            Temizle();//Formdaki içerikleri temizle
            Close();// Formu Kapat
            _f.FrmGir();//Formu Yeniden AÇ Bu kısımda aslında kayıt ettiğimiz yada gümncellediğimiz kısmın tekrar görebilmek adına geri çağırıyoruz

        }
    
    private void btnCollaps_Click(object sender, EventArgs e)
    {
        switch (splitContainer1.Panel2Collapsed)
        {
            case true:
                splitContainer1.Panel2Collapsed = false;
                btnCollaps.Text = "GİZLE";
                break;
            case false:
                splitContainer1.Panel2Collapsed = true;
                btnCollaps.Text = "GÖSTER";
                break;
        }
    }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
    }
}
