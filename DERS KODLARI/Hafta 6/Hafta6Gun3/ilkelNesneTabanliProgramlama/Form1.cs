using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilkelNesneTabanliProgramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Id = { 1, 2, 3 };
        string[] Ad = { "Ali", "Veli", "Ahmet" };

        private void button1_Click(object sender, EventArgs e)
        {
            //    int girilenID = Convert.ToInt32(textBox1.Text);
            //    if (girilenID==1)
            //    {
            //        textBox2.Text = Ad[0];
            //    }
            //    else if (girilenID == 2)
            //    {
            //        textBox2.Text = Ad[1];
            //    }
            //    else if (girilenID == 3)
            //    {
            //        textBox2.Text = Ad[2];
            //    }
            //    else
            //    {
            //        MessageBox.Show("Olmayan Değer");
            //    }
            try
            {
                int girilenID = Convert.ToInt32(textBox1.Text);
                int index = Array.IndexOf(Id, girilenID);
                textBox2.Text = Ad[index];
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
 

        }   
    }
}
