namespace KosuYarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxHorse = new System.Windows.Forms.PictureBox();
            this.picBoxCita = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnYenidenBaslat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCita)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHorse
            // 
            this.picBoxHorse.BackColor = System.Drawing.Color.LimeGreen;
            this.picBoxHorse.Image = ((System.Drawing.Image)(resources.GetObject("picBoxHorse.Image")));
            this.picBoxHorse.Location = new System.Drawing.Point(3, 44);
            this.picBoxHorse.Name = "picBoxHorse";
            this.picBoxHorse.Size = new System.Drawing.Size(117, 110);
            this.picBoxHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHorse.TabIndex = 0;
            this.picBoxHorse.TabStop = false;
            // 
            // picBoxCita
            // 
            this.picBoxCita.BackColor = System.Drawing.Color.LimeGreen;
            this.picBoxCita.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCita.Image")));
            this.picBoxCita.Location = new System.Drawing.Point(3, 177);
            this.picBoxCita.Name = "picBoxCita";
            this.picBoxCita.Size = new System.Drawing.Size(117, 95);
            this.picBoxCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCita.TabIndex = 0;
            this.picBoxCita.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(3, 352);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(109, 41);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnYenidenBaslat
            // 
            this.btnYenidenBaslat.Location = new System.Drawing.Point(119, 352);
            this.btnYenidenBaslat.Name = "btnYenidenBaslat";
            this.btnYenidenBaslat.Size = new System.Drawing.Size(102, 41);
            this.btnYenidenBaslat.TabIndex = 2;
            this.btnYenidenBaslat.Text = "Yeniden Başlat";
            this.btnYenidenBaslat.UseVisualStyleBackColor = true;
            this.btnYenidenBaslat.Click += new System.EventHandler(this.btnYenidenBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.btnYenidenBaslat);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.picBoxCita);
            this.Controls.Add(this.picBoxHorse);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHorse;
        private System.Windows.Forms.PictureBox picBoxCita;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnYenidenBaslat;
    }
}

