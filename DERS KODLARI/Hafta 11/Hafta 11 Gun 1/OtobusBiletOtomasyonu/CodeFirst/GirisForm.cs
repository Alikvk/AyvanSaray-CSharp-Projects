using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) == false && string.IsNullOrWhiteSpace(txtPassword.Text) == false)
            {
                if (txtUserName.Text=="ali" && txtPassword.Text=="1234")
                {
                    AnaForm giris = new AnaForm();
                    giris.Show();
                   
                    

                }
                else if (txtUserName.Text == "mstf" && txtPassword.Text == "1234")
                {
                    AnaForm giris = new AnaForm();
                    giris.Show();
                    

                }
            }
        }
    }
}
