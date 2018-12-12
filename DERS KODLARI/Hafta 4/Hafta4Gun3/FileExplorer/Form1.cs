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

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] drives = Directory.GetLogicalDrives();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var surucu in drives)
            {
                cmbDrivers.Items.Add(surucu);
            }
        }

        private void cmbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            string path = cmbDrivers.SelectedItem.ToString();
            treeView1.Nodes.Add(path);
            foreach (var f in Directory.EnumerateFiles(path))
            {
                TreeNode folder = new TreeNode(f);
                treeView1.Nodes.Add(folder);
            }
        }
    }
}
