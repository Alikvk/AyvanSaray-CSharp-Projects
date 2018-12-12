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

namespace TreeViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            string[] drives = Directory.GetLogicalDrives();
            foreach (var surucu in drives)
            {
                TreeNode surucuNode = new TreeNode(surucu);
                treeView1.Nodes.Add(surucuNode);
                string[] altKlasorler;
                MessageBox.Show("Cok Once " + surucu);
                altKlasorler = Directory.GetDirectories(surucu);
                if (altKlasorler.Count() == 0)
                    MessageBox.Show("Sıfır Alt " + surucu);

                MessageBox.Show("Once " + surucu);
                foreach (var altklasor in altKlasorler)
                {
                    TreeNode altnode = new TreeNode(altklasor);
                    surucuNode.Nodes.Add(altnode);
                }
                MessageBox.Show("Sonra " + surucu);

            }
            //var driveList = DriveInfo.GetDrives();

            //foreach (DriveInfo drive in driveList)
            //{
            //    if (drive.DriveType == DriveType.Removable)
            //    {
            //        TreeNode usb = new TreeNode(drive.ToString());
            //        treeView1.Nodes.Add(usb);
            //        string[] altKlasorlerUsb;
            //        altKlasorlerUsb = Directory.GetDirectories(drive.ToString());
            //        foreach (var altklasor in altKlasorlerUsb)
            //        {
            //            TreeNode altNodeUsb = new TreeNode(altklasor);
            //            usb.Nodes.Add(altNodeUsb);
            //        }

            //    }
            //}

        }
    }
}
