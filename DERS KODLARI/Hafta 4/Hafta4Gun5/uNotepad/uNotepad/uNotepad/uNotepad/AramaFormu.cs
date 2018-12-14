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
    public partial class AramaFormu : Form
    {
        public AramaFormu()
        {
            InitializeComponent();
        }

        public string _arananKelime;

        private void btnAra_Click(object sender, EventArgs e)
        {
            _arananKelime = txtAranan.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
