using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedMimari1
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        string yol = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection baglanti;
        string imgPath;
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            Goster();
        }
        private void Goster()
        {
            baglanti = new SqlConnection(yol);

            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = "Select * From Categories"
            };
            DataTable dt = new DataTable(); // Tek bir tabloyu Elde Etmektedir
            SqlDataAdapter adb = new SqlDataAdapter(command);
            adb.Fill(dt);


            dgview.DataSource = dt;
            dgview.Columns["CategoryID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            string categoryName = txtCatName.Text;
            string description = txtDescription.Text;
            
            byte[] picGet = File.ReadAllBytes(imgPath);
            MemoryStream ms = new MemoryStream(picGet);
            SqlCommand command = new SqlCommand 
            {
                Connection = baglanti,
                CommandText = $"INSERT INTO Categories (CategoryName,Description,Picture) values ('{categoryName}','{description}','{picGet}')"
            };
            int valueExecute = command.ExecuteNonQuery();
            if (valueExecute > 0)
            {
                MessageBox.Show("Başarılı");
                Goster();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            baglanti.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp | All Files|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
               // pbPicture.Image = new Bitmap(openFile.FileName);
               // pbPicture.ImageLocation = openFile.FileName;
                pbPicture.Image = Image.FromFile(openFile.FileName);
                imgPath = openFile.FileName;
            }
   
        }
    }
}
