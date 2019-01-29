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
    public partial class Kategoriler : Form
    {
        string yol = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        public Kategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        private void Kategoriler_Load(object sender, EventArgs e)
        {

            baglanti = new SqlConnection(yol);

            SqlCommand command = new SqlCommand
            {
                Connection = baglanti,
                CommandText = "Select * From Categories"
            };

            baglanti.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems.Add(Convert.ToString( reader["CategoryName"]));
                listViewItem.SubItems.Add(Convert.ToString(reader["Description"]));
                listView1.Items.Add(listViewItem);
                listBox1.Items.Add(reader["CategoryName"] + " - " + reader["Description"] );
            }



        }
    }
}
