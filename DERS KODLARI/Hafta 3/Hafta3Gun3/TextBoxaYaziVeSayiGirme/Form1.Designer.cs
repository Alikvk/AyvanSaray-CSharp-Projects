namespace TextBoxaYaziVeSayiGirme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_CharacterCasingToUpper = new System.Windows.Forms.TextBox();
            this.txt_CharacterCasingToLower = new System.Windows.Forms.TextBox();
            this.txt_YalnizSayi = new System.Windows.Forms.TextBox();
            this.txt_YalnizKarakter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_orange = new System.Windows.Forms.Button();
            this.btn_white = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_renk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.txt_CharacterCasingToUpper);
            this.panel1.Controls.Add(this.txt_CharacterCasingToLower);
            this.panel1.Controls.Add(this.txt_YalnizSayi);
            this.panel1.Controls.Add(this.txt_YalnizKarakter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 202);
            this.panel1.TabIndex = 0;
            // 
            // txt_CharacterCasingToUpper
            // 
            this.txt_CharacterCasingToUpper.Location = new System.Drawing.Point(189, 159);
            this.txt_CharacterCasingToUpper.Name = "txt_CharacterCasingToUpper";
            this.txt_CharacterCasingToUpper.Size = new System.Drawing.Size(157, 20);
            this.txt_CharacterCasingToUpper.TabIndex = 1;
            this.txt_CharacterCasingToUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToUpper_KeyPress);
            // 
            // txt_CharacterCasingToLower
            // 
            this.txt_CharacterCasingToLower.Location = new System.Drawing.Point(189, 112);
            this.txt_CharacterCasingToLower.Name = "txt_CharacterCasingToLower";
            this.txt_CharacterCasingToLower.Size = new System.Drawing.Size(157, 20);
            this.txt_CharacterCasingToLower.TabIndex = 1;
            this.txt_CharacterCasingToLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToLower_KeyPress);
            // 
            // txt_YalnizSayi
            // 
            this.txt_YalnizSayi.Location = new System.Drawing.Point(189, 76);
            this.txt_YalnizSayi.Name = "txt_YalnizSayi";
            this.txt_YalnizSayi.Size = new System.Drawing.Size(157, 20);
            this.txt_YalnizSayi.TabIndex = 1;
            this.txt_YalnizSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizSayi_KeyPress);
            // 
            // txt_YalnizKarakter
            // 
            this.txt_YalnizKarakter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_YalnizKarakter.Location = new System.Drawing.Point(189, 37);
            this.txt_YalnizKarakter.Name = "txt_YalnizKarakter";
            this.txt_YalnizKarakter.Size = new System.Drawing.Size(157, 20);
            this.txt_YalnizKarakter.TabIndex = 1;
            this.txt_YalnizKarakter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizKarakter_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sadece Büyük Karekter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sadece Küçük Karakter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sayı Girin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter Girin";
            // 
            // btn_orange
            // 
            this.btn_orange.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_orange.Location = new System.Drawing.Point(63, 261);
            this.btn_orange.Name = "btn_orange";
            this.btn_orange.Size = new System.Drawing.Size(114, 23);
            this.btn_orange.TabIndex = 1;
            this.btn_orange.Text = "Orange";
            this.btn_orange.UseVisualStyleBackColor = false;
            this.btn_orange.Click += new System.EventHandler(this.btn_orange_Click);
            // 
            // btn_white
            // 
            this.btn_white.BackColor = System.Drawing.Color.Wheat;
            this.btn_white.Location = new System.Drawing.Point(199, 261);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(132, 23);
            this.btn_white.TabIndex = 1;
            this.btn_white.Text = "White";
            this.btn_white.UseVisualStyleBackColor = false;
            this.btn_white.Click += new System.EventHandler(this.btn_white_Click);
            // 
            // btn_black
            // 
            this.btn_black.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_black.Location = new System.Drawing.Point(352, 261);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(97, 23);
            this.btn_black.TabIndex = 1;
            this.btn_black.Text = "Black";
            this.btn_black.UseVisualStyleBackColor = false;
            this.btn_black.Click += new System.EventHandler(this.btn_black_Click);
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(199, 12);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(100, 20);
            this.txt_renk.TabIndex = 2;
            this.txt_renk.TextChanged += new System.EventHandler(this.txt_renk_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Renk Adı";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(447, -236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_renk
            // 
            this.btn_renk.Location = new System.Drawing.Point(323, 12);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(75, 23);
            this.btn_renk.TabIndex = 4;
            this.btn_renk.Text = "Değiştir";
            this.btn_renk.UseVisualStyleBackColor = true;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(503, 296);
            this.Controls.Add(this.btn_renk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_renk);
            this.Controls.Add(this.btn_black);
            this.Controls.Add(this.btn_white);
            this.Controls.Add(this.btn_orange);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CharacterCasingToUpper;
        private System.Windows.Forms.TextBox txt_CharacterCasingToLower;
        private System.Windows.Forms.TextBox txt_YalnizSayi;
        private System.Windows.Forms.TextBox txt_YalnizKarakter;
        private System.Windows.Forms.Button btn_orange;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.TextBox txt_renk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_renk;
    }
}

