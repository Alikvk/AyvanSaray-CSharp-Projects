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
    public partial class FormMusteri : Form
    {
        FaturaContext _db = new FaturaContext();
        int secilenID;
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void ilDoldur()
        {
            var list = _db.iller.Select(x => new
            {
                x.IlID,
                x.Aciklama

            }).OrderBy(x => x.Aciklama).ToList();
            comboxCustomerCity.DisplayMember = "Aciklama";
            comboxCustomerCity.ValueMember = "IlID";
            comboxCustomerCity.DataSource = list;
        }

        private void ilceDoldur()
        {
            var list = _db.ilceler.Select(x => new
            {
                x.IlID,
                x.IlceID,
                x.Aciklama

            }).OrderBy(x => x.Aciklama).Where(x => x.IlID == (int)comboxCustomerCity.SelectedValue).ToList();
            comboxCustomerProvince.DisplayMember = "Aciklama";
            comboxCustomerProvince.ValueMember = "IlceID";
            comboxCustomerProvince.DataSource = list;
        }

        private void Listele()
        {
            var mlist = _db.Musteriler.Select(x => new
            {
                MusteriKodu = x.MusteriID,
                x.MusteriUnvani,
                SehirAdi = x.ilce.il.Aciklama,
                IlceAdi = x.ilce.Aciklama,
                x.MusteriAdresi

            }).ToList();
            dataGridView1.DataSource = mlist;

            txtAddress.Clear();
            txtAppellation.Clear();
            txtAppellation.Focus();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriUnvani = txtAppellation.Text;
            musteri.MusteriAdresi = txtAddress.Text;
            musteri.IlceID = (int)comboxCustomerProvince.SelectedValue;
            _db.Musteriler.Add(musteri);
            _db.SaveChanges();
            Listele();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = _db.Musteriler.Find(secilenID);
                musteri.MusteriUnvani = txtAppellation.Text;
                musteri.MusteriAdresi = txtAddress.Text;
                musteri.IlceID = (int)comboxCustomerProvince.SelectedValue;
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
                Musteri musteri = _db.Musteriler.Find(secilenID);
                _db.Musteriler.Remove(musteri);
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
                secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Musteri musteri = _db.Musteriler.Find(secilenID);
                txtAppellation.Text = musteri.MusteriUnvani;
                txtAddress.Text = musteri.MusteriAdresi;
                comboxCustomerCity.SelectedValue = musteri.ilce.IlID;
                comboxCustomerProvince.SelectedValue = musteri.IlceID;
            }
            catch
            {

            }
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            ilDoldur();
            ilceDoldur();
            Listele();
        }

        private void comboxCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ilceDoldur();
        }
    }
}
