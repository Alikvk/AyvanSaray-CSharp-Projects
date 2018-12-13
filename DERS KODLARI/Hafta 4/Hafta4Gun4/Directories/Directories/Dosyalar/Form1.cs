using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosyalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Yol;
        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnDiskler_Click(object sender, EventArgs e)
        {
            string[] diskler = Directory.GetLogicalDrives();
            lstDiskler.Items.Clear();
            foreach (var item in diskler)
            {
                lstDiskler.Items.Add(item);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lstKlasorler.Items.Clear();
            string[] klasorler = Directory.GetDirectories("C:\\");

            foreach (var item in klasorler)
            {
                lstKlasorler.Items.Add(item);
            }
        }

        private void btnDosyalar_Click(object sender, EventArgs e)
        {
            lstDosyalar.Items.Clear();
            string[] dosyalar = Directory.GetFiles("C:\\");
            foreach (var item in dosyalar)
            {
                lstDosyalar.Items.Add(item);
            }
        }

        private void btnDizin_Click(object sender, EventArgs e)
        {
            try
            {
                YoluAl();
                Directory.CreateDirectory(Yol);
                MessageBox.Show("Klasör Oluşturuldu");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public void YoluAl()
        {

            Yol = txtYol.Text;
        }

        private void btnDizinSil_Click(object sender, EventArgs e)
        { //1.yol 
            //YoluAl();
            //try
            //{
            //    Directory.Delete(Yol);
            //    MessageBox.Show(Yol + " " + "Dizin Silindi");

            //}
            //catch (Exception EX)
            //{

            //    MessageBox.Show(EX.Message);
            //}
            //2.yol 

            try
            {
                string Yol = lstKlasorler.SelectedItem.ToString();
                Directory.Delete(Yol);
                MessageBox.Show(Yol + " " + "Dizin Silindi");

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void btnNerede_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void btnTasi_Click(object sender, EventArgs e)
        {
            try
            {
                string tasinacakDizin = txtBoxEski.Text;
                string yeniDizin = txtBoxYeni.Text;
                Directory.Move(tasinacakDizin, yeniDizin);
                MessageBox.Show(txtBoxEski + " Dizisi" + txtBoxYeni + " Dizine Taşındı. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
