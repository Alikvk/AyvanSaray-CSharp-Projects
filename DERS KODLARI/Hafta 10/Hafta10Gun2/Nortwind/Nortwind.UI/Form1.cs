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
    public partial class Form1 : Form
    {
        Category category = new Category();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            category.CategoryName = txtCategoryName.Text;
            category.Description = txtDescription.Text;
            bool result = Categories.Insert(category);// Categoriesi kullanmak için reference ve using NortWind.ORM.Facade kullanılmalıdır.
            if (result)
            {
                MessageBox.Show("Başarılı");
                CategoryList();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }

        }

        private void CategoryList()
        {
            
            dataGridView1.DataSource = Categories.Select();// Categoriesi kullanmak için reference ve using NortWind.ORM.Facade kullanılmalıdır.
            dataGridView1.Columns["CategoryID"].Visible = false;
        }

    }
}
