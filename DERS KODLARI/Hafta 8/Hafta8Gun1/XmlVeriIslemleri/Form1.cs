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

namespace XmlVeriIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaninYolu = Application.StartupPath + "\\CalisanListesi.xml";
        private void btnVeriOku_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(dosyaninYolu);
            dataGridView1.DataSource = ds.Tables[0];
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void btnVeriBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaninYolu);
            XmlNode secilenNode = xmlDoc.ChildNodes[1];// 0. indisinde "{XmlDeclaration, Value="version=\"1.0\" encoding=\"utf-8\""}" kısmı bulunmakta
            bool bulundu = false; // İstenilen ismin bulunup bulunmadığını görmekteyiz
            foreach (XmlNode item in secilenNode)
            {
                if (item.ChildNodes[0].InnerText=="Can" || item.Attributes["TcNo"].Value=="12345678901" )
                {
                    MessageBox.Show("Aranan kişi Foreach yaparak bulundu : \n \n"
                        +item.ChildNodes[0].InnerText+" "
                        + item.ChildNodes[1].InnerText + "\n"
                        + item.ChildNodes[2].InnerText + "\n"
                        +"TCNO : " + item.Attributes["TcNo"].Value);
                    bulundu = true;
                    break;
                }
               
            }
            if (!bulundu)
            {
                MessageBox.Show("Aranilan kişi Bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void btnXPathIleTagBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaninYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            // XmlNode secilenNode1 = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TcNo='12345678902']");
            if (secilenNode !=null)
            {
                MessageBox.Show("Aranan Kişi Xpath ile Kolayca Bulundu: \n \n"
                    +secilenNode.ChildNodes[0].InnerText + " "
                    +secilenNode.ChildNodes[1].InnerText + " "
                    +secilenNode.ChildNodes[2].InnerText + " "
                    +"TCNO: " + secilenNode.Attributes["TcNo"].Value);
            }
            else
            { 
                MessageBox.Show("Aranan Kisi 'Melek' bulunamadi.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaninYolu);
            XmlNode secilenNode = xmlDoc.ChildNodes[1];
            bool bulundu = false;
            foreach (XmlNode item in secilenNode)
            {
                if (item.ChildNodes[0].InnerText == "Can" || item.Attributes["TcNo"].Value == "12345678901")
                {
                    item.ParentNode.RemoveChild(item);
                    xmlDoc.Save(dosyaninYolu);
                    bulundu = true;
                    break;
                }
            }
            if (!bulundu)
            {
                MessageBox.Show("Aranilan kişi Bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaninYolu);

        }
    }
}
