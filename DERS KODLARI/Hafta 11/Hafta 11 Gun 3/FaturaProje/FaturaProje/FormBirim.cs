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
    public partial class FormBirim : Form
    {
        FaturaContext _db = new FaturaContext(); // Database işlemleri için kullanacağımız context nesnesi tanımlanıyor
        int _secilenID;
        public FormBirim()
        {
            InitializeComponent();
        }
        private void FormBirim_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            var list = _db.Birimler.Select(x => new
            {
                 x.BirimID,
                 x.Adi
            }).ToList();
            dataGridView1.DataSource = list;
            txtUnit.Clear();
            txtUnit.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = new Birim();
                birim.Adi = txtUnit.Text;
                _db.Birimler.Add(birim);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tüm Değerleri Giriniz");
            }
        }

        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = _db.Birimler.Find(_secilenID); // Datagridview den seçilen şehiri bulup textbox içerisinde bulunan text ile güncelliyoruz
                birim.Adi = txtUnit.Text;
                _db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Bir ilçe Seçinizi");

                MessageBox.Show("Hata ile karşılaşıldı" + ex.Message);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = _db.Birimler.Find(_secilenID);
                _db.Birimler.Remove(birim);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir ilçe Seçinizi");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Birim birim = _db.Birimler.Find(_secilenID);
            txtUnit.Text = birim.Adi;
        }
    }
}
