using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace SortedListNonGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList sehirler = new SortedList();

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" && textBox2.Text != "")
            {
                textBox1.Text = sehirler.Contains(textBox2.Text).ToString();

            }
            else if(textBox2.Text=="" && textBox1.Text != "")
            {
                textBox2.Text = sehirler[Convert.ToInt32(textBox1.Text)].ToString();

            }
            else
            {
                MessageBox.Show("Bir Değer Giriniz");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler.Add(21, "Diyarbakır");
            sehirler.Add(34, "Istanbul");
            sehirler.Add(6, "Ankara");
        }
    }
}
