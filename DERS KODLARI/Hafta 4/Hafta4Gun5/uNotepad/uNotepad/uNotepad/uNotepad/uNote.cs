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
    public partial class uNote : Form
    {
        public uNote()
        {
            InitializeComponent();
        }

        bool _textDegistiMi = false;

        public bool _kapatildiMi = false;

        public void Kaydet()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //FilterIndex indislemeye 0'dan degil 1'den basladigi icin ve dun oraya 'FilterIndex == 0' diye sart yazdigimiz icin hata aliyorduk
                //Kullanici RTF format secmis olsa bile, FilterIndex hicbir zaman '0' olmadigi icin, her dokumani PlainText formatinda kaydediyorduk
                if (saveFileDialog1.FilterIndex == 1)
                {
                    richBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    TabControl tabcontrol = new TabControl();

                    
                }
                else
                {
                    richBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                }
                //ternary if
                //richBox.SaveFile(saveFileDialog1.FileName, (saveFileDialog1.FilterIndex == 0) ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
            }
        }

        public void DosyaAc(string acilacakDosyaninYolu)
        {
            //EndsWith string bir ifadenin en sonunda, belirtilen kelimenin olup olmadigini bakar
            if (acilacakDosyaninYolu.EndsWith("txt"))
            {
                richBox.LoadFile(acilacakDosyaninYolu, RichTextBoxStreamType.PlainText);
               
            }
            else
            {
                richBox.LoadFile(acilacakDosyaninYolu);
            }
        }

        public void YaziRengiDegistir(Color renk)
        {
            richBox.SelectionColor = renk;
        }

        public void YaziTipiDegistir(Font yeniFont)
        {
            richBox.SelectionFont = yeniFont;
        }

        public void YaziBuyukHarfYap()
        {
            richBox.SelectedText = richBox.SelectedText.ToUpper();
        }

        public void YaziKucukHarfYap()
        {
            richBox.SelectedText = richBox.SelectedText.ToLower();
            
        }

        public void Ara(string arananMetin)
        {
            richBox.Find(arananMetin);
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richBox.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richBox.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richBox.Paste();
        }

        private void uNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_textDegistiMi)
            {
                DialogResult result = MessageBox.Show("Dosyayi kaydedeyim mi?", "uNotepad", MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case DialogResult.Yes:
                        //SaveFileDialog acilacak
                        Kaydet();
                        break;
                    case DialogResult.Cancel:
                        //kapatma islemi iptal edilecek
                        e.Cancel = true;
                        break;
                }
            }
            _kapatildiMi = !e.Cancel;
        }

        private void richBox_TextChanged(object sender, EventArgs e)
        {
            _textDegistiMi = true;
        }
    }
}
