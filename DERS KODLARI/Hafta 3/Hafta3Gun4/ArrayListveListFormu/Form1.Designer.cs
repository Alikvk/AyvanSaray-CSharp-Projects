namespace ArrayListveListFormu
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
            this.btnArray = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel = new System.Windows.Forms.Panel();
            this.btnRenklendir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(42, 27);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(144, 27);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnArrayList.TabIndex = 1;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(241, 27);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(353, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Buton Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 186);
            this.listBox1.TabIndex = 4;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(273, 94);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(276, 186);
            this.flowLayoutPanel.TabIndex = 5;
            // 
            // btnRenklendir
            // 
            this.btnRenklendir.Location = new System.Drawing.Point(451, 27);
            this.btnRenklendir.Name = "btnRenklendir";
            this.btnRenklendir.Size = new System.Drawing.Size(75, 23);
            this.btnRenklendir.TabIndex = 6;
            this.btnRenklendir.Text = "Renklendir";
            this.btnRenklendir.UseVisualStyleBackColor = true;
            this.btnRenklendir.Visible = false;
            this.btnRenklendir.Click += new System.EventHandler(this.btnRenklendir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 324);
            this.Controls.Add(this.btnRenklendir);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel flowLayoutPanel;
        private System.Windows.Forms.Button btnRenklendir;
    }
}

