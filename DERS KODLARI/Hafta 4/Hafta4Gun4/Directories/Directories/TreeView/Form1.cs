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

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sürücülerin listesi alınıyor
            string[] suruculer = Directory.GetLogicalDrives();
            // Sürücüler Listesinde dönülüyor.
            foreach (var surucu in suruculer)
            {
                // Tüm sürücüleri okuyor
                TreeNode SurucuNode = new TreeNode(surucu);
                // Node ekliyor.
                treeView1.Nodes.Add(SurucuNode);
                string[] altKlasorler;

                altKlasorler = Directory.GetDirectories(surucu);

                foreach (var altKlasor in altKlasorler)
                {
                    TreeNode altnode = new TreeNode(altKlasor);
                    SurucuNode.Nodes.Add(altnode);
                }
            }
        }
    }
}
