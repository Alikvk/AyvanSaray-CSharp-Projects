namespace uNotepad
{
    partial class About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblAbout2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uNotepad.Properties.Resources.papers;
            this.pictureBox1.Location = new System.Drawing.Point(41, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAbout.Location = new System.Drawing.Point(423, 53);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(161, 35);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "uNotePad";
            // 
            // lblAbout2
            // 
            this.lblAbout2.Location = new System.Drawing.Point(429, 103);
            this.lblAbout2.Name = "lblAbout2";
            this.lblAbout2.Size = new System.Drawing.Size(150, 120);
            this.lblAbout2.TabIndex = 2;
            this.lblAbout2.Text = "uNotePad sektöre 2016 yılı başlarında girmiş olan bir grup işkur öğrencisi tarafı" +
    "ndan geliştirilmiştir. Umarız faydası olur. :)";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(512, 304);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(191, 44);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 371);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAbout2);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.pictureBox1);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblAbout2;
        private System.Windows.Forms.Button btnOK;
    }
}