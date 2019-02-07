using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIl form_il = new FormIl();
            form_il.Show();
        }

        private void ilçeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIlce form_ilce = new FormIlce();
            form_ilce.Show();
        }

        private void birimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBirim form_birim = new FormBirim();
            form_birim.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrun form_Urun = new FormUrun();
            form_Urun.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteri form_Musteri = new FormMusteri();
            form_Musteri.Show();
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeniFatura yeniFatura = new FormYeniFatura();
            yeniFatura.Show();
        }
    }
}
