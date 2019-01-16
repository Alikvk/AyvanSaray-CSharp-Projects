using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MondialS1
{
    public partial class Form1 : Form
    {
        string dosyaYolu = Application.StartupPath +"\\mondial.xml";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.ChildNodes[2];
            foreach (XmlNode item in secilenNode)
            {
                if (item.Name=="country")
                {
                    lstListele.Items.Add(item.Attributes["name"].Value);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(dosyaYolu);
        }
    }
}
