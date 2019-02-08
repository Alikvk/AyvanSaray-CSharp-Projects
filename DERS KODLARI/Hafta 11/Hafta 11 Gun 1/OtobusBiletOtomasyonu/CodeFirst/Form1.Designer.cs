namespace CodeFirst
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
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.nudSeatCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBuses = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusName
            // 
            this.txtBusName.Location = new System.Drawing.Point(146, 108);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(100, 20);
            this.txtBusName.TabIndex = 0;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(268, 108);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNumber.TabIndex = 1;
            // 
            // nudSeatCounter
            // 
            this.nudSeatCounter.Location = new System.Drawing.Point(393, 108);
            this.nudSeatCounter.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSeatCounter.Name = "nudSeatCounter";
            this.nudSeatCounter.Size = new System.Drawing.Size(120, 20);
            this.nudSeatCounter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plaka Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Koltuk Sayısı";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(530, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lstBuses
            // 
            this.lstBuses.FormattingEnabled = true;
            this.lstBuses.Location = new System.Drawing.Point(149, 156);
            this.lstBuses.Name = "lstBuses";
            this.lstBuses.Size = new System.Drawing.Size(144, 277);
            this.lstBuses.TabIndex = 4;
            this.lstBuses.SelectedIndexChanged += new System.EventHandler(this.lstBuses_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(620, 105);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(715, 105);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lstBuses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSeatCounter);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtBusName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeatCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.NumericUpDown nudSeatCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBuses;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
    }
}

