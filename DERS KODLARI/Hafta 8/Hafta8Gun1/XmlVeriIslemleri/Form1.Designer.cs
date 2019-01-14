namespace XmlVeriIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnVeriBul = new System.Windows.Forms.Button();
            this.btnSQLtoXML = new System.Windows.Forms.Button();
            this.btnXPathIleTagBul = new System.Windows.Forms.Button();
            this.btnXMLtoSQL = new System.Windows.Forms.Button();
            this.btnXpathileVerileriBul = new System.Windows.Forms.Button();
            this.btnSechemaOlustur = new System.Windows.Forms.Button();
            this.btnVeriDegistir = new System.Windows.Forms.Button();
            this.btnVeriSil = new System.Windows.Forms.Button();
            this.btnSQLtoSchema = new System.Windows.Forms.Button();
            this.btnXMLSchemaDogrula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(12, 223);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(158, 46);
            this.btnVeriOku.TabIndex = 1;
            this.btnVeriOku.Text = "XML Dosyasından Veri Oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(237, 223);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(169, 46);
            this.btnAddChild.TabIndex = 1;
            this.btnAddChild.Text = "XML\'e veri Ekle";
            this.btnAddChild.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(412, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(435, 511);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnVeriBul
            // 
            this.btnVeriBul.Location = new System.Drawing.Point(12, 275);
            this.btnVeriBul.Name = "btnVeriBul";
            this.btnVeriBul.Size = new System.Drawing.Size(158, 46);
            this.btnVeriBul.TabIndex = 1;
            this.btnVeriBul.Text = "XML içindeki Veriyi Bul";
            this.btnVeriBul.UseVisualStyleBackColor = true;
            this.btnVeriBul.Click += new System.EventHandler(this.btnVeriBul_Click);
            // 
            // btnSQLtoXML
            // 
            this.btnSQLtoXML.Location = new System.Drawing.Point(237, 275);
            this.btnSQLtoXML.Name = "btnSQLtoXML";
            this.btnSQLtoXML.Size = new System.Drawing.Size(169, 46);
            this.btnSQLtoXML.TabIndex = 1;
            this.btnSQLtoXML.Text = "Veritabanından XML e oku";
            this.btnSQLtoXML.UseVisualStyleBackColor = true;
            // 
            // btnXPathIleTagBul
            // 
            this.btnXPathIleTagBul.Location = new System.Drawing.Point(12, 327);
            this.btnXPathIleTagBul.Name = "btnXPathIleTagBul";
            this.btnXPathIleTagBul.Size = new System.Drawing.Size(158, 46);
            this.btnXPathIleTagBul.TabIndex = 1;
            this.btnXPathIleTagBul.Text = "XML de veriyi XPath ile Bul";
            this.btnXPathIleTagBul.UseVisualStyleBackColor = true;
            this.btnXPathIleTagBul.Click += new System.EventHandler(this.btnXPathIleTagBul_Click);
            // 
            // btnXMLtoSQL
            // 
            this.btnXMLtoSQL.Location = new System.Drawing.Point(237, 327);
            this.btnXMLtoSQL.Name = "btnXMLtoSQL";
            this.btnXMLtoSQL.Size = new System.Drawing.Size(169, 46);
            this.btnXMLtoSQL.TabIndex = 1;
            this.btnXMLtoSQL.Text = "XML den veritabanına Yaz";
            this.btnXMLtoSQL.UseVisualStyleBackColor = true;
            // 
            // btnXpathileVerileriBul
            // 
            this.btnXpathileVerileriBul.Location = new System.Drawing.Point(12, 379);
            this.btnXpathileVerileriBul.Name = "btnXpathileVerileriBul";
            this.btnXpathileVerileriBul.Size = new System.Drawing.Size(158, 46);
            this.btnXpathileVerileriBul.TabIndex = 1;
            this.btnXpathileVerileriBul.Text = "XML de verileri XPath ile Bul";
            this.btnXpathileVerileriBul.UseVisualStyleBackColor = true;
            // 
            // btnSechemaOlustur
            // 
            this.btnSechemaOlustur.Location = new System.Drawing.Point(237, 379);
            this.btnSechemaOlustur.Name = "btnSechemaOlustur";
            this.btnSechemaOlustur.Size = new System.Drawing.Size(169, 46);
            this.btnSechemaOlustur.TabIndex = 1;
            this.btnSechemaOlustur.Text = "XML schema tasarımı olustur";
            this.btnSechemaOlustur.UseVisualStyleBackColor = true;
            // 
            // btnVeriDegistir
            // 
            this.btnVeriDegistir.Location = new System.Drawing.Point(12, 431);
            this.btnVeriDegistir.Name = "btnVeriDegistir";
            this.btnVeriDegistir.Size = new System.Drawing.Size(158, 46);
            this.btnVeriDegistir.TabIndex = 1;
            this.btnVeriDegistir.Text = "XML içindeki veriyi Degistir";
            this.btnVeriDegistir.UseVisualStyleBackColor = true;
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.Location = new System.Drawing.Point(12, 483);
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.Size = new System.Drawing.Size(158, 46);
            this.btnVeriSil.TabIndex = 1;
            this.btnVeriSil.Text = "XML den Veri Sil";
            this.btnVeriSil.UseVisualStyleBackColor = true;
            this.btnVeriSil.Click += new System.EventHandler(this.btnVeriSil_Click);
            // 
            // btnSQLtoSchema
            // 
            this.btnSQLtoSchema.Location = new System.Drawing.Point(237, 431);
            this.btnSQLtoSchema.Name = "btnSQLtoSchema";
            this.btnSQLtoSchema.Size = new System.Drawing.Size(169, 46);
            this.btnSQLtoSchema.TabIndex = 1;
            this.btnSQLtoSchema.Text = "SQL den istenen semaya uygun XML olustur";
            this.btnSQLtoSchema.UseVisualStyleBackColor = true;
            // 
            // btnXMLSchemaDogrula
            // 
            this.btnXMLSchemaDogrula.Location = new System.Drawing.Point(237, 483);
            this.btnXMLSchemaDogrula.Name = "btnXMLSchemaDogrula";
            this.btnXMLSchemaDogrula.Size = new System.Drawing.Size(169, 46);
            this.btnXMLSchemaDogrula.TabIndex = 1;
            this.btnXMLSchemaDogrula.Text = "XML schema Dogrulama";
            this.btnXMLSchemaDogrula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 535);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnXMLSchemaDogrula);
            this.Controls.Add(this.btnSQLtoSchema);
            this.Controls.Add(this.btnSechemaOlustur);
            this.Controls.Add(this.btnXMLtoSQL);
            this.Controls.Add(this.btnSQLtoXML);
            this.Controls.Add(this.btnVeriSil);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnVeriDegistir);
            this.Controls.Add(this.btnXpathileVerileriBul);
            this.Controls.Add(this.btnXPathIleTagBul);
            this.Controls.Add(this.btnVeriBul);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnVeriBul;
        private System.Windows.Forms.Button btnSQLtoXML;
        private System.Windows.Forms.Button btnXPathIleTagBul;
        private System.Windows.Forms.Button btnXMLtoSQL;
        private System.Windows.Forms.Button btnXpathileVerileriBul;
        private System.Windows.Forms.Button btnSechemaOlustur;
        private System.Windows.Forms.Button btnVeriDegistir;
        private System.Windows.Forms.Button btnVeriSil;
        private System.Windows.Forms.Button btnSQLtoSchema;
        private System.Windows.Forms.Button btnXMLSchemaDogrula;
    }
}

