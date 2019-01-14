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

namespace DovizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lstBoxDoviz.Items.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rootEleman = xmlDoc.DocumentElement;
            XmlNodeList liste=xmlDoc.GetElementsByTagName("Currency");
            List<Doviz> dlist = new List<Doviz>();
            foreach (var item in liste)
            {
                Doviz d = new Doviz();
                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;
                d.DovizAdi = isim;
                string alisFiyati=currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string satisFiyati = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                string birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;
                if (!string.IsNullOrEmpty(alisFiyati.Replace(".",",")))
                {
                    d.AlisFiyati = Convert.ToDecimal(alisFiyati);
                }
                if (!string.IsNullOrEmpty(satisFiyati))
                {
                    d.SatiFiyati = Convert.ToDecimal(satisFiyati.Replace(".", ","));

                }
                if (!string.IsNullOrEmpty(birim))
                {
                    d.Birim = Convert.ToInt32(birim);

                }
                lstBoxDoviz.Items.Add(d);
                dlist.Add(d);

            }
            dataGridDoviz.DataSource = dlist;
            int i = 0;
            foreach (var item in dlist)
            {
                try
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = item.DovizAdi;
                    dataGridView1.Rows[i].Cells[1].Value = item.SatiFiyati;
                    i++;
                }
                catch (Exception)
                {
                    
                }
            }

        }

        private void lstBoxDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doviz secilenDovizler =  (Doviz)lstBoxDoviz.SelectedItem; ;
            
            lblBirim.Text = secilenDovizler.Birim.ToString();
            lblAlis.Text = secilenDovizler.AlisFiyati.ToString();
            lblSatis.Text = secilenDovizler.SatiFiyati.ToString();


        }
    }
}
