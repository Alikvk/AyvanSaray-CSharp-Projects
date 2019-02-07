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
    public partial class FormIl : Form
    {
        FaturaContext _db = new FaturaContext(); // Database işlemleri için kullanacağımız context nesnesi tanımlanıyor
        int _secilenID;
        public FormIl()
        {
            InitializeComponent();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = new Il();
                il.Aciklama = txtCityName.Text;
                _db.iller.Add(il);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen Tüm Değerleri Giriniz"+ ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = _db.iller.Find(_secilenID); // Datagridview den seçilen şehiri bulup textbox içerisinde bulunan text ile güncelliyoruz
                il.Aciklama = txtCityName.Text;
                _db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Bir ilçe Seçinizi");

                MessageBox.Show("Hata ile karşılaşıldı" + ex.Message);

            }
        }
        #region Delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = _db.iller.Find(_secilenID);
                _db.iller.Remove(il);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir ilçe Seçinizi");

            }
        }

        #endregion

        private void FormIl_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            var list = _db.iller.Select(x => new
            {
               SehirKodu=x.IlID,
               SehirAdi=x.Aciklama
            }).ToList();
            dataGridView1.DataSource = list;
            txtCityName.Clear();
            txtCityName.Focus();

        }
        // CellContentClick direk içeriğine tıklamamız gereklidir istenilen alanın gelmesi için ama CellClick kısmında İstenilen alanın bulunduğu row kısmında herhangi bir alana tıklamamız yeterlidir
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Il il = _db.iller.Find(_secilenID);
            txtCityName.Text = il.Aciklama;
        
        }
    }
}
