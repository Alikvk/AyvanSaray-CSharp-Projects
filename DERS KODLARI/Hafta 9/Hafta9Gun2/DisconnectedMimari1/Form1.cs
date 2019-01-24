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
        int ProductId;
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
                CommandText = "Select * From Products WHERE Discontinued=0"
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
            try
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = baglanti,
                    CommandText = $"insert into Products (ProductName,UnitPrice,UnitsInStock) values ('{productName}',{price},{stock})"
                };
                int valueExecute = command.ExecuteNonQuery();
                if (valueExecute > 0)
                {
                    MessageBox.Show("Başarılı");
                    Goster();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Başarısız");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata ile Karşılaşıldı : "+ex.Message);
            }
            
            
        
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler category = new Kategoriler();
            category.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            string productName = txtUrunAdi.Text;
           int price =(int) nudFiyat.Value;
            int stock = (int)nudStokMiktari.Value;
            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = $"UPDATE  Products SET ProductName='{productName}',UnitPrice={price},UnitsInStock={stock} WHERE ProductID={ProductId}"
            };
            command.ExecuteNonQuery();
            Goster();
           
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Yukarıda kaydetme işleminde product id ihtiyacımız olduğundan burada değeri alıyoruz
            ProductId = (int) dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value;


            txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            nudFiyat.Value =(decimal) dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value;
            nudStokMiktari.Value=Convert.ToDecimal( dataGridView1.Rows[e.RowIndex].Cells["UnitsInStock"].Value);
           
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = $"DELETE FROM Products  WHERE ProductID={ProductId}"
            };
            command.ExecuteNonQuery();
            Goster();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            int executeValue=0;
          //  SqlTransaction tran = baglanti.BeginTransaction();
            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = $"DELETE FROM Products  WHERE ProductID={ProductId}"
            };
            try
            {
                executeValue = command.ExecuteNonQuery();
                //    tran.Commit();
                if (executeValue > 0)
                {
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Başarısız");

                }
                Goster();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    if (MessageBox.Show("Bu veri Silinsin mi?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        command.CommandText = $"DELETE FROM Products  WHERE ProductID={ProductId}";
                        executeValue = command.ExecuteNonQuery();
              //          tran.Commit();
                    }

                } 
               
            }
            catch (Exception exep)
            {
                MessageBox.Show("Hata ile karşılaşıldı : "+exep.Message);
            }
           
           
            
        }
        private void Clear()
        {
            txtUrunAdi.Text = "";
            nudFiyat.Value = 0;
            nudStokMiktari.Value = 0;
        }
    }
}
