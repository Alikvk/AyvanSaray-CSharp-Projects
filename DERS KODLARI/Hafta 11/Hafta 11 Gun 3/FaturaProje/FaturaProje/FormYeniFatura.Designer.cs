namespace FaturaProje
{
    partial class FormYeniFatura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxCustomerCity = new System.Windows.Forms.ComboBox();
            this.comboxCustomerProvince = new System.Windows.Forms.ComboBox();
            this.comboxCustomer = new System.Windows.Forms.ComboBox();
            this.txtReightBill = new System.Windows.Forms.TextBox();
            this.dateTimePickPayDate = new System.Windows.Forms.DateTimePicker();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.comboxProductName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFaturaID = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.nudProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnInvoiceSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickPayDate);
            this.groupBox1.Controls.Add(this.txtReightBill);
            this.groupBox1.Controls.Add(this.comboxCustomer);
            this.groupBox1.Controls.Add(this.comboxCustomerProvince);
            this.groupBox1.Controls.Add(this.comboxCustomerCity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFaturaID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ve İrsaliye";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudProductQuantity);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtKDV);
            this.groupBox2.Controls.Add(this.txtUnit);
            this.groupBox2.Controls.Add(this.comboxProductName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(337, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Şehri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri İlçesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İrsaliye No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödeme Tarihi";
            // 
            // comboxCustomerCity
            // 
            this.comboxCustomerCity.FormattingEnabled = true;
            this.comboxCustomerCity.Location = new System.Drawing.Point(101, 48);
            this.comboxCustomerCity.Name = "comboxCustomerCity";
            this.comboxCustomerCity.Size = new System.Drawing.Size(154, 21);
            this.comboxCustomerCity.TabIndex = 1;
            // 
            // comboxCustomerProvince
            // 
            this.comboxCustomerProvince.FormattingEnabled = true;
            this.comboxCustomerProvince.Location = new System.Drawing.Point(101, 80);
            this.comboxCustomerProvince.Name = "comboxCustomerProvince";
            this.comboxCustomerProvince.Size = new System.Drawing.Size(154, 21);
            this.comboxCustomerProvince.TabIndex = 1;
            // 
            // comboxCustomer
            // 
            this.comboxCustomer.FormattingEnabled = true;
            this.comboxCustomer.Location = new System.Drawing.Point(101, 106);
            this.comboxCustomer.Name = "comboxCustomer";
            this.comboxCustomer.Size = new System.Drawing.Size(154, 21);
            this.comboxCustomer.TabIndex = 1;
            // 
            // txtReightBill
            // 
            this.txtReightBill.Location = new System.Drawing.Point(101, 133);
            this.txtReightBill.Name = "txtReightBill";
            this.txtReightBill.Size = new System.Drawing.Size(154, 20);
            this.txtReightBill.TabIndex = 2;
            // 
            // dateTimePickPayDate
            // 
            this.dateTimePickPayDate.Location = new System.Drawing.Point(101, 166);
            this.dateTimePickPayDate.Name = "dateTimePickPayDate";
            this.dateTimePickPayDate.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickPayDate.TabIndex = 3;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(110, 73);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(154, 20);
            this.txtUnit.TabIndex = 10;
            // 
            // comboxProductName
            // 
            this.comboxProductName.FormattingEnabled = true;
            this.comboxProductName.Location = new System.Drawing.Point(110, 19);
            this.comboxProductName.Name = "comboxProductName";
            this.comboxProductName.Size = new System.Drawing.Size(154, 21);
            this.comboxProductName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ürün Miktarı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ürün Birimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ürün Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ürün Adı";
            // 
            // lblFaturaID
            // 
            this.lblFaturaID.AutoSize = true;
            this.lblFaturaID.Location = new System.Drawing.Point(98, 29);
            this.lblFaturaID.Name = "lblFaturaID";
            this.lblFaturaID.Size = new System.Drawing.Size(0, 13);
            this.lblFaturaID.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(154, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ürün Kdv";
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(110, 99);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(154, 20);
            this.txtKDV.TabIndex = 10;
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Location = new System.Drawing.Point(110, 126);
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.Size = new System.Drawing.Size(154, 20);
            this.nudProductQuantity.TabIndex = 11;
            // 
            // BtnInvoiceSave
            // 
            this.BtnInvoiceSave.Location = new System.Drawing.Point(636, 42);
            this.BtnInvoiceSave.Name = "BtnInvoiceSave";
            this.BtnInvoiceSave.Size = new System.Drawing.Size(93, 50);
            this.BtnInvoiceSave.TabIndex = 1;
            this.BtnInvoiceSave.Text = "Fatura Kaydet";
            this.BtnInvoiceSave.UseVisualStyleBackColor = true;
            this.BtnInvoiceSave.Click += new System.EventHandler(this.BtnInvoiceSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(636, 125);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(93, 50);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Liste Temizle";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(15, 155);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 31);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Ürün Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(114, 155);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(94, 31);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Ürün Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(214, 155);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(73, 31);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Ürün Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 194);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormYeniFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnInvoiceSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormYeniFatura";
            this.Text = "FormYeniFatura";
            this.Load += new System.EventHandler(this.FormYeniFatura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickPayDate;
        private System.Windows.Forms.TextBox txtReightBill;
        private System.Windows.Forms.ComboBox comboxCustomer;
        private System.Windows.Forms.ComboBox comboxCustomerProvince;
        private System.Windows.Forms.ComboBox comboxCustomerCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFaturaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudProductQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.ComboBox comboxProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnInvoiceSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}