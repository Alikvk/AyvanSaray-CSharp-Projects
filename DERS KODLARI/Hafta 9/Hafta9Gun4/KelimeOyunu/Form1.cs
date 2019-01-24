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

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        private SqlConnection _conn;
        string _connString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        private List<string> _productName;
        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection(_connString);
            _productName = new List<string>();
            GetProductName();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ch;

            try
            {
                ch = txtSearch.Text;

            }
            catch (FormatException)
            {

                MessageBox.Show("You have entered the wrong value.Please Try Again");
                return;
            }

            for (int i = 0; i < _productName.Count; i++)
            {
                // lstWordList.Items.Add(_productName[i].Substring(0, 1).ToLower());
                if (ch.ToLower() == _productName[i].Substring(0, 1).ToLower())
                {
                    ch = _productName[i].Substring(_productName[i].Length - 1, 1);
                    lstWordList.Items.Add(_productName[i] + "--");
                    _productName.Remove(_productName[i]);
                    i = 0;
                }
            }
            if (lstWordList.Items.Count > 0)
            {

                MessageBox.Show("GameOver");
                txtSearch.Text = "";
            }
                //foreach (var item in _productName)
                //{
                //    lstWordList.Items.Add(item.Substring(0, 1).ToLower());
                //    if (ch.ToLower() == item.Substring(0, 1).ToLower())
                //    {
                //        ch = item.Substring(item.Length - 1, 1);
                //        lstWordList.Items.Add(item + "--");
                //        //_productName.Remove(item);
                //        continue;
                //    }
                //}

        }
        private void GetProductName()
        {
            _productName.Clear();
            string query = "SELECT ProductName FROM Products WHERE Discontinued = 0";

            SqlCommand command = new SqlCommand(query, _conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(dt);
            DataTableReader reader = dt.CreateDataReader();
            while (reader.Read())
            {
                _productName.Add(reader["ProductName"].ToString().Split(' ')[0]);
            }
            dataGridView1.DataSource = dt;

        }
        private void Clear()
        {
            txtSearch.Text = "";
            lstWordList.Items.Clear();

        }
    }
}
