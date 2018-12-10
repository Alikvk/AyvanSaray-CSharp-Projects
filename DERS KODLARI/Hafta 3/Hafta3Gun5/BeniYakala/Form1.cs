using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeniYakala_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnBeniYakala.Left = rnd.Next(0, this.ClientSize.Width - btnBeniYakala.Width);
            btnBeniYakala.Top = rnd.Next(0, this.ClientSize.Height - btnBeniYakala.Height);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int tiklama = 0;
        private void Form1_Click(object sender, EventArgs e)
        {
            tiklama++;
            Text = tiklama.ToString();
        }

        private void btnBeniYakala_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tiklama + ". Tıklamada kazandınız");
            tiklama = 0;
        }

        private void beniYakala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnBeniYakala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
