using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListveListFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] sayilar = new int[5];
            sayilar[0] = 10;
            sayilar[1]= 12;
            sayilar[2]= 18;
            sayilar[3]= 25;
            sayilar[4]= 61;
            foreach (var sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }

        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList ArrayDizi = new ArrayList();
            ArrayDizi.Add(1);
            ArrayDizi.Add(12.25);
            ArrayDizi.Add(15);
            ArrayDizi.Add(11);
            ArrayDizi.Add("Şamil");
            ArrayDizi.Add("Burcu");
            foreach (var veri in ArrayDizi)
            {
                listBox1.Items.Add(veri);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> Liste = new List<string>();
            Liste.Add("01");
            Liste.Add("11");
            Liste.Add("8.2");
            Liste.Add("14");
            Liste.Add("Şamil");
            foreach (var veri in Liste)
            {
                listBox1.Items.Add(veri);

            }
        }

        private List<Button> buttons = new List<Button>();

        private void btnEkle_Click(object sender, EventArgs e)
        {


            flowLayoutPanel1.Controls.Clear();
            buttons.Clear();
            for (int i = 0; i < 7; i++)
            {
                Button btn = new Button();
                btn.Text = ("Buton " + i).ToString();
                btn.Name = "btn" + i;
                btn.Tag = i;
                btn.Click +=new EventHandler(btnListi_Click);

                buttons.Add(btn);

                flowLayoutPanel1.Controls.Add(buttons[i]);
            }
            MessageBox.Show(buttons.Count + " yeni buton eklendi.");
            btnRenklendir.Show();
        }
        private void btnListi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            while (true)
            {

            }
            
        }
        private void btnRenklendir_Click(object sender, EventArgs e)
        {
            int Mavi = 30;
            foreach (Button b in buttons)
            {
                //b.BackColor = Color.FromArgb( b.BackColor.R, b.BackColor.G, Mavi );
                //b.BackColor = Color.FromArgb( 128, 128, Mavi );
                b.BackColor = Color.FromArgb(Mavi / 4, Mavi / 4, Mavi);
                Mavi += 30;
            }
        }
    }
}
