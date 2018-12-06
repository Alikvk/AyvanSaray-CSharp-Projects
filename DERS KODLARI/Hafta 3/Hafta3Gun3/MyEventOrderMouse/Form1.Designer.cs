namespace MyEventOrderMouse
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
            this.txtOlay = new System.Windows.Forms.TextBox();
            this.lstboxOlay = new System.Windows.Forms.ListBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOlay
            // 
            this.txtOlay.Location = new System.Drawing.Point(91, 22);
            this.txtOlay.Multiline = true;
            this.txtOlay.Name = "txtOlay";
            this.txtOlay.Size = new System.Drawing.Size(376, 136);
            this.txtOlay.TabIndex = 0;
            this.txtOlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOlay_KeyDown);
            this.txtOlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOlay_KeyPress);
            this.txtOlay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOlay_KeyUp);
            this.txtOlay.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtOlay_PreviewKeyDown);
            // 
            // lstboxOlay
            // 
            this.lstboxOlay.BackColor = System.Drawing.Color.YellowGreen;
            this.lstboxOlay.FormattingEnabled = true;
            this.lstboxOlay.Location = new System.Drawing.Point(91, 165);
            this.lstboxOlay.Name = "lstboxOlay";
            this.lstboxOlay.Size = new System.Drawing.Size(376, 160);
            this.lstboxOlay.TabIndex = 1;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(91, 355);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(153, 38);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 423);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.lstboxOlay);
            this.Controls.Add(this.txtOlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOlay;
        private System.Windows.Forms.ListBox lstboxOlay;
        private System.Windows.Forms.Button btn_temizle;
    }
}

