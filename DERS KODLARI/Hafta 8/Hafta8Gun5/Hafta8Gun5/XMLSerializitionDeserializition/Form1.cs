using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLSerializitionDeserializition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> listOgrenci = new List<Ogrenci>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci() {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text)
            };
            listBoxEklenen.Items.Add(ogrenci);
            listOgrenci.Add(ogrenci);
        }

        private void btnSerialization_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "XML dosyasını Kaydet";
            saveFileDialog.Filter = "xml | .xml";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Ogrenci>));
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileDialog.FileName);
                serializer.Serialize(writer, listOgrenci);
                writer.Close();
                MessageBox.Show("Dosya Kaydedildi");

            }
            
        }

        private void btnDeserialization_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            List<Ogrenci> newStudents = new List<Ogrenci>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Ogrenci>));

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(openFileDialog.FileName);
                newStudents = (List<Ogrenci>)serializer.Deserialize(reader);
                fillList(newStudents);
                reader.Close();
            }
        }
        private void fillList(List<Ogrenci> students)
        {
            listBoxEklenen.Items.Clear();
            foreach (var student in students)
            {
                listBoxEklenen.Items.Add(student);
            }
        }

        private void listBoxEklenen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEklenen.SelectedItem != null)
            {
                txtAd.Text = ((Ogrenci)listBoxEklenen.SelectedItem).Ad;
                txtSoyad.Text = ((Ogrenci)listBoxEklenen.SelectedItem).Soyad;
                dtpDogumTarihi.Value= (listBoxEklenen.SelectedItem as Ogrenci) .DogumTarihi;
            }
        }
    }
}
