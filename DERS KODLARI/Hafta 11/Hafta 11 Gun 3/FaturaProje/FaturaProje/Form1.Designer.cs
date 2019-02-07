namespace FaturaProje
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.faturaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.birimEkleToolStripMenuItem,
            this.ürünEkleToolStripMenuItem,
            this.ilEkleToolStripMenuItem,
            this.ilçeEkleToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // birimEkleToolStripMenuItem
            // 
            this.birimEkleToolStripMenuItem.Name = "birimEkleToolStripMenuItem";
            this.birimEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.birimEkleToolStripMenuItem.Text = "Birim Ekle";
            this.birimEkleToolStripMenuItem.Click += new System.EventHandler(this.birimEkleToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilEkleToolStripMenuItem
            // 
            this.ilEkleToolStripMenuItem.Name = "ilEkleToolStripMenuItem";
            this.ilEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilEkleToolStripMenuItem.Text = "İl Ekle";
            this.ilEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilçeEkleToolStripMenuItem
            // 
            this.ilçeEkleToolStripMenuItem.Name = "ilçeEkleToolStripMenuItem";
            this.ilçeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilçeEkleToolStripMenuItem.Text = "İlçe Ekle";
            this.ilçeEkleToolStripMenuItem.Click += new System.EventHandler(this.ilçeEkleToolStripMenuItem_Click);
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFaturaToolStripMenuItem});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // yeniFaturaToolStripMenuItem
            // 
            this.yeniFaturaToolStripMenuItem.Name = "yeniFaturaToolStripMenuItem";
            this.yeniFaturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniFaturaToolStripMenuItem.Text = "Yeni Fatura";
            this.yeniFaturaToolStripMenuItem.Click += new System.EventHandler(this.yeniFaturaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaToolStripMenuItem;
    }
}

