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

namespace UrunlerListele
{
    public partial class Form1 : Form
    {
        string yol = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        private void Form1_Load(object sender, EventArgs e)
        {

            baglanti = new SqlConnection(yol);

            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = "Select * From Products"
            };

            baglanti.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["ProductName"]+" - "+ reader["UnitPrice"] + " - " + reader["UnitsInStock"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.Show();
            form1.Close();
        }
    }
}
