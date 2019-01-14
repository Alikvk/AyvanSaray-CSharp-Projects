namespace DovizKurlari
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
            this.lstBoxDoviz = new System.Windows.Forms.ListBox();
            this.dataGridDoviz = new System.Windows.Forms.DataGridView();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.DovizAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoviz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DovizAd,
            this.Satis});
            this.dataGridView1.Location = new System.Drawing.Point(373, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lstBoxDoviz
            // 
            this.lstBoxDoviz.FormattingEnabled = true;
            this.lstBoxDoviz.Location = new System.Drawing.Point(13, 22);
            this.lstBoxDoviz.Name = "lstBoxDoviz";
            this.lstBoxDoviz.Size = new System.Drawing.Size(166, 173);
            this.lstBoxDoviz.TabIndex = 1;
            this.lstBoxDoviz.SelectedIndexChanged += new System.EventHandler(this.lstBoxDoviz_SelectedIndexChanged);
            // 
            // dataGridDoviz
            // 
            this.dataGridDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoviz.Location = new System.Drawing.Point(373, 22);
            this.dataGridDoviz.Name = "dataGridDoviz";
            this.dataGridDoviz.Size = new System.Drawing.Size(377, 150);
            this.dataGridDoviz.TabIndex = 0;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(13, 216);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(93, 30);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birim";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(271, 22);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(13, 13);
            this.lblBirim.TabIndex = 3;
            this.lblBirim.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Döviz Alış";
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(271, 54);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(13, 13);
            this.lblAlis.TabIndex = 3;
            this.lblAlis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Döviz Satış";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(271, 91);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(13, 13);
            this.lblSatis.TabIndex = 3;
            this.lblSatis.Text = "0";
            // 
            // DovizAd
            // 
            this.DovizAd.HeaderText = "Doviz Ad";
            this.DovizAd.Name = "DovizAd";
            // 
            // Satis
            // 
            this.Satis.HeaderText = "Satis";
            this.Satis.Name = "Satis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.lstBoxDoviz);
            this.Controls.Add(this.dataGridDoviz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoviz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstBoxDoviz;
        private System.Windows.Forms.DataGridView dataGridDoviz;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovizAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satis;
    }
}

