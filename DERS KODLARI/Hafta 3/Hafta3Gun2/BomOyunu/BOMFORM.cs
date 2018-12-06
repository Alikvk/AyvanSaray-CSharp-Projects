using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomOyunu
{
    public partial class BOMFORM : Form
    {
        public BOMFORM()
        {
            InitializeComponent();
        }
        int sayi = 0;
        int i = 1;
        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            i = 1;
            try
            {
                sayi = Convert.ToInt32(txtSayi.Text);
                timer1.Start();

            }
            catch (FormatException)
            {
                MessageBox.Show("Hatalı giris");
            }
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % sayi == 0)
            //    {
            //        lstBoxSayi.Items.Add("BOM");
            //        lstBoxSayi.BackColor = Color.Orange;
            //    }
            //    else
            //    {
            //        lstBoxSayi.Items.Add(i);
            //        lstBoxSayi.ResetBackColor();
            //    }
            //    //lstBoxSayi.SelectedIndexChanged=1 ;
            //    this.Update();
            //    Thread.Sleep(500);
            //}
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 101)
            {
                if (i % sayi == 0)
                {

                    lstBoxSayi.BackColor = Color.Orange;
                    lstBoxSayi.Items.Add("Boom");
                    // i++;

                }
                else
                {
                    lstBoxSayi.Items.Add(i);
                    lstBoxSayi.BackColor = Color.White;
                    //Bu satirdaki işlem yukarıdaki ile aynı işlemi yapar // lstBoxSayi.ResetBackColor();
                    // i++;

                }
                i++;
            }

            else
            {
                lstBoxSayi.Items.Clear();
                timer1.Stop();

            }
        }

       
    }
}
