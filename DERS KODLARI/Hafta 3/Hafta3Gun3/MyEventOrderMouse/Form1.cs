using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEventOrderMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtOlay_KeyDown(object sender, KeyEventArgs e)
        {
            Yaz("KeyDown");
        }
        private void Yaz(string OlayAdi)
        {
            lstboxOlay.Items.Add(string.Format("{1} {0}", OlayAdi, DateTime.Now));
        }

        private void txtOlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Yaz("KeyPress");

        }

        private void txtOlay_KeyUp(object sender, KeyEventArgs e)
        {
            Yaz("KeyUP");
        }
        
        private void txtOlay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Yaz("PreviewKeyDown");
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lstboxOlay.Items.Clear();
        }
    }
}
