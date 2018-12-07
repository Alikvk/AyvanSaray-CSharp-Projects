using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosuYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string kazanan;
            Random rnd = new Random();
            int horseRnd = rnd.Next(0, 16);
            int citaRnd = rnd.Next(0, 16);
            picBoxHorse.Left += horseRnd;
            picBoxCita.Left += citaRnd;
             
            if (picBoxHorse.Right >= this.ClientSize.Width || picBoxCita.Right >= this.ClientSize.Width)
            {
                timer1.Stop();
                if (picBoxHorse.Right >= this.ClientSize.Width)
                    //(picBoxHorse.Right > picBoxCita.Right)
                {
                    kazanan = "AT";
                    
                }
                else
                {
                    kazanan = "Çita";
                }
                MessageBox.Show(kazanan + " Yarismayi Kazandı");
            }
        }

        private void btnYenidenBaslat_Click(object sender, EventArgs e)
        {
            picBoxHorse.Location = new Point(3,44);
            picBoxCita.Location = new Point(3, 177);
            timer1.Stop();

        }
    }
}
