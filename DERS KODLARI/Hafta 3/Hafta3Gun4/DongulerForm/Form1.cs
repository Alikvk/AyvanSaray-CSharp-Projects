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

namespace DongulerForm
{
    public partial class Form1 : Form
    {
        int[] Dizi = { 10, 20, 25, 28, 34 };
        int Toplam;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            temizle();
            forDongusu();
        }
        
        private void btnWhile_Click(object sender, EventArgs e)
        {
            temizle();
            WhileDongusu();
            
        }

        private void btnDowhile_Click(object sender, EventArgs e)
        {
            temizle();
            DoWhileDongusu();
            
        }

        private void DoWhileDongusu()
        {
            int i = 0;
            do
            {
                lstDoWhile.Items.Add(Dizi[i]);
                Toplam = Toplam + Dizi[i];
                i++;
            } while (i<Dizi.Length);
            
            lstDoWhile.Items.Add("Toplam => " + Toplam);
            ToplamSifirla();
        }

        private void btnIENUM_Click(object sender, EventArgs e)
        {
            temizle();
            IenumDongu();
           
        }

        private void IenumDongu()
        {
            int i = 0;
            IEnumerator IENum = Dizi.GetEnumerator();
            while (IENum.MoveNext())
            {
                lstIENUM.Items.Add(IENum.Current);
                Toplam += Dizi[i];
                i++;

            }
            lstIENUM.Items.Add("Toplam = : " + Toplam);
            ToplamSifirla();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            temizle();
            ForeachDongu();
        }

        private void ForeachDongu()
        {
            foreach (var sayi in Dizi)
            {
                lstForeach.Items.Add(sayi);
                Toplam = Toplam + sayi;
            }
            lstForeach.Items.Add("Toplam => " + Toplam);
            ToplamSifirla();
        }

        private void forDongusu()
        {
            lstFor.Items.Clear();
            for (int i = 0; i < Dizi.Length; i++)
            {
                lstFor.Items.Add(Dizi[i]);
                Toplam = Toplam + Dizi[i];
            }
            lstFor.Items.Add("Toplam => " + Toplam);
            ToplamSifirla();
        }

        private void WhileDongusu()
        {
            int i = 0;
            while (i < Dizi.Length)
            {
                lstWhile.Items.Add(Dizi[i]);
                Toplam = Toplam + Dizi[i];
                i++;
            }

            lstWhile.Items.Add("Toplam => " + Toplam);
            ToplamSifirla();
        }


        private void temizle()
        {
            lstFor.Items.Clear();
            lstWhile.Items.Clear();
            lstDoWhile.Items.Clear();
            lstIENUM.Items.Clear();
            lstForeach.Items.Clear();

        }
        private void ToplamSifirla()
        {
            Toplam = 0;
        } 

    }
}
