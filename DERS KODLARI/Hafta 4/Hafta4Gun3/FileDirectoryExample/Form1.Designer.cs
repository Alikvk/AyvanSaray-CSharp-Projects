namespace FileDirectoryExample
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
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btdDizinOlustur = new System.Windows.Forms.Button();
            this.btnDizinSil = new System.Windows.Forms.Button();
            this.btnDiskler = new System.Windows.Forms.Button();
            this.btnCFolder = new System.Windows.Forms.Button();
            this.btnCdekiler = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtBoxSource = new System.Windows.Forms.TextBox();
            this.txtBoxTarget = new System.Windows.Forms.TextBox();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(134, 23);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(172, 20);
            this.txtBoxPath.TabIndex = 0;
            // 
            // btdDizinOlustur
            // 
            this.btdDizinOlustur.Location = new System.Drawing.Point(134, 55);
            this.btdDizinOlustur.Name = "btdDizinOlustur";
            this.btdDizinOlustur.Size = new System.Drawing.Size(75, 23);
            this.btdDizinOlustur.TabIndex = 4;
            this.btdDizinOlustur.Text = "Dizin oluştur";
            this.btdDizinOlustur.UseVisualStyleBackColor = true;
            this.btdDizinOlustur.Click += new System.EventHandler(this.btdDizinOlustur_Click);
            // 
            // btnDizinSil
            // 
            this.btnDizinSil.Location = new System.Drawing.Point(231, 55);
            this.btnDizinSil.Name = "btnDizinSil";
            this.btnDizinSil.Size = new System.Drawing.Size(75, 23);
            this.btnDizinSil.TabIndex = 5;
            this.btnDizinSil.Text = "Dizin Sil";
            this.btnDizinSil.UseVisualStyleBackColor = true;
            this.btnDizinSil.Click += new System.EventHandler(this.btnDizinSil_Click);
            // 
            // btnDiskler
            // 
            this.btnDiskler.Location = new System.Drawing.Point(39, 265);
            this.btnDiskler.Name = "btnDiskler";
            this.btnDiskler.Size = new System.Drawing.Size(120, 23);
            this.btnDiskler.TabIndex = 6;
            this.btnDiskler.Text = "Diskler";
            this.btnDiskler.UseVisualStyleBackColor = true;
            this.btnDiskler.Click += new System.EventHandler(this.btnDiskler_Click);
            // 
            // btnCFolder
            // 
            this.btnCFolder.Location = new System.Drawing.Point(186, 265);
            this.btnCFolder.Name = "btnCFolder";
            this.btnCFolder.Size = new System.Drawing.Size(120, 23);
            this.btnCFolder.TabIndex = 7;
            this.btnCFolder.Text = "C";
            this.btnCFolder.UseVisualStyleBackColor = true;
            this.btnCFolder.Click += new System.EventHandler(this.btnCFolder_Click);
            // 
            // btnCdekiler
            // 
            this.btnCdekiler.Location = new System.Drawing.Point(340, 265);
            this.btnCdekiler.Name = "btnCdekiler";
            this.btnCdekiler.Size = new System.Drawing.Size(120, 23);
            this.btnCdekiler.TabIndex = 8;
            this.btnCdekiler.Text = "Cdeki";
            this.btnCdekiler.UseVisualStyleBackColor = true;
            this.btnCdekiler.Click += new System.EventHandler(this.btnCdekiler_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(340, 307);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(104, 23);
            this.btnCurrent.TabIndex = 9;
            this.btnCurrent.Text = "Nerdeyim";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(171, 415);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(100, 23);
            this.btnMove.TabIndex = 10;
            this.btnMove.Text = "Taşı";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Location = new System.Drawing.Point(171, 352);
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSource.TabIndex = 11;
            // 
            // txtBoxTarget
            // 
            this.txtBoxTarget.Location = new System.Drawing.Point(171, 387);
            this.txtBoxTarget.Name = "txtBoxTarget";
            this.txtBoxTarget.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTarget.TabIndex = 12;
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.Location = new System.Drawing.Point(62, 312);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(57, 13);
            this.lblCurrentPath.TabIndex = 13;
            this.lblCurrentPath.Text = "Neredeyim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dizin İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Taşınacak Dizin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yeni Dizin";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(186, 112);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 147);
            this.listBox2.TabIndex = 18;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(340, 112);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 147);
            this.listBox3.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.txtBoxTarget);
            this.Controls.Add(this.txtBoxSource);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnCdekiler);
            this.Controls.Add(this.btnCFolder);
            this.Controls.Add(this.btnDiskler);
            this.Controls.Add(this.btnDizinSil);
            this.Controls.Add(this.btdDizinOlustur);
            this.Controls.Add(this.txtBoxPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btdDizinOlustur;
        private System.Windows.Forms.Button btnDizinSil;
        private System.Windows.Forms.Button btnDiskler;
        private System.Windows.Forms.Button btnCFolder;
        private System.Windows.Forms.Button btnCdekiler;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtBoxSource;
        private System.Windows.Forms.TextBox txtBoxTarget;
        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

