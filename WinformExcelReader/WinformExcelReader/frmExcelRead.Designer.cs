namespace WinformExcelReader
{
    partial class frmExcelRead
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.BtnBrowseFile = new System.Windows.Forms.Button();
            this.BtnReadExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.chkFirstRowHeader = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowse.Location = new System.Drawing.Point(12, 9);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(158, 19);
            this.lblBrowse.TabIndex = 8;
            this.lblBrowse.Text = "Browse XLS or XSLX file";
            // 
            // BtnBrowseFile
            // 
            this.BtnBrowseFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseFile.Location = new System.Drawing.Point(710, 25);
            this.BtnBrowseFile.Name = "BtnBrowseFile";
            this.BtnBrowseFile.Size = new System.Drawing.Size(95, 25);
            this.BtnBrowseFile.TabIndex = 7;
            this.BtnBrowseFile.Text = "Dosya Seç";
            this.BtnBrowseFile.UseVisualStyleBackColor = true;
            this.BtnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // BtnReadExcel
            // 
            this.BtnReadExcel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReadExcel.Location = new System.Drawing.Point(571, 54);
            this.BtnReadExcel.Name = "BtnReadExcel";
            this.BtnReadExcel.Size = new System.Drawing.Size(137, 25);
            this.BtnReadExcel.TabIndex = 6;
            this.BtnReadExcel.Text = "Dosyadan Oku";
            this.BtnReadExcel.UseVisualStyleBackColor = true;
            this.BtnReadExcel.Click += new System.EventHandler(this.BtnReadExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 170);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(16, 28);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(692, 20);
            this.txtFilePath.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 60);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 10;
            // 
            // chkFirstRowHeader
            // 
            this.chkFirstRowHeader.AutoSize = true;
            this.chkFirstRowHeader.Location = new System.Drawing.Point(414, 59);
            this.chkFirstRowHeader.Name = "chkFirstRowHeader";
            this.chkFirstRowHeader.Size = new System.Drawing.Size(151, 17);
            this.chkFirstRowHeader.TabIndex = 11;
            this.chkFirstRowHeader.Text = "İlk Satır Başlıktan Oluşuyor";
            this.chkFirstRowHeader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 264);
            this.Controls.Add(this.chkFirstRowHeader);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.BtnBrowseFile);
            this.Controls.Add(this.BtnReadExcel);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblBrowse;
        private System.Windows.Forms.Button BtnBrowseFile;
        private System.Windows.Forms.Button BtnReadExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chkFirstRowHeader;
    }
}

