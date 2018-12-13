using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
        }
        Random rnd = new Random();
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i>10)
            {
                // i'yi burda 10 kadar arttırmamız sadece salla butonun sağa sola gitmesini sağlamamızdır
                int img1 = rnd.Next(1, 7);
                int img2 = rnd.Next(1, 7);

                pictureBox1.Image = ımageList1.Images[img1 - 1];
                pictureBox2.Image = ımageList1.Images[img2 - 1];
                label1.Image = ımageList1.Images[img1 - 1];
                label2.Image = ımageList1.Images[img2 - 1];
                i = 0;
                timer1.Stop();
            }
            else
            {
                //Eğer butoon arrtırdığımız i değeri 2 ye bölünüyorsa sola 100 birim değilse sağa 100 birim ilertmektedir.
                if (i%2==0)
                {
                    button1.Left += 100;
                    
                }
                else
                {
                    button1.Left -= 100;
                }
            }
             
            
        }
    }
}
