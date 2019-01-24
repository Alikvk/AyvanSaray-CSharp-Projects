using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaglantiOlusturma
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
            }
            catch (System.ApplicationException ex)
            {
                Console.WriteLine("Error Handling From {0} message {1}",ex.Source,ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Bağlantı Açıldı");
            }
            else
            {
                MessageBox.Show("Bağlantı zaten açık");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
                MessageBox.Show("Bağlantı Kapatıldı");
            }
            else
            {
                MessageBox.Show("Bağlantı Zaten Kapalı");
            }
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Bağlantı Açıldı");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Bağlantı  Kapandı");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
