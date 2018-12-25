using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        Numaralar _n = new Numaralar();

        bool _edit = false;
        public FrmFirmaGiris()
        {
            InitializeComponent();// Controlleri yüklenmesini sağlamaktadır.
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
            txtFirmaNo.Text = _n.FirNo();
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
        void YeniKaydet()
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
                Fvno = txtVTCNo.Text,
                Fyetkili = txtYetkili.Text,
                Fweb = txtWebAdresi.Text,
                Fdepartman = txtDepartman.Text,
                Ftipi = _db.bgFirmaTipis.First(x => x.Ftipi == cbFirmaTip.Text).Id,
                saveDate = DateTime.Now,
                saveUser = -1 // Burada kullanıcı girişi olmadığı için hata vermemesi adına -1 kullandık
            };
            _db.bgFirmaKayits.InsertOnSubmit(fk); // Geçici Bir tablo oluşturmamızı sağlayıp o alana atıyoruz
            _db.SubmitChanges(); // Kesin kayıt için kullanıyoruz. Geri Dönüşü olmuyor
            _m.YeniKayit("Kayıt Başarılı Bir Şekilde oluşturuldu");
            Temizle();//Formdaki içerikleri temizle
            Close();// Formu Kapat
            _f.FrmGir();//Formu Yeniden AÇ Bu kısımda aslında kayıt ettiğimiz yada gümncellediğimiz kısmın tekrar görebilmek adına geri çağırıyoruz

        }
        protected override void OnLoad(EventArgs e)// Bu kısım formNo içindeki buttonu yapmak için kullanıyoruz 
        {
            var btnFrm = new Button();
            btnFrm.Size = new Size(25,txtFirmaNo.ClientSize.Height+2);
            btnFrm.Location = new Point(txtFirmaNo.ClientSize.Width - btnFrm.Width, -1);
            btnFrm.Cursor = Cursors.Default;
            btnFrm.Image = FirmaKayit.Properties.Resources.Koala;//Koala herhangi bir resmin ismi bir butonun image resource kısmına import edip burada kullanıyoruz daha sonra tanımladığımız butondan kaldırabiliriz
            txtFirmaNo.Controls.Add(btnFrm);//btnForm butonu control olarak textboxın içine atıyoruz
            SendMessage(txtFirmaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnFrm.Width << 16));
            btnFrm.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);
            btnFrm.Click += btnFrm_Click;

        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btnFrm_Click (object sender, EventArgs e)
        {
            int id = _f.FrmListe(true);
            if (id>0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }
        void Ac(int id)
        {
            try
            {
                _edit = true;
                bgFirmaKayit fk = _db.bgFirmaKayits.First(z=>z.Fno==id);
                txtAdres.Text = fk.Fadres;
                txtDepartman.Text = fk.Fdepartman;
                txtEposta.Text = fk.Femail;
                txtFaks.Text = fk.Ffaks;
                txtFirmaAdi.Text = fk.Fadi;
                txtFirmaNo.Text = fk.Fno.ToString().PadLeft(7,'0');// Stringin başına 7 hane olacak şekilde 0 ekle
                txtTel1.Text = fk.Ftel1;
                txtTel2.Text = fk.Ftel2;
                txtVergiDairesi.Text = fk.Fvd;
                txtVTCNo.Text = fk.Fvno;
                txtWebAdresi.Text = fk.Fweb;
                txtYetkili.Text = fk.Fyetkili;
                cbFirmaTip.Text = fk.bgFirmaTipi.Ftipi;
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
      
        void Guncelle()
        {
            bgFirmaKayit fk = _db.bgFirmaKayits.First(x => x.Fno == int.Parse(txtFirmaNo.Text));
            fk.Fadi = txtFirmaAdi.Text;
            fk.Fadres = txtAdres.Text;
            fk.Fdepartman = txtDepartman.Text;
            fk.Femail = txtEposta.Text;
            fk.Ffaks = txtFaks.Text;
            fk.Fno = int.Parse(txtFirmaNo.Text);
            fk.Ftel1 = txtTel1.Text;
            fk.Ftel2 = txtTel2.Text;
            fk.Ftipi = _db.bgFirmaTipis.First(x => x.Ftipi == cbFirmaTip.Text).Id;
            fk.Fvd = txtVergiDairesi.Text;
            fk.Fvno = txtVTCNo.Text;
            fk.Fweb = txtWebAdresi.Text;
            fk.Fyetkili = txtYetkili.Text;
            fk.updateDate = DateTime.Now;
            fk.updateUser = -1;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
            Close();
            _f.FrmGir();
        }
        void Sil()
        {
            try
            {
                _db.bgFirmaKayits.DeleteOnSubmit(_db.bgFirmaKayits.First(x => x.Fno == int.Parse(txtFirmaNo.Text)));
                _db.SubmitChanges();
                Temizle();
                Close();
                _f.FrmGir();
            }
            catch (Exception e)
            {

                _m.Hata(e);
            }
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
            if (_edit && int.Parse(txtFirmaNo.Text) > 0 && _m.Guncelle() == DialogResult.Yes)
                Guncelle();
            else if (_edit == false)
                YeniKaydet();
            else return;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (_edit && int.Parse(txtFirmaNo.Text) > 0 && _m.Sil() == DialogResult.Yes)
                Sil();
            else return;
        }
    }
}
