namespace uNotepad
{
    partial class AramaFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Kelime :";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(113, 16);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(149, 20);
            this.txtAranan.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(136, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(60, 25);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Location = new System.Drawing.Point(202, 56);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(60, 25);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // AramaFormu
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(279, 95);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AramaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AramaFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnIptal;
    }
}