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
    public partial class AnaForm : Form
    {
        RenkDegistirmeFormu frm;
        public AnaForm()
        {
            InitializeComponent();
            frm = new RenkDegistirmeFormu(this);

        }

        private void btn_Anaform_Renk_Degistir_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = frm.YeniRengiAl(BackColor);
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            //timer ile calisacagimizda alt satir acilmali
            //timer1.Start();
        }
    }
}
