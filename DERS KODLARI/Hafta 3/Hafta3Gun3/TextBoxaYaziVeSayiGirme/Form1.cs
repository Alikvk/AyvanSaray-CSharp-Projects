using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxaYaziVeSayiGirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_YalnizKarakter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txt_YalnizSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
                e.Handled = true;
        }

        private void txt_CharacterCasingToLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToLower.CharacterCasing = CharacterCasing.Lower;
        }

        private void txt_CharacterCasingToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToUpper.CharacterCasing = CharacterCasing.Upper;

        }

        private void btn_orange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void btn_white_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        private void btn_black_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.();
        }

        private void txt_renk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
