using NortWind.ORM.Entity;
using NortWind.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nortwind.UI
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DataSource = Categories.Select();

            cbSupplier.DisplayMember = "CategoryName";
            cbSupplier.ValueMember = "CategoryID";
            cbSupplier.DataSource = Categories.Select();
            ProductList();
        }

        private void ProductList()

        {
            dataGridView1.DataSource = Products.Select();
            dataGridView1.Columns["CategoryID"].Visible=false;
            dataGridView1.Columns["SupplierID"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Product product = new Product(); // using NortWind.ORM.Entity; kısmından almaktadır.
            product.ProductName = txtProductName.Text;
            product.UnitPrice = nudUnitPrice.Value;
            product.UnitsInStock = (short) nudUnitsInStock.Value;
            product.CategoryID = 2;
            product.SupplierID = 2;
            bool result = Products.Insert(product);
            if (result)
            {
                MessageBox.Show("Başarılı");
                ProductList();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }

        }
    }
}
