using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            picBoxTarget.AllowDrop = true;
        }

        private void PicSource_MouseDown(object sender, MouseEventArgs e)
        {

            // Eğer mousen sol tuşu ile basılıyorsa kopyalamaya izin ver
            if (e.Button == MouseButtons.Left)
            {
                picBoxSource.DoDragDrop(picBoxSource.Image,
                    DragDropEffects.Copy);
            }
        }

        private void picTarget_DragEnter(object sender, DragEventArgs e)
        {

            // See if this is a copy and the data includes an image.

            //if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
            //  (e.AllowedEffect & DragDropEffects.Copy) != 0)
            //{
            //    // Allow this.
            //    e.Effect = DragDropEffects.Copy;
            //}


            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
                (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Resim olursa onay ver
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Başka tür ise izin verme
                e.Effect = DragDropEffects.None;
            }
        }

        private void picTarget_DragDrop(object sender, DragEventArgs e)
        {
            picBoxTarget.Image =
       (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            picBoxSource.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi Pictıre Boxa sığdırma işlemi
            picBoxTarget.SizeMode = PictureBoxSizeMode.StretchImage;

            openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picBoxSource.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
