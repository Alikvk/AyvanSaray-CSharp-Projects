namespace XMLSerializitionDeserializition
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDeserialization = new System.Windows.Forms.Button();
            this.btnSerialization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEklenen = new System.Windows.Forms.ListBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 29);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(166, 29);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 82);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(166, 28);
            this.txtSoyad.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(99, 214);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 40);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDeserialization
            // 
            this.btnDeserialization.Location = new System.Drawing.Point(365, 201);
            this.btnDeserialization.Name = "btnDeserialization";
            this.btnDeserialization.Size = new System.Drawing.Size(105, 67);
            this.btnDeserialization.TabIndex = 1;
            this.btnDeserialization.Text = "Deserialization";
            this.btnDeserialization.UseVisualStyleBackColor = true;
            this.btnDeserialization.Click += new System.EventHandler(this.btnDeserialization_Click);
            // 
            // btnSerialization
            // 
            this.btnSerialization.Location = new System.Drawing.Point(365, 85);
            this.btnSerialization.Name = "btnSerialization";
            this.btnSerialization.Size = new System.Drawing.Size(105, 68);
            this.btnSerialization.TabIndex = 1;
            this.btnSerialization.Text = "Serialization";
            this.btnSerialization.UseVisualStyleBackColor = true;
            this.btnSerialization.Click += new System.EventHandler(this.btnSerialization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // listBoxEklenen
            // 
            this.listBoxEklenen.FormattingEnabled = true;
            this.listBoxEklenen.Location = new System.Drawing.Point(594, 29);
            this.listBoxEklenen.Name = "listBoxEklenen";
            this.listBoxEklenen.Size = new System.Drawing.Size(194, 407);
            this.listBoxEklenen.TabIndex = 3;
            this.listBoxEklenen.SelectedIndexChanged += new System.EventHandler(this.listBoxEklenen_SelectedIndexChanged);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(99, 133);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(166, 20);
            this.dtpDogumTarihi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.listBoxEklenen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSerialization);
            this.Controls.Add(this.btnDeserialization);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDeserialization;
        private System.Windows.Forms.Button btnSerialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxEklenen;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label3;
    }
}

