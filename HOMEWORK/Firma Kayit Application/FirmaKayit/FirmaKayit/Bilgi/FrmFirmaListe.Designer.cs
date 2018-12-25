namespace FirmaKayit.Bilgi
{
    partial class FrmFirmaListe
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtFadi = new System.Windows.Forms.TextBox();
            this.FNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ftipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ftel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ftel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.txtFadi);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FNo,
            this.FAdi,
            this.Ftipi,
            this.Ftel1,
            this.Ftel2});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(649, 446);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBul.Location = new System.Drawing.Point(0, 382);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(139, 64);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(139, 64);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtFadi
            // 
            this.txtFadi.Location = new System.Drawing.Point(3, 168);
            this.txtFadi.Name = "txtFadi";
            this.txtFadi.Size = new System.Drawing.Size(133, 20);
            this.txtFadi.TabIndex = 0;
            // 
            // FNo
            // 
            this.FNo.HeaderText = "Firma No";
            this.FNo.Name = "FNo";
            // 
            // FAdi
            // 
            this.FAdi.HeaderText = "Firma Adı";
            this.FAdi.Name = "FAdi";
            this.FAdi.Width = 220;
            // 
            // Ftipi
            // 
            this.Ftipi.HeaderText = "Firma Tipi";
            this.Ftipi.Name = "Ftipi";
            // 
            // Ftel1
            // 
            this.Ftel1.HeaderText = "Telefon 1";
            this.Ftel1.Name = "Ftel1";
            // 
            // Ftel2
            // 
            this.Ftel2.HeaderText = "Telefon 2";
            this.Ftel2.Name = "Ftel2";
            // 
            // FrmFirmaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmFirmaListe";
            this.Text = "FrmFirmaListe";
            this.Load += new System.EventHandler(this.FrmFirmaListe_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox txtFadi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ftipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ftel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ftel2;
    }
}