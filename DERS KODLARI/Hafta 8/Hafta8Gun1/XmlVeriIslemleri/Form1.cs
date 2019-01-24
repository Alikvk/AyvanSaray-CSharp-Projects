using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XmlVeriIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaninYolu = Application.StartupPath + "\\CalisanListesi.xml";
        
        const string veritabani = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        const string veritabaniPubs = @"Data Source=localhost;Initial Catalog = pubs; Integrated Security = True";
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
            // XmlNode secilenNode1 = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TcNo='12345678902']"); value kısmındaki değeri aramak için kullanırız
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
            XmlNode secilenNode1 = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            if (secilenNode != null)
            {
                xmlDoc.DocumentElement.RemoveChild(secilenNode1);
                xmlDoc.Save(dosyaninYolu);
                MessageBox.Show("Melek Dosyadan Silindi");
            }
            else
            {
                MessageBox.Show("Aranan kisi 'Melek' bulunamadi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            //foreach (XmlNode item in secilenNode)
            //{
            //    if (item.ChildNodes[0].InnerText == "Can" || item.Attributes["TcNo"].Value == "12345678901")
            //    {
            //        item.ParentNode.RemoveChild(item);
            //        xmlDoc.Save(dosyaninYolu);
            //        bulundu = true;
            //        break;
            //    }
            //}
            //if (!bulundu)
            //{
            //    MessageBox.Show("Aranilan kişi Bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


            webBrowser1.Url = new Uri(dosyaninYolu);

        }

        private void btnXpathileVerileriBul_Click(object sender, EventArgs e)
        {
            //Xpath ile bir çok veriyi aynı anda iterate etmemizi sağlamaktadır
            XPathDocument xmlDoc = new XPathDocument(dosyaninYolu);
            XPathNavigator xNav = xmlDoc.CreateNavigator();
            XPathNodeIterator secilenNode = xNav.Select("Calisanlar/Calisan/Adi");

            string metin = "";
            while (secilenNode.MoveNext())
            {
                if (secilenNode.Current.InnerXml.StartsWith("C"))
                {
                    metin += secilenNode.Current.InnerXml + "\n";
                }
               
            }
            if (metin != "")
            {
                MessageBox.Show("Adi C ile Baslayanlar \n" + metin);
            }
            else
            {
                MessageBox.Show("Adi C ile baslayan Bulunamadi");
            }
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void btnVeriDegistir_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaninYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");

            if (secilenNode != null)
            {
                //soyadina ekle
                secilenNode.ChildNodes[1].InnerText += "Galipler";
                xmlDoc.Save(dosyaninYolu);
                MessageBox.Show("Soyadina Ekleme Yapildi:\n\n"
                    +secilenNode.ChildNodes[0].InnerText+""
                    +secilenNode.ChildNodes[1].InnerText);
                //this.btnVeriOku.Click(sender,e);
            }
            else
            {
                MessageBox.Show("Aranan kişi 'Melek' bulunamadi","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaninYolu);
            XmlElement yeniEleman = xmlDoc.CreateElement("Calisan");

            XmlAttribute attrTcNo = xmlDoc.CreateAttribute("TcNo");
            attrTcNo.Value = "12345678904";
            yeniEleman.Attributes.Append(attrTcNo);

            XmlNode xAdi = xmlDoc.CreateElement("Adi");
            xAdi.InnerText = "Buse";
            yeniEleman.AppendChild(xAdi);

            XmlNode xSoyadi = xmlDoc.CreateElement("Soyadi");
            xSoyadi.InnerText = "Zengin";
            yeniEleman.AppendChild(xSoyadi);

            XmlNode xYil = xmlDoc.CreateElement("DogumYili");
            xYil.InnerText = "1985";
            yeniEleman.AppendChild(xYil);

            xmlDoc.DocumentElement.AppendChild(yeniEleman);
            xmlDoc.Save(dosyaninYolu);
            btnVeriOku_Click( sender,  e);
            MessageBox.Show("Buse Eklendi");
            webBrowser1.Url = new Uri(dosyaninYolu);
        }

        private void btnSQLtoXML_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(veritabani);
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Products",cnn);
            DataTable dt = new DataTable("Products");// Bir tablo gösteriyor
            adp.Fill(dt);

            DataSet ds = new DataSet("Products");// Birden çok tablo içeriyor
            ds.Tables.Add(dt);

            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr !=DialogResult.OK)
            {
                return;
            }
            string dosya = fd.SelectedPath+"\\SQLtoXML.xml";
            ds.WriteXml(dosya);
            MessageBox.Show("Sql den gelen veriler XML dosyasına yazıldı.\n"+dosya);
            webBrowser1.Url = new Uri(dosya);
        }

        private void btnXMLtoSQL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string dosya = fd.SelectedPath + "\\SQLtoXML.xml";
                if (File.Exists(dosya))
                {
                    SqlConnection cnn = new SqlConnection(veritabani);
                    SqlDataAdapter adp = new SqlDataAdapter("Select * from ProductsX",cnn);

                    SqlCommandBuilder cb = new SqlCommandBuilder(adp);
                    DataSet ds = new DataSet();
                    ds.ReadXml(dosya);
                    adp.Update(ds.Tables[0]);
                    MessageBox.Show("XML'den okunan veriler ProductsX tablosuna kaydedildi");
                    webBrowser1.Url = new Uri(dosya);
                }
                else
                {
                    MessageBox.Show("Dosya Bulunamadi. \n"+dosya,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        private void btnSechemaOlustur_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(veritabani);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select ProductID, ProductName, UnitPrice from Products", conn);
            DataTable dataTable = new DataTable("XProduct");
            dataAdapter.Fill(dataTable);
            DataSet dataSet = new DataSet("XProducts");
            dataSet.Tables.Add(dataTable);

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dosya = dialog.SelectedPath + "\\mySchema.xsd";
                dataSet.WriteXmlSchema(dosya);
                MessageBox.Show("SQL'den gelen sorguya göre XML şema bilgisi dosyaya yazıldı");
                webBrowser1.Url = new Uri(dosya);
            }
        }
        private void btnSQLtoSchema_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "XML schema dosyasının bulunduğu klasörü seçiniz";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string secilenDosya = dialog.SelectedPath + "\\mySchema.xsd";
                if (File.Exists(secilenDosya))
                {
                    //Farkli bir veritabanından xml şemasına uygun olarak veri alınıyor.
                   // SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=pubs;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(veritabaniPubs);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select pub_id AS ProductID, title AS ProductName, price AS UnitePrice from titles", conn);
                    DataTable dataTable = new DataTable("XProduct");
                    //Şemayı kullanarak veri okuması gerekiyor
                    dataTable.ReadXmlSchema(secilenDosya);
                    dataAdapter.Fill(dataTable);
                    DataSet dataSet = new DataSet("XProducts");
                    dataSet.Tables.Add(dataTable);

                    FolderBrowserDialog dialog2 = new FolderBrowserDialog();
                    DialogResult result2 = dialog2.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        string xmlDosya = dialog2.SelectedPath + "\\semaya_uygun_veri.xml";
                        dataSet.WriteXml(xmlDosya);
                        MessageBox.Show("SQL'den gelen sorguya göre XML şema bilgisi dosyaya yazıldı \n" + xmlDosya);
                        webBrowser1.Url = new Uri(xmlDosya);
                    }
                }
                else
                {
                    MessageBox.Show("XML şema dosyası bulunamadı. \n" + secilenDosya);
                }
            }
        }

      
    }
}
