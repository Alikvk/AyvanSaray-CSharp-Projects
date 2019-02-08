namespace CodeFirst
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
            this.BtnTicket = new System.Windows.Forms.Button();
            this.BtnControl = new System.Windows.Forms.Button();
            this.btnCarFollow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBus = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxArrival = new System.Windows.Forms.ComboBox();
            this.comboxDeparture = new System.Windows.Forms.ComboBox();
            this.comboxBusList = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTicket
            // 
            this.BtnTicket.Location = new System.Drawing.Point(319, 12);
            this.BtnTicket.Name = "BtnTicket";
            this.BtnTicket.Size = new System.Drawing.Size(132, 59);
            this.BtnTicket.TabIndex = 0;
            this.BtnTicket.Text = "Bilet Kes";
            this.BtnTicket.UseVisualStyleBackColor = true;
            this.BtnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            // 
            // BtnControl
            // 
            this.BtnControl.Location = new System.Drawing.Point(169, 12);
            this.BtnControl.Name = "BtnControl";
            this.BtnControl.Size = new System.Drawing.Size(132, 59);
            this.BtnControl.TabIndex = 0;
            this.BtnControl.Text = "Kontrol";
            this.BtnControl.UseVisualStyleBackColor = true;
            // 
            // btnCarFollow
            // 
            this.btnCarFollow.Location = new System.Drawing.Point(11, 12);
            this.btnCarFollow.Name = "btnCarFollow";
            this.btnCarFollow.Size = new System.Drawing.Size(132, 59);
            this.btnCarFollow.TabIndex = 0;
            this.btnCarFollow.Text = "Araç Takip";
            this.btnCarFollow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.panelBus);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboxArrival);
            this.groupBox1.Controls.Add(this.comboxDeparture);
            this.groupBox1.Controls.Add(this.comboxBusList);
            this.groupBox1.Location = new System.Drawing.Point(457, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet İçin Seçimleri Yapınız";
            // 
            // panelBus
            // 
            this.panelBus.Location = new System.Drawing.Point(6, 117);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(391, 267);
            this.panelBus.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(396, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalkış Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varış Yeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs";
            // 
            // comboxArrival
            // 
            this.comboxArrival.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxArrival.FormattingEnabled = true;
            this.comboxArrival.Location = new System.Drawing.Point(157, 90);
            this.comboxArrival.Name = "comboxArrival";
            this.comboxArrival.Size = new System.Drawing.Size(121, 21);
            this.comboxArrival.TabIndex = 0;
            // 
            // comboxDeparture
            // 
            this.comboxDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDeparture.FormattingEnabled = true;
            this.comboxDeparture.Location = new System.Drawing.Point(157, 31);
            this.comboxDeparture.Name = "comboxDeparture";
            this.comboxDeparture.Size = new System.Drawing.Size(121, 21);
            this.comboxDeparture.TabIndex = 0;
            // 
            // comboxBusList
            // 
            this.comboxBusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxBusList.FormattingEnabled = true;
            this.comboxBusList.Location = new System.Drawing.Point(19, 46);
            this.comboxBusList.Name = "comboxBusList";
            this.comboxBusList.Size = new System.Drawing.Size(121, 21);
            this.comboxBusList.TabIndex = 0;
            this.comboxBusList.SelectedIndexChanged += new System.EventHandler(this.comboxBusList_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(307, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCarFollow);
            this.Controls.Add(this.BtnControl);
            this.Controls.Add(this.BtnTicket);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTicket;
        private System.Windows.Forms.Button BtnControl;
        private System.Windows.Forms.Button btnCarFollow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxBusList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxArrival;
        private System.Windows.Forms.ComboBox comboxDeparture;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}