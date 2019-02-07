using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaProje
{
    public partial class FormYeniFatura : Form
    {
        FaturaContext _db = new FaturaContext();
        int _secilenID;
        public FormYeniFatura()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnInvoiceSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void FormYeniFatura_Load(object sender, EventArgs e)
        {
            MusteriListele();
            ilListele();
            ilceListele();

        }

        private void ilceListele()
        {
            
        }

        private void ilListele()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MusteriListele()
        {
            
        }
    }
}
