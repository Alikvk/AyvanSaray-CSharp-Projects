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
    public partial class FormIlce : Form
    {
        FaturaContext _db = new FaturaContext();
        int _secilenID;

        public FormIlce()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = new Ilce();
                ilce.Aciklama = txtProvince.Text;
                ilce.IlID = Convert.ToInt32(comboxCity.SelectedValue);// Secilen İl Id sine göre ilceyi o Şehire göre ekliyor
                _db.ilceler.Add(ilce);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tüm Değerleri Giriniz");
            }
        }

        private void Listele()
        {
            try
            {
                var list = _db.ilceler.Select(x => new
                {
                    x.IlID,
                    SehirAdi = x.il.Aciklama,
                    x.IlceID,
                    İlceAdi = x.Aciklama
                })
                .Where(x => x.IlID == (int)comboxCity.SelectedValue).OrderBy(x => x.SehirAdi)
                .ToList();
                dataGridView1.DataSource = list;
                dataGridView1.Columns["IlID"].Visible = false;
                dataGridView1.Columns["IlceID"].Visible = false;
                txtProvince.Clear();
                txtProvince.Focus();

            }
            catch (Exception)
            {
                return;
            }
        }
        #region Update
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = _db.ilceler.Find(_secilenID);
                ilce.Aciklama = txtProvince.Text;
                ilce.IlID = Convert.ToInt32(comboxCity.SelectedValue);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bir ilçe Seçinizi");
            }
        }
        #endregion

        #region Delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = _db.ilceler.Find(_secilenID);
                _db.ilceler.Remove(ilce);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bir ilçe Seçinizi");

            }
        }
        #endregion



        private void FormIlce_Load(object sender, EventArgs e)
        {
            ComboListele();
            Listele();
        }

        private void ComboListele()
        {
            var list = _db.iller.Select(x => new
            {
                x.IlID,
                x.Aciklama
            }).OrderBy(x => x.Aciklama).ToList();
            comboxCity.DisplayMember = "Aciklama"; // Görüntülenecek kısmı bulunduruyoruz
            comboxCity.ValueMember = "IlID";
            comboxCity.DataSource = list;
        }
        // CellContentClick direk içeriğine tıklamamız gereklidir istenilen alanın gelmesi için ama CellClick kısmında İstenilen alanın bulunduğu row kısmında herhangi bir alana tıklamamız yeterlidir
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            Ilce ilce = _db.ilceler.Find(_secilenID);
            txtProvince.Text = ilce.Aciklama;
            comboxCity.SelectedValue = ilce.il.IlID;
        }

        private void comboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Listele();
        }
    }
}
