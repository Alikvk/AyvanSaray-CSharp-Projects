namespace uNotepad
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicimlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harfIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiBuyukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiKucukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.bicimlendirmeToolStripMenuItem,
            this.harfIslemleriToolStripMenuItem,
            this.araToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.acToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.toolButtonNew_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acToolStripMenuItem.Text = "Ac";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.toolButtonOpen_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.toolButtonSave_Click);
            // 
            // bicimlendirmeToolStripMenuItem
            // 
            this.bicimlendirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaziRengiToolStripMenuItem,
            this.yaziTipiToolStripMenuItem});
            this.bicimlendirmeToolStripMenuItem.Name = "bicimlendirmeToolStripMenuItem";
            this.bicimlendirmeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.bicimlendirmeToolStripMenuItem.Text = "Bicimlendirme";
            // 
            // yaziRengiToolStripMenuItem
            // 
            this.yaziRengiToolStripMenuItem.Name = "yaziRengiToolStripMenuItem";
            this.yaziRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yaziRengiToolStripMenuItem.Text = "Yazi Rengi";
            this.yaziRengiToolStripMenuItem.Click += new System.EventHandler(this.yaziRengiToolStripMenuItem_Click);
            // 
            // yaziTipiToolStripMenuItem
            // 
            this.yaziTipiToolStripMenuItem.Name = "yaziTipiToolStripMenuItem";
            this.yaziTipiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yaziTipiToolStripMenuItem.Text = "Yazi Tipi";
            this.yaziTipiToolStripMenuItem.Click += new System.EventHandler(this.yaziTipiToolStripMenuItem_Click);
            // 
            // harfIslemleriToolStripMenuItem
            // 
            this.harfIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hepsiBuyukToolStripMenuItem,
            this.hepsiKucukToolStripMenuItem});
            this.harfIslemleriToolStripMenuItem.Name = "harfIslemleriToolStripMenuItem";
            this.harfIslemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.harfIslemleriToolStripMenuItem.Text = "Harf Islemleri";
            // 
            // hepsiBuyukToolStripMenuItem
            // 
            this.hepsiBuyukToolStripMenuItem.Name = "hepsiBuyukToolStripMenuItem";
            this.hepsiBuyukToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hepsiBuyukToolStripMenuItem.Text = "Hepsi Buyuk";
            this.hepsiBuyukToolStripMenuItem.Click += new System.EventHandler(this.hepsiBuyukToolStripMenuItem_Click);
            // 
            // hepsiKucukToolStripMenuItem
            // 
            this.hepsiKucukToolStripMenuItem.Name = "hepsiKucukToolStripMenuItem";
            this.hepsiKucukToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hepsiKucukToolStripMenuItem.Text = "Hepsi Kucuk";
            this.hepsiKucukToolStripMenuItem.Click += new System.EventHandler(this.hepsiKucukToolStripMenuItem_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkindaToolStripMenuItem.Text = "Hakkinda";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonNew,
            this.toolButtonSave,
            this.toolButtonOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolButtonNew
            // 
            this.toolButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonNew.Image = global::uNotepad.Properties.Resources.new_file;
            this.toolButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonNew.Name = "toolButtonNew";
            this.toolButtonNew.Size = new System.Drawing.Size(24, 24);
            this.toolButtonNew.Text = "toolStripButton1";
            this.toolButtonNew.Click += new System.EventHandler(this.toolButtonNew_Click);
            // 
            // toolButtonSave
            // 
            this.toolButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonSave.Image = global::uNotepad.Properties.Resources.save_file;
            this.toolButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonSave.Name = "toolButtonSave";
            this.toolButtonSave.Size = new System.Drawing.Size(24, 24);
            this.toolButtonSave.Text = "toolStripButton2";
            this.toolButtonSave.Click += new System.EventHandler(this.toolButtonSave_Click);
            // 
            // toolButtonOpen
            // 
            this.toolButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonOpen.Image = global::uNotepad.Properties.Resources.open_file;
            this.toolButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonOpen.Name = "toolButtonOpen";
            this.toolButtonOpen.Size = new System.Drawing.Size(24, 24);
            this.toolButtonOpen.Text = "toolStripButton3";
            this.toolButtonOpen.Click += new System.EventHandler(this.toolButtonOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 410);
            this.tabControl1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(776, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "new 1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RTF File|*.rtf|Text File|*.txt";
            this.openFileDialog1.Title = "Dosyayi Secin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uNotepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicimlendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harfIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiBuyukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiKucukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolButtonNew;
        private System.Windows.Forms.ToolStripButton toolButtonSave;
        private System.Windows.Forms.ToolStripButton toolButtonOpen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}

