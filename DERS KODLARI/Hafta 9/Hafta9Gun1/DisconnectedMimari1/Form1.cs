using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedMimari1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string yol = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection baglanti;
        private void Form1_Load(object sender, EventArgs e)
        {
            Goster();

        }

        private void Goster()
        {
            baglanti = new SqlConnection(yol);
   
            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = "Select * From Products"
            };
            DataTable dt = new DataTable();
            SqlDataAdapter adb = new SqlDataAdapter(command);
            adb.Fill(dt);
            //baglanti.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    dataGridView1.Rows.Add(reader["ProductName"].ToString(), reader["UnitPrice"].ToString(), reader["UnitsInStock"].ToString());

            //}

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            string productName = txtUrunAdi.Text;
            int price =(int)nudFiyat.Value;
            int stock =(int) nudStokMiktari.Value;

            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = $"insert into Products (ProductName,UnitPrice,UnitsInStock)     values ('{productName}',{price},{stock})"
            };
            int  valueExecute=command.ExecuteNonQuery();
            if (valueExecute>0)
            {
                MessageBox.Show("Başarılı");
                Goster();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            
        
        }
    }
}
