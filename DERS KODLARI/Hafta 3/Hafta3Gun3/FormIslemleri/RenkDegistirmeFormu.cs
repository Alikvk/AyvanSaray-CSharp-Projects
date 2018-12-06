using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIslemleri
{
    public partial class RenkDegistirmeFormu : Form
    {
        public Form BağlananAnaForm;

        public RenkDegistirmeFormu(Form p)
        {
            InitializeComponent();
            BağlananAnaForm = p;
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Hide();
            
            // Timer ile calistiracagimizda alttaki satirlar kapatilmali
            try
            {
                if (BağlananAnaForm != null)
                {
                    BağlananAnaForm.BackColor = RenkKodunaCevir(txtRenkGirisi.Text);
                    txtRenkGirisi.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Renk değeri tanımlı değil");
            }
        }
        public Color YeniRengiAl(Color ÖncekiRenk)
        {
            try
            {
                return RenkKodunaCevir(txtRenkGirisi.Text);
            }
            catch (Exception)
            {
                // MessageBox.Show("Girilen renk tanımlı değil. Önceki renk uygulandı.");
                return ÖncekiRenk;
            }
        }
        Color RenkKodunaCevir(string RenkMetni)
        {
            switch (RenkMetni.ToLower())
            {
                case "kırmızı":
                    return Color.Red;
                case "mavi":
                    return Color.Blue;
                case "yeşil":
                    return Color.Green;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
