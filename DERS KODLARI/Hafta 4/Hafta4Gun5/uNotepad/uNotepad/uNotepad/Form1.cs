using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 1;
        private void AddFormToTabPage(TabPage page)
        {
            uNote note = new uNote();
            //Bu islemi yapmazsak, TabPage'lerimizin icinde bir Form acamayiz...
            note.TopLevel = false;
            //Visible ozellgini true'ya cekmeyince, Form ekleme islemi yapiliyor fakat Form gorunmuyor
            note.Visible = true;
            note.Dock = DockStyle.Fill;

            page.Controls.Add(note);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddFormToTabPage(tabPage1);
            tabPage1.Tag = 1;
        }

        private void toolButtonNew_Click(object sender, EventArgs e)
        {
           
            
           // int tabSayi= tabControl1.TabPages.Count
            //TabControl kontrolu icinde TabPage'ler barindirabilir.
            //Her New butonuna tiklanildiginda hafizada yeni bir TabPage kontrolu olusturup
            //Olusturulan yeni Page'imizin icine Form'mumuzu ekliyoruz
            TabPage tPage = new TabPage();

            //Olusturulan yeni sayfanin(TabPage) icine formumuzu eklemek icin yazdigimiz methodu cagiriyoruz
            AddFormToTabPage(tPage);

            //Olusturulan ve icine Form yerlestirilen Page'imizi TabControl kontrolune ekliyoruz
            tabControl1.Controls.Add(tPage);

            //Yeni acilan her Page'in uzerinde yazan ismi farkli olsun diye, var olan
            //Page sayifimizi belirleyip, yeni Page'imizin Text'ini ona gore belirliyoruz
            int enBuyukSayfaNo=0;
            // enBuyukSayfaNo = 1; 
            foreach (TabPage t in tabControl1.TabPages)
            {
                if (t.Tag is int)
                {
                    if ((int)t.Tag> enBuyukSayfaNo)
                    {
                        enBuyukSayfaNo = (int)t.Tag;
                    }
                }
            }

            // tPage.Text = "new " + tabControl1.TabPages.Count.ToString();
            tPage.Tag = enBuyukSayfaNo + 1;
            tPage.Text = "new " + (enBuyukSayfaNo + 1).ToString();
            tabControl1.SelectedTab = tPage;
        }

        private void toolButtonSave_Click(object sender, EventArgs e)
        {
            //((uNote)tabControl1.SelectedTab.Controls[0]).Kaydet();
            TabPage selectedPage = tabControl1.SelectedTab;
            uNote currentForm = (uNote)selectedPage.Controls[0];
            currentForm.Kaydet();
        }

        private void toolButtonOpen_Click(object sender, EventArgs e)
        {
            //Kullanici hangi dosyayi sectiyse (*Yanlizca RTF ve TXT dosyalari secebilir.) o dosyanin yolunu getirir
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TabPage tPage = new TabPage();
                List<string> tabsName = new List<string>();
                bool foundOpen = false;
                foreach (TabPage t in tabControl1.TabPages)
                {
                    if (t.Tag is string && (string)t.Tag== openFileDialog1.SafeFileName)
                    {
                        tabControl1.SelectedTab = t;
                        foundOpen=true;

                    }
                }
                if (foundOpen)
                {
                    return;
                }
                AddFormToTabPage(tPage);
                tabControl1.Controls.Add(tPage);
                tPage.Text = openFileDialog1.SafeFileName;
                tPage.Tag = openFileDialog1.SafeFileName;

                //tPage.Text = "new " + tabControl1.TabPages.Count.ToString();
                tabControl1.SelectedTab = tPage;
                uNote currentForm = (uNote)tPage.Controls[0];
                currentForm.DosyaAc(openFileDialog1.FileName);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //secili olan TabPage'imize ulasiyoruz
            TabPage selectedPage = tabControl1.SelectedTab;
            //secili TabPage'in icinden 0 indisli kontrolu uNote'a Cast edip degiskene atiyoruz.
            //Zaten tum TabPage'lerimizin icinde tek bir kontrol var, o da uNote... Gonul rahatligiyla bu islemi yapabiliriz.
            uNote currentForm = (uNote)selectedPage.Controls[0];
            currentForm.Close();

            //if (currentForm.Controls.Count == 0)
            //   tabControl1.TabPages.Remove(selectedPage);

            //Yukaridaki Close() metodundan sonra Form kapanmamis olabilir. 
            //Kullanici kapatma islemini "IPTAL" etmis olabilir.
            //Iptal edilmis mi ogrenebilmek icin, uNote formuna fazladan bir degisken tanimladik(_kapatildiMi) 
            //ve kapatilma islemi yapildi mi diye burada kontrol ettik
            if (currentForm._kapatildiMi)
                tabControl1.TabPages.Remove(selectedPage);
        }

        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TabPage selectedPage = tabControl1.SelectedTab;
                uNote currentForm = (uNote)selectedPage.Controls[0];
                currentForm.YaziRengiDegistir(colorDialog1.Color);
            }
        }

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TabPage selectedPage = tabControl1.SelectedTab;
                uNote currentForm = (uNote)selectedPage.Controls[0];
                currentForm.YaziTipiDegistir(fontDialog1.Font);
            }
        }

        private void hepsiBuyukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage selectedPage = tabControl1.SelectedTab;
            uNote currentForm = (uNote)selectedPage.Controls[0];
            currentForm.YaziBuyukHarfYap();
        }

        private void hepsiKucukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage selectedPage = tabControl1.SelectedTab;
            uNote currentForm = (uNote)selectedPage.Controls[0];
            currentForm.YaziKucukHarfYap();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AramaFormu araForm = new AramaFormu())
            {
                if (araForm.ShowDialog() == DialogResult.OK)
                {
                    TabPage selectedPage = tabControl1.SelectedTab;
                    uNote currentForm = (uNote)selectedPage.Controls[0];
                    currentForm.Ara(araForm._arananKelime);
                }
            }
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About hakkimizda = new About();
            hakkimizda.Show();
        }
    }
}
