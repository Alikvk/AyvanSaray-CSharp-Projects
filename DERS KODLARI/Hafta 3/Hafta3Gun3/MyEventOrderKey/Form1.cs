using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEventOrderKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Yaz(string EventAdi)
        {
            lstBoxOlay.Items.Add(string.Format("{1} {0}", EventAdi, DateTime.Now));
        }
        private void pnlOlay_MouseDown(object sender, MouseEventArgs e)
        {
            Yaz("MouseDown");
        }

        private void pnlOlay_MouseEnter(object sender, EventArgs e)
        {
            Yaz("MouseEnter");

        }

        private void pnlOlay_MouseHover(object sender, EventArgs e)
        {
            Yaz("MouseHover");

        }

        private void pnlOlay_MouseLeave(object sender, EventArgs e)
        {
            Yaz("MouseLeave");

        }

        private void pnlOlay_MouseMove(object sender, MouseEventArgs e)
        {
           // Yaz("MouseMove");

        }

        private void pnlOlay_MouseUp(object sender, MouseEventArgs e)
        {
            Yaz("MouseUp");

        }
    }
}
