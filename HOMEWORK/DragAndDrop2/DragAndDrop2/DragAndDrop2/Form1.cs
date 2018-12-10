using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop2
{
    public partial class Form1 : Form
    {
        bool suruklenebilir=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenebilir = true;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenebilir)
            {
                pictureBox1.Left = e.X + pictureBox1.Left;
                pictureBox1.Top = e.Y + pictureBox1.Top;  
                // Taşıma kodlarımız

            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenebilir = false;
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenebilir = true;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenebilir)
            {
                button1.Left = e.X + button1.Left;
                button1.Top = e.Y + button1.Top;  
                // Taşıma kodlarımız

            }
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenebilir = false;
        }
    }
}
