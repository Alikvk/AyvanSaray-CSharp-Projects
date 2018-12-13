namespace Dosyalar
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
            this.txtYol = new System.Windows.Forms.TextBox();
            this.btnDizin = new System.Windows.Forms.Button();
            this.btnDizinSil = new System.Windows.Forms.Button();
            this.lstDiskler = new System.Windows.Forms.ListBox();
            this.btnDiskler = new System.Windows.Forms.Button();
            this.lstKlasorler = new System.Windows.Forms.ListBox();
            this.btnC = new System.Windows.Forms.Button();
            this.lstDosyalar = new System.Windows.Forms.ListBox();
            this.btnDosyalar = new System.Windows.Forms.Button();
            this.btnNerede = new System.Windows.Forms.Button();
            this.lblNerde = new System.Windows.Forms.Label();
            this.txtBoxEski = new System.Windows.Forms.TextBox();
            this.txtBoxYeni = new System.Windows.Forms.TextBox();
            this.lblEski = new System.Windows.Forms.Label();
            this.lblYeni = new System.Windows.Forms.Label();
            this.btnTasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYol
            // 
            this.txtYol.Location = new System.Drawing.Point(5, 12);
            this.txtYol.Name = "txtYol";
            this.txtYol.Size = new System.Drawing.Size(303, 22);
            this.txtYol.TabIndex = 0;
            // 
            // btnDizin
            // 
            this.btnDizin.Location = new System.Drawing.Point(98, 40);
            this.btnDizin.Name = "btnDizin";
            this.btnDizin.Size = new System.Drawing.Size(75, 23);
            this.btnDizin.TabIndex = 1;
            this.btnDizin.Text = "Dizin Oluştur";
            this.btnDizin.UseVisualStyleBackColor = true;
            this.btnDizin.Click += new System.EventHandler(this.btnDizin_Click);
            // 
            // btnDizinSil
            // 
            this.btnDizinSil.Location = new System.Drawing.Point(215, 40);
            this.btnDizinSil.Name = "btnDizinSil";
            this.btnDizinSil.Size = new System.Drawing.Size(75, 23);
            this.btnDizinSil.TabIndex = 2;
            this.btnDizinSil.Text = "Dizin Sil";
            this.btnDizinSil.UseVisualStyleBackColor = true;
            this.btnDizinSil.Click += new System.EventHandler(this.btnDizinSil_Click);
            // 
            // lstDiskler
            // 
            this.lstDiskler.FormattingEnabled = true;
            this.lstDiskler.ItemHeight = 16;
            this.lstDiskler.Location = new System.Drawing.Point(5, 69);
            this.lstDiskler.Name = "lstDiskler";
            this.lstDiskler.Size = new System.Drawing.Size(63, 212);
            this.lstDiskler.TabIndex = 3;
            // 
            // btnDiskler
            // 
            this.btnDiskler.Location = new System.Drawing.Point(-8, 287);
            this.btnDiskler.Name = "btnDiskler";
            this.btnDiskler.Size = new System.Drawing.Size(63, 23);
            this.btnDiskler.TabIndex = 4;
            this.btnDiskler.Text = "Dizin Oluştur";
            this.btnDiskler.UseVisualStyleBackColor = true;
            this.btnDiskler.Click += new System.EventHandler(this.btnDiskler_Click);
            // 
            // lstKlasorler
            // 
            this.lstKlasorler.FormattingEnabled = true;
            this.lstKlasorler.ItemHeight = 16;
            this.lstKlasorler.Location = new System.Drawing.Point(74, 69);
            this.lstKlasorler.Name = "lstKlasorler";
            this.lstKlasorler.Size = new System.Drawing.Size(120, 212);
            this.lstKlasorler.TabIndex = 5;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(85, 287);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(63, 23);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C:";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lstDosyalar
            // 
            this.lstDosyalar.FormattingEnabled = true;
            this.lstDosyalar.ItemHeight = 16;
            this.lstDosyalar.Location = new System.Drawing.Point(200, 69);
            this.lstDosyalar.Name = "lstDosyalar";
            this.lstDosyalar.Size = new System.Drawing.Size(113, 212);
            this.lstDosyalar.TabIndex = 7;
            // 
            // btnDosyalar
            // 
            this.btnDosyalar.Location = new System.Drawing.Point(215, 287);
            this.btnDosyalar.Name = "btnDosyalar";
            this.btnDosyalar.Size = new System.Drawing.Size(103, 23);
            this.btnDosyalar.TabIndex = 8;
            this.btnDosyalar.Text = "C: deki Dosya";
            this.btnDosyalar.UseVisualStyleBackColor = true;
            this.btnDosyalar.Click += new System.EventHandler(this.btnDosyalar_Click);
            // 
            // btnNerede
            // 
            this.btnNerede.Location = new System.Drawing.Point(215, 330);
            this.btnNerede.Name = "btnNerede";
            this.btnNerede.Size = new System.Drawing.Size(84, 23);
            this.btnNerede.TabIndex = 9;
            this.btnNerede.Text = "Nerdeyim";
            this.btnNerede.UseVisualStyleBackColor = true;
            this.btnNerede.Click += new System.EventHandler(this.btnNerede_Click);
            // 
            // lblNerde
            // 
            this.lblNerde.AutoSize = true;
            this.lblNerde.Location = new System.Drawing.Point(13, 333);
            this.lblNerde.Name = "lblNerde";
            this.lblNerde.Size = new System.Drawing.Size(144, 17);
            this.lblNerde.TabIndex = 10;
            this.lblNerde.Text = "Nerde Olduğu Göster";
            // 
            // txtBoxEski
            // 
            this.txtBoxEski.Location = new System.Drawing.Point(115, 368);
            this.txtBoxEski.Name = "txtBoxEski";
            this.txtBoxEski.Size = new System.Drawing.Size(213, 22);
            this.txtBoxEski.TabIndex = 11;
            // 
            // txtBoxYeni
            // 
            this.txtBoxYeni.Location = new System.Drawing.Point(115, 398);
            this.txtBoxYeni.Name = "txtBoxYeni";
            this.txtBoxYeni.Size = new System.Drawing.Size(213, 22);
            this.txtBoxYeni.TabIndex = 12;
            // 
            // lblEski
            // 
            this.lblEski.AutoSize = true;
            this.lblEski.Location = new System.Drawing.Point(1, 368);
            this.lblEski.Name = "lblEski";
            this.lblEski.Size = new System.Drawing.Size(108, 17);
            this.lblEski.TabIndex = 13;
            this.lblEski.Text = "Taşınacak Dizin";
            // 
            // lblYeni
            // 
            this.lblYeni.AutoSize = true;
            this.lblYeni.Location = new System.Drawing.Point(1, 401);
            this.lblYeni.Name = "lblYeni";
            this.lblYeni.Size = new System.Drawing.Size(71, 17);
            this.lblYeni.TabIndex = 14;
            this.lblYeni.Text = "Yeni Dizin";
            // 
            // btnTasi
            // 
            this.btnTasi.Location = new System.Drawing.Point(227, 426);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(63, 23);
            this.btnTasi.TabIndex = 15;
            this.btnTasi.Text = "Taşı";
            this.btnTasi.UseVisualStyleBackColor = true;
            this.btnTasi.Click += new System.EventHandler(this.btnTasi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 457);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.lblYeni);
            this.Controls.Add(this.lblEski);
            this.Controls.Add(this.txtBoxYeni);
            this.Controls.Add(this.txtBoxEski);
            this.Controls.Add(this.lblNerde);
            this.Controls.Add(this.btnNerede);
            this.Controls.Add(this.btnDosyalar);
            this.Controls.Add(this.lstDosyalar);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.lstKlasorler);
            this.Controls.Add(this.btnDiskler);
            this.Controls.Add(this.lstDiskler);
            this.Controls.Add(this.btnDizinSil);
            this.Controls.Add(this.btnDizin);
            this.Controls.Add(this.txtYol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.Button btnDizin;
        private System.Windows.Forms.Button btnDizinSil;
        private System.Windows.Forms.ListBox lstDiskler;
        private System.Windows.Forms.Button btnDiskler;
        private System.Windows.Forms.ListBox lstKlasorler;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.ListBox lstDosyalar;
        private System.Windows.Forms.Button btnDosyalar;
        private System.Windows.Forms.Button btnNerede;
        private System.Windows.Forms.Label lblNerde;
        private System.Windows.Forms.TextBox txtBoxEski;
        private System.Windows.Forms.TextBox txtBoxYeni;
        private System.Windows.Forms.Label lblEski;
        private System.Windows.Forms.Label lblYeni;
        private System.Windows.Forms.Button btnTasi;
    }
}

