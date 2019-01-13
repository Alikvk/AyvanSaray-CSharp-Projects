using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesnelerListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> oList = new List<Ogrenci>();
        Ogrenci secilenOgrenci;

        private void button3_Click(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oList;

            int ToplamSayi = oList.Count();
            int ToplamMaas = oList.Sum(x => x.Maas);
            txtToplamSayi.Text = ToplamSayi.ToString();
            txtToplamMaas.Text = ToplamMaas.ToString();
            //dataGridView1.FirstDisplayedScrollingRowIndex = ToplamSayi - 1;  //dataGridView1.RowCount
            //dataGridView1.Rows[ToplamSayi - 1].Selected = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Id = oList.Max(x => x.Id)+1;
            o.Ad = txtAd.Text;
            o.Soyad = txtSoyad.Text;
            o.Maas = Convert.ToInt32(txtMaas.Text);
            oList.Add(o);
            //  dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;

            Doldur();
            //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;  //dataGridView1.RowCount
            //dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            oList.Remove(secilenOgrenci);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilenOgrenci.Ad = txtAd.Text;
            secilenOgrenci.Soyad = txtSoyad.Text;
            secilenOgrenci.Maas = Convert.ToInt32(txtMaas.Text);
            Doldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Id = 1;
            o.Ad = "Mehmet";
            o.Soyad = "Yılmaz";
            o.Maas = 400;
            oList.Add(o);

            Ogrenci o2 = new Ogrenci();
            o2.Id = 2;
            o2.Ad = "Ahmet";
            o2.Soyad = "Yıldız";
            o2.Maas = 600;
            oList.Add(o2);

            //for (int i = 1; i < 100; i++)
            //{//FakeData isimli eklentiyi nuget managerdan yüklenmesi gerekiyor
            //    Ogrenci o = new Ogrenci();
            //    o.Id = i;
            //    o.Ad = FakeData.NameData.GetFirstName();
            //    o.Soyad = FakeData.NameData.GetSurname();
            //    o.Maas = FakeData.NumberData.GetNumber(600, 800);
            //    oList.Add(o);
            //}
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenOgrenci = (Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            txtAd.Text = secilenOgrenci.Ad;
            txtSoyad.Text = secilenOgrenci.Soyad;
            txtMaas.Text = (secilenOgrenci.Maas).ToString();

        }
    }
}
