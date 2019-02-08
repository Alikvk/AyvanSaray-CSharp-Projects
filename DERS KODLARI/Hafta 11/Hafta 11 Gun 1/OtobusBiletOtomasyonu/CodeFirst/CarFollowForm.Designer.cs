namespace CodeFirst
{
    partial class CarFollowForm
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
            this.comboxBusList = new System.Windows.Forms.ComboBox();
            this.txtPassengerCount = new System.Windows.Forms.TextBox();
            this.txtTrip = new System.Windows.Forms.TextBox();
            this.BtnBusMove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBusStatus = new System.Windows.Forms.Button();
            this.lstDailyRecord = new System.Windows.Forms.ListBox();
            this.BtnDailyArchive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxBusList
            // 
            this.comboxBusList.FormattingEnabled = true;
            this.comboxBusList.Location = new System.Drawing.Point(81, 34);
            this.comboxBusList.Name = "comboxBusList";
            this.comboxBusList.Size = new System.Drawing.Size(121, 21);
            this.comboxBusList.TabIndex = 0;
            // 
            // txtPassengerCount
            // 
            this.txtPassengerCount.Location = new System.Drawing.Point(81, 93);
            this.txtPassengerCount.Name = "txtPassengerCount";
            this.txtPassengerCount.Size = new System.Drawing.Size(121, 20);
            this.txtPassengerCount.TabIndex = 1;
            // 
            // txtTrip
            // 
            this.txtTrip.Location = new System.Drawing.Point(268, 35);
            this.txtTrip.Name = "txtTrip";
            this.txtTrip.Size = new System.Drawing.Size(100, 20);
            this.txtTrip.TabIndex = 1;
            // 
            // BtnBusMove
            // 
            this.BtnBusMove.Location = new System.Drawing.Point(268, 79);
            this.BtnBusMove.Name = "BtnBusMove";
            this.BtnBusMove.Size = new System.Drawing.Size(100, 43);
            this.BtnBusMove.TabIndex = 2;
            this.BtnBusMove.Text = "Araç Hareketlendir";
            this.BtnBusMove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // BtnBusStatus
            // 
            this.BtnBusStatus.Location = new System.Drawing.Point(447, 14);
            this.BtnBusStatus.Name = "BtnBusStatus";
            this.BtnBusStatus.Size = new System.Drawing.Size(131, 50);
            this.BtnBusStatus.TabIndex = 2;
            this.BtnBusStatus.Text = "Araç  Durum Kaydet";
            this.BtnBusStatus.UseVisualStyleBackColor = true;
            // 
            // lstDailyRecord
            // 
            this.lstDailyRecord.FormattingEnabled = true;
            this.lstDailyRecord.Location = new System.Drawing.Point(596, 12);
            this.lstDailyRecord.Name = "lstDailyRecord";
            this.lstDailyRecord.Size = new System.Drawing.Size(209, 290);
            this.lstDailyRecord.TabIndex = 4;
            // 
            // BtnDailyArchive
            // 
            this.BtnDailyArchive.Location = new System.Drawing.Point(447, 91);
            this.BtnDailyArchive.Name = "BtnDailyArchive";
            this.BtnDailyArchive.Size = new System.Drawing.Size(131, 52);
            this.BtnDailyArchive.TabIndex = 2;
            this.BtnDailyArchive.Text = "Günlük Arşiv";
            this.BtnDailyArchive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Otobüs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yolcu Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sefer";
            // 
            // CarFollowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDailyRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDailyArchive);
            this.Controls.Add(this.BtnBusStatus);
            this.Controls.Add(this.BtnBusMove);
            this.Controls.Add(this.txtTrip);
            this.Controls.Add(this.txtPassengerCount);
            this.Controls.Add(this.comboxBusList);
            this.Name = "CarFollowForm";
            this.Text = "CarFollowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxBusList;
        private System.Windows.Forms.TextBox txtPassengerCount;
        private System.Windows.Forms.TextBox txtTrip;
        private System.Windows.Forms.Button BtnBusMove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBusStatus;
        private System.Windows.Forms.ListBox lstDailyRecord;
        private System.Windows.Forms.Button BtnDailyArchive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}