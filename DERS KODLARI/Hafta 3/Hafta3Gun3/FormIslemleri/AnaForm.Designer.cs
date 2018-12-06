namespace FormIslemleri
{
    partial class AnaForm
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
            this.btn_Anaform_Renk_Degistir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Anaform_Renk_Degistir
            // 
            this.btn_Anaform_Renk_Degistir.Location = new System.Drawing.Point(282, 12);
            this.btn_Anaform_Renk_Degistir.Name = "btn_Anaform_Renk_Degistir";
            this.btn_Anaform_Renk_Degistir.Size = new System.Drawing.Size(111, 41);
            this.btn_Anaform_Renk_Degistir.TabIndex = 0;
            this.btn_Anaform_Renk_Degistir.Text = "Rengi Değiştir";
            this.btn_Anaform_Renk_Degistir.UseVisualStyleBackColor = true;
            this.btn_Anaform_Renk_Degistir.Click += new System.EventHandler(this.btn_Anaform_Renk_Degistir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 233);
            this.Controls.Add(this.btn_Anaform_Renk_Degistir);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Anaform_Renk_Degistir;
        private System.Windows.Forms.Timer timer1;
    }
}

