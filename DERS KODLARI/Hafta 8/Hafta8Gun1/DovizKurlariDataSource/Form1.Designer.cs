namespace DovizKurlariDataSource
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
            this.dataGridDoviz = new System.Windows.Forms.DataGridView();
            this.btnYukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoviz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDoviz
            // 
            this.dataGridDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoviz.Location = new System.Drawing.Point(46, 24);
            this.dataGridDoviz.Name = "dataGridDoviz";
            this.dataGridDoviz.Size = new System.Drawing.Size(692, 307);
            this.dataGridDoviz.TabIndex = 0;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(82, 363);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(108, 33);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.dataGridDoviz);
            this.Name = "Form1";
            this.Text = "Döviz Kurları Data Source";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoviz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDoviz;
        private System.Windows.Forms.Button btnYukle;
    }
}

