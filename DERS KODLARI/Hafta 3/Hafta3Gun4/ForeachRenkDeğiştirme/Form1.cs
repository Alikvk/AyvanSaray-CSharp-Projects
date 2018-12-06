using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachRenkDeğiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            foreach (Control nesne in this.Controls)
            {
                if ((nesne) is TextBox)
                {
                    nesne.BackColor = Color.Red;
                    nesne.ForeColor = Color.White;


                }
            }
        }
    }
}
