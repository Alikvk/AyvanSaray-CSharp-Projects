using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaProje
{
    public partial class FormUrun : Form
    {
        FaturaContext _db = new FaturaContext(); // Database işlemleri için kullanacağımız context nesnesi tanımlanıyor
        int _secilenID;
        public FormUrun()
        {
            InitializeComponent();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            BirimListe();
            Listele();
        }

        private void Listele()
        {
            var list = _db.Urunler.Select(x => new
            {
                x.UrunID,
                x.UrunAdi,
             //   x.BirimID,
                x.UrunKodu,
                x.BirimFiyati
            }).OrderBy( x => x.UrunAdi ).ToList();

            dataGridView1.DataSource = list;
        }

        private void BirimListe()
        {
            var bList = _db.Birimler.Select(x => new
            {
                x.BirimID,
                x.Adi
            }).OrderBy(x => x.Adi).ToList();
            comboxUnitList.DisplayMember = "Adi";
            comboxUnitList.ValueMember = "BirimID";
            comboxUnitList.DataSource = bList;
;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun();
                urun.UrunAdi = txtProductName.Text;
                urun.UrunKodu = txtProductCode.Text;
                urun.BirimFiyati =Convert.ToDecimal( txtUnitPrice.Text);
                urun.BirimID =(int) comboxUnitList.SelectedValue;
                Listele();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = _db.Urunler.Find(_secilenID);
                urun.UrunAdi = txtProductName.Text;
                urun.UrunKodu = txtProductCode.Text;
                urun.BirimFiyati = Convert.ToDecimal(txtUnitPrice.Text);
                urun.BirimID = (int)comboxUnitList.SelectedValue;
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = _db.Urunler.Find(_secilenID);
                _db.Urunler.Remove(urun);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
                _secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Urun urun = _db.Urunler.Find(_secilenID);
                txtProductName.Text = urun.UrunAdi;
                txtProductCode.Text = urun.UrunKodu;
                comboxUnitList.SelectedValue = urun.BirimID;
            }
            catch
            {
                MessageBox.Show("Seçilemedi");
            }
        }
    }
}
