namespace DragAndDrop
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
            this.picBoxSource = new System.Windows.Forms.PictureBox();
            this.picBoxTarget = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSource
            // 
            this.picBoxSource.Location = new System.Drawing.Point(12, 51);
            this.picBoxSource.Name = "picBoxSource";
            this.picBoxSource.Size = new System.Drawing.Size(450, 278);
            this.picBoxSource.TabIndex = 0;
            this.picBoxSource.TabStop = false;
            this.picBoxSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicSource_MouseDown);
            // 
            // picBoxTarget
            // 
            this.picBoxTarget.Location = new System.Drawing.Point(489, 51);
            this.picBoxTarget.Name = "picBoxTarget";
            this.picBoxTarget.Size = new System.Drawing.Size(416, 278);
            this.picBoxTarget.TabIndex = 1;
            this.picBoxTarget.TabStop = false;
            this.picBoxTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.picTarget_DragDrop);
            this.picBoxTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.picTarget_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 335);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(114, 51);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 398);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.picBoxTarget);
            this.Controls.Add(this.picBoxSource);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxSource;
        private System.Windows.Forms.PictureBox picBoxTarget;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

