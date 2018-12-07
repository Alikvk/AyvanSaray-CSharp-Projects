namespace BeniYakala
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
            this.btnBeniYakala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeniYakala
            // 
            this.btnBeniYakala.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBeniYakala.Location = new System.Drawing.Point(356, 135);
            this.btnBeniYakala.Name = "btnBeniYakala";
            this.btnBeniYakala.Size = new System.Drawing.Size(75, 23);
            this.btnBeniYakala.TabIndex = 0;
            this.btnBeniYakala.Text = "Beni Yakala";
            this.btnBeniYakala.UseVisualStyleBackColor = false;
            this.btnBeniYakala.Click += new System.EventHandler(this.btnBeniYakala_Click);
            this.btnBeniYakala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBeniYakala_KeyDown);
            this.btnBeniYakala.MouseEnter += new System.EventHandler(this.btnBeniYakala_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeniYakala);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beniYakala_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeniYakala;
    }
}

