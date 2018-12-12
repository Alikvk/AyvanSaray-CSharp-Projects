using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDirectoryExample
{
    public partial class Form1 : Form
    {// Move Kısmı Eksik
        public Form1()
        {
            InitializeComponent();
        }
        string[] drives = Directory.GetLogicalDrives();
        private void btnDiskler_Click(object sender, EventArgs e)
        {
           
            foreach (var surucu in drives)
            {
               
                listBox1.Items.Add(surucu);
                
            }
        }

        private void btnCFolder_Click(object sender, EventArgs e)
        {
            
            SubDirectors(@"C:\");
        }

        public void SubDirectors(string path)
        {
            foreach (var p in Directory.GetDirectories(path))
            {
                
                listBox2.Items.Add(p);
               
            }
        }

        private void btnCdekiler_Click(object sender, EventArgs e)
        {
            //C:\\ in files showing
            foreach (var p in Directory.GetFiles(@"C:\"))
            {

                listBox3.Items.Add(p);

            }
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            lblCurrentPath.Text = Directory.GetCurrentDirectory();
        }

        private void btdDizinOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(txtBoxPath.Text);
                MessageBox.Show("Folder Created");
            }
            catch (Exception)
            {
                MessageBox.Show("Path Wrong Please Try Again..");
                
            }
        }

        private void btnDizinSil_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(txtBoxPath.Text);
                MessageBox.Show("Delete Folder");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string source = txtBoxSource.Text;
            string target = txtBoxSource.Text;
            try
            {
                if (Directory.Exists(source))
                {
                    if (Directory.Exists(target))
                    {
                        Directory.Delete(target);
                    }

                    Directory.Move(source, target);
                    SubDirectors(@"C:\");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured! Error Message: " + exc.Message);
            }
        }
    }
}
