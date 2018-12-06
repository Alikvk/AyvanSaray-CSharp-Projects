namespace MyEventOrderKey
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
            this.lstBoxOlay = new System.Windows.Forms.ListBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.pnlOlay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lstBoxOlay
            // 
            this.lstBoxOlay.FormattingEnabled = true;
            this.lstBoxOlay.Location = new System.Drawing.Point(128, 167);
            this.lstBoxOlay.Name = "lstBoxOlay";
            this.lstBoxOlay.Size = new System.Drawing.Size(329, 212);
            this.lstBoxOlay.TabIndex = 1;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(128, 397);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(104, 23);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            // 
            // pnlOlay
            // 
            this.pnlOlay.BackColor = System.Drawing.Color.Turquoise;
            this.pnlOlay.Location = new System.Drawing.Point(128, 22);
            this.pnlOlay.Name = "pnlOlay";
            this.pnlOlay.Size = new System.Drawing.Size(329, 139);
            this.pnlOlay.TabIndex = 3;
            this.pnlOlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlOlay_MouseDown);
            this.pnlOlay.MouseEnter += new System.EventHandler(this.pnlOlay_MouseEnter);
            this.pnlOlay.MouseLeave += new System.EventHandler(this.pnlOlay_MouseLeave);
            this.pnlOlay.MouseHover += new System.EventHandler(this.pnlOlay_MouseHover);
            this.pnlOlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOlay_MouseMove);
            this.pnlOlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlOlay_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.pnlOlay);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.lstBoxOlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstBoxOlay;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Panel pnlOlay;
    }
}

