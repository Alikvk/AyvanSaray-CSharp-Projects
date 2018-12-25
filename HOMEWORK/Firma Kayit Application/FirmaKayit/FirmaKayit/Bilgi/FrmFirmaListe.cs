using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmaKayit.Hangar;

namespace FirmaKayit.Bilgi
{
    public partial class FrmFirmaListe : Form
    {
        DbFirmaDataContext _db = new DbFirmaDataContext();// Databasedeki tablolara ulaşabilmemizi sağlar
        int _secimId = -1;
        public bool Secim = false;
        public FrmFirmaListe()
        {
            InitializeComponent();
        }

        private void FrmFirmaListe_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.bgFirmaKayits
                       where s.Fadi.Contains(txtFadi.Text)
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Fno;
                Liste.Rows[i].Cells[1].Value = k.Fadi;
                Liste.Rows[i].Cells[2].Value = k.Ftipi;
                Liste.Rows[i].Cells[3].Value = k.Ftel1;
                Liste.Rows[i].Cells[4].Value = k.Ftel2;

                i++;
            }
            Liste.AllowUserToAddRows = false; // Kullanıcı Dışarıdan veri eklemesin
            Liste.ReadOnly = true;// Dışarıdan değiştirilme etki edilmesin
        }
        void Sec()
        {
            try
            {
                if (Liste.CurrentRow != null) _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                _secimId = -1;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
                Sec();
                if (Secim && _secimId > 0)
                {
                    AnaSayfa.Aktarma = _secimId;
                    Close();
                }
            
        }
    }
}
