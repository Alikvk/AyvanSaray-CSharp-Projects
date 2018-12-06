namespace DongulerForm
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
            this.lstFor = new System.Windows.Forms.ListBox();
            this.lstWhile = new System.Windows.Forms.ListBox();
            this.lstDoWhile = new System.Windows.Forms.ListBox();
            this.lstIENUM = new System.Windows.Forms.ListBox();
            this.lstForeach = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDowhile = new System.Windows.Forms.Button();
            this.btnIENUM = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFor
            // 
            this.lstFor.BackColor = System.Drawing.Color.Gainsboro;
            this.lstFor.FormattingEnabled = true;
            this.lstFor.Location = new System.Drawing.Point(30, 13);
            this.lstFor.Name = "lstFor";
            this.lstFor.Size = new System.Drawing.Size(132, 238);
            this.lstFor.TabIndex = 0;
            // 
            // lstWhile
            // 
            this.lstWhile.BackColor = System.Drawing.Color.Gainsboro;
            this.lstWhile.FormattingEnabled = true;
            this.lstWhile.Location = new System.Drawing.Point(168, 13);
            this.lstWhile.Name = "lstWhile";
            this.lstWhile.Size = new System.Drawing.Size(132, 238);
            this.lstWhile.TabIndex = 1;
            // 
            // lstDoWhile
            // 
            this.lstDoWhile.BackColor = System.Drawing.Color.Gainsboro;
            this.lstDoWhile.FormattingEnabled = true;
            this.lstDoWhile.Location = new System.Drawing.Point(306, 13);
            this.lstDoWhile.Name = "lstDoWhile";
            this.lstDoWhile.Size = new System.Drawing.Size(132, 238);
            this.lstDoWhile.TabIndex = 2;
            // 
            // lstIENUM
            // 
            this.lstIENUM.BackColor = System.Drawing.Color.Gainsboro;
            this.lstIENUM.FormattingEnabled = true;
            this.lstIENUM.Location = new System.Drawing.Point(444, 13);
            this.lstIENUM.Name = "lstIENUM";
            this.lstIENUM.Size = new System.Drawing.Size(132, 238);
            this.lstIENUM.TabIndex = 3;
            // 
            // lstForeach
            // 
            this.lstForeach.BackColor = System.Drawing.Color.Gainsboro;
            this.lstForeach.FormattingEnabled = true;
            this.lstForeach.Location = new System.Drawing.Point(587, 13);
            this.lstForeach.Name = "lstForeach";
            this.lstForeach.Size = new System.Drawing.Size(132, 238);
            this.lstForeach.TabIndex = 4;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.Orange;
            this.btnFor.Location = new System.Drawing.Point(30, 267);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(132, 66);
            this.btnFor.TabIndex = 5;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.Orange;
            this.btnWhile.Location = new System.Drawing.Point(168, 267);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(132, 66);
            this.btnWhile.TabIndex = 6;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDowhile
            // 
            this.btnDowhile.BackColor = System.Drawing.Color.Orange;
            this.btnDowhile.Location = new System.Drawing.Point(306, 267);
            this.btnDowhile.Name = "btnDowhile";
            this.btnDowhile.Size = new System.Drawing.Size(132, 66);
            this.btnDowhile.TabIndex = 7;
            this.btnDowhile.Text = "Do While";
            this.btnDowhile.UseVisualStyleBackColor = false;
            this.btnDowhile.Click += new System.EventHandler(this.btnDowhile_Click);
            // 
            // btnIENUM
            // 
            this.btnIENUM.BackColor = System.Drawing.Color.Orange;
            this.btnIENUM.Location = new System.Drawing.Point(444, 267);
            this.btnIENUM.Name = "btnIENUM";
            this.btnIENUM.Size = new System.Drawing.Size(132, 66);
            this.btnIENUM.TabIndex = 8;
            this.btnIENUM.Text = "IEnumerable";
            this.btnIENUM.UseVisualStyleBackColor = false;
            this.btnIENUM.Click += new System.EventHandler(this.btnIENUM_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.BackColor = System.Drawing.Color.Orange;
            this.btnForeach.Location = new System.Drawing.Point(587, 267);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(132, 66);
            this.btnForeach.TabIndex = 9;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = false;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnIENUM);
            this.Controls.Add(this.btnDowhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lstForeach);
            this.Controls.Add(this.lstIENUM);
            this.Controls.Add(this.lstDoWhile);
            this.Controls.Add(this.lstWhile);
            this.Controls.Add(this.lstFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFor;
        private System.Windows.Forms.ListBox lstWhile;
        private System.Windows.Forms.ListBox lstDoWhile;
        private System.Windows.Forms.ListBox lstIENUM;
        private System.Windows.Forms.ListBox lstForeach;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDowhile;
        private System.Windows.Forms.Button btnIENUM;
        private System.Windows.Forms.Button btnForeach;
    }
}

