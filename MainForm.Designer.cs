namespace Base64FileTools
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tpgEncode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labTransferFileName = new System.Windows.Forms.Label();
            this.txtTransferFileName = new System.Windows.Forms.Label();
            this.labTransferSavePath = new System.Windows.Forms.Label();
            this.txtTransferSavePath = new System.Windows.Forms.Label();
            this.txtTransferError = new System.Windows.Forms.Label();
            this.btnSelectTransferFile = new System.Windows.Forms.Button();
            this.btnSelectTransferSavePath = new System.Windows.Forms.Button();
            this.btnExecuteEncode = new System.Windows.Forms.Button();
            this.tpgDecode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labSourceFileName = new System.Windows.Forms.Label();
            this.txtSourceFileName = new System.Windows.Forms.Label();
            this.labSavePath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.Label();
            this.txtDecodeError = new System.Windows.Forms.Label();
            this.btnSelectSourceFIle = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btnExecuteDecode = new System.Windows.Forms.Button();
            this.dlgSelectTransferFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSelectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSelectSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.tbcMain.SuspendLayout();
            this.tpgEncode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpgDecode.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcMain.Controls.Add(this.tpgEncode);
            this.tbcMain.Controls.Add(this.tpgDecode);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.ItemSize = new System.Drawing.Size(100, 22);
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(564, 136);
            this.tbcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcMain.TabIndex = 0;
            // 
            // tpgEncode
            // 
            this.tpgEncode.Controls.Add(this.tableLayoutPanel1);
            this.tpgEncode.Location = new System.Drawing.Point(4, 26);
            this.tpgEncode.Name = "tpgEncode";
            this.tpgEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEncode.Size = new System.Drawing.Size(556, 106);
            this.tpgEncode.TabIndex = 0;
            this.tpgEncode.Text = "檔案轉碼";
            this.tpgEncode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.labTransferFileName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTransferFileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labTransferSavePath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTransferSavePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTransferError, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectTransferFile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectTransferSavePath, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExecuteEncode, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkCompress, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labTransferFileName
            // 
            this.labTransferFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labTransferFileName.AutoSize = true;
            this.labTransferFileName.Location = new System.Drawing.Point(3, 9);
            this.labTransferFileName.Name = "labTransferFileName";
            this.labTransferFileName.Size = new System.Drawing.Size(94, 12);
            this.labTransferFileName.TabIndex = 0;
            this.labTransferFileName.Text = "轉換檔案：";
            this.labTransferFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTransferFileName
            // 
            this.txtTransferFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransferFileName.AutoEllipsis = true;
            this.txtTransferFileName.AutoSize = true;
            this.txtTransferFileName.Location = new System.Drawing.Point(103, 9);
            this.txtTransferFileName.Name = "txtTransferFileName";
            this.txtTransferFileName.Size = new System.Drawing.Size(374, 12);
            this.txtTransferFileName.TabIndex = 1;
            this.txtTransferFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTransferSavePath
            // 
            this.labTransferSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labTransferSavePath.AutoSize = true;
            this.labTransferSavePath.Location = new System.Drawing.Point(3, 39);
            this.labTransferSavePath.Name = "labTransferSavePath";
            this.labTransferSavePath.Size = new System.Drawing.Size(94, 12);
            this.labTransferSavePath.TabIndex = 2;
            this.labTransferSavePath.Text = "儲存路徑：";
            this.labTransferSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTransferSavePath
            // 
            this.txtTransferSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransferSavePath.AutoEllipsis = true;
            this.txtTransferSavePath.AutoSize = true;
            this.txtTransferSavePath.Location = new System.Drawing.Point(103, 39);
            this.txtTransferSavePath.Name = "txtTransferSavePath";
            this.txtTransferSavePath.Size = new System.Drawing.Size(374, 12);
            this.txtTransferSavePath.TabIndex = 3;
            this.txtTransferSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTransferError
            // 
            this.txtTransferError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransferError.AutoSize = true;
            this.txtTransferError.Location = new System.Drawing.Point(103, 74);
            this.txtTransferError.Name = "txtTransferError";
            this.txtTransferError.Size = new System.Drawing.Size(374, 12);
            this.txtTransferError.TabIndex = 4;
            this.txtTransferError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectTransferFile
            // 
            this.btnSelectTransferFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectTransferFile.Location = new System.Drawing.Point(483, 3);
            this.btnSelectTransferFile.Name = "btnSelectTransferFile";
            this.btnSelectTransferFile.Size = new System.Drawing.Size(64, 23);
            this.btnSelectTransferFile.TabIndex = 5;
            this.btnSelectTransferFile.Text = "選取檔案";
            this.btnSelectTransferFile.UseVisualStyleBackColor = true;
            this.btnSelectTransferFile.Click += new System.EventHandler(this.btnSelectTransferFile_Click);
            // 
            // btnSelectTransferSavePath
            // 
            this.btnSelectTransferSavePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectTransferSavePath.Location = new System.Drawing.Point(483, 33);
            this.btnSelectTransferSavePath.Name = "btnSelectTransferSavePath";
            this.btnSelectTransferSavePath.Size = new System.Drawing.Size(64, 23);
            this.btnSelectTransferSavePath.TabIndex = 6;
            this.btnSelectTransferSavePath.Text = "選取路徑";
            this.btnSelectTransferSavePath.UseVisualStyleBackColor = true;
            this.btnSelectTransferSavePath.Click += new System.EventHandler(this.btnSelectTransferSavePath_Click);
            // 
            // btnExecuteEncode
            // 
            this.btnExecuteEncode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExecuteEncode.Location = new System.Drawing.Point(483, 68);
            this.btnExecuteEncode.Name = "btnExecuteEncode";
            this.btnExecuteEncode.Size = new System.Drawing.Size(64, 23);
            this.btnExecuteEncode.TabIndex = 7;
            this.btnExecuteEncode.Text = "執行轉碼";
            this.btnExecuteEncode.UseVisualStyleBackColor = true;
            this.btnExecuteEncode.Click += new System.EventHandler(this.btnExecuteEncode_Click);
            // 
            // tpgDecode
            // 
            this.tpgDecode.Controls.Add(this.tableLayoutPanel2);
            this.tpgDecode.Location = new System.Drawing.Point(4, 26);
            this.tpgDecode.Name = "tpgDecode";
            this.tpgDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDecode.Size = new System.Drawing.Size(556, 106);
            this.tpgDecode.TabIndex = 1;
            this.tpgDecode.Text = "檔案回復";
            this.tpgDecode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Controls.Add(this.labSourceFileName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSourceFileName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labSavePath, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSavePath, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDecodeError, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectSourceFIle, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSavePath, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnExecuteDecode, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labSourceFileName
            // 
            this.labSourceFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labSourceFileName.AutoSize = true;
            this.labSourceFileName.Location = new System.Drawing.Point(3, 9);
            this.labSourceFileName.Name = "labSourceFileName";
            this.labSourceFileName.Size = new System.Drawing.Size(94, 12);
            this.labSourceFileName.TabIndex = 0;
            this.labSourceFileName.Text = "原始檔案：";
            this.labSourceFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSourceFileName
            // 
            this.txtSourceFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFileName.AutoEllipsis = true;
            this.txtSourceFileName.AutoSize = true;
            this.txtSourceFileName.Location = new System.Drawing.Point(103, 9);
            this.txtSourceFileName.Name = "txtSourceFileName";
            this.txtSourceFileName.Size = new System.Drawing.Size(374, 12);
            this.txtSourceFileName.TabIndex = 1;
            this.txtSourceFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSavePath
            // 
            this.labSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labSavePath.AutoSize = true;
            this.labSavePath.Location = new System.Drawing.Point(3, 39);
            this.labSavePath.Name = "labSavePath";
            this.labSavePath.Size = new System.Drawing.Size(94, 12);
            this.labSavePath.TabIndex = 2;
            this.labSavePath.Text = "保存路徑：";
            this.labSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.AutoEllipsis = true;
            this.txtSavePath.AutoSize = true;
            this.txtSavePath.Location = new System.Drawing.Point(103, 39);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(374, 12);
            this.txtSavePath.TabIndex = 3;
            this.txtSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDecodeError
            // 
            this.txtDecodeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecodeError.AutoSize = true;
            this.txtDecodeError.Location = new System.Drawing.Point(103, 74);
            this.txtDecodeError.Name = "txtDecodeError";
            this.txtDecodeError.Size = new System.Drawing.Size(374, 12);
            this.txtDecodeError.TabIndex = 4;
            this.txtDecodeError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectSourceFIle
            // 
            this.btnSelectSourceFIle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectSourceFIle.Location = new System.Drawing.Point(483, 3);
            this.btnSelectSourceFIle.Name = "btnSelectSourceFIle";
            this.btnSelectSourceFIle.Size = new System.Drawing.Size(64, 23);
            this.btnSelectSourceFIle.TabIndex = 5;
            this.btnSelectSourceFIle.Text = "選取檔案";
            this.btnSelectSourceFIle.UseVisualStyleBackColor = true;
            this.btnSelectSourceFIle.Click += new System.EventHandler(this.btnSelectSourceFIle_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSavePath.Location = new System.Drawing.Point(483, 33);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(64, 23);
            this.btnSavePath.TabIndex = 6;
            this.btnSavePath.Text = "選取路徑";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnExecuteDecode
            // 
            this.btnExecuteDecode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExecuteDecode.Location = new System.Drawing.Point(483, 68);
            this.btnExecuteDecode.Name = "btnExecuteDecode";
            this.btnExecuteDecode.Size = new System.Drawing.Size(64, 23);
            this.btnExecuteDecode.TabIndex = 7;
            this.btnExecuteDecode.Text = "執行回復";
            this.btnExecuteDecode.UseVisualStyleBackColor = true;
            this.btnExecuteDecode.Click += new System.EventHandler(this.btnExecuteDecode_Click);
            // 
            // dlgSelectTransferFile
            // 
            this.dlgSelectTransferFile.Filter = "所有檔案|*.*";
            this.dlgSelectTransferFile.RestoreDirectory = true;
            this.dlgSelectTransferFile.Title = "請選取要進行轉碼的檔案";
            // 
            // dlgSelectPath
            // 
            this.dlgSelectPath.Description = "請選取要存放的路徑";
            // 
            // dlgSelectSourceFile
            // 
            this.dlgSelectSourceFile.DefaultExt = "txt";
            this.dlgSelectSourceFile.Filter = "TXT 檔案|*.txt";
            this.dlgSelectSourceFile.SupportMultiDottedExtensions = true;
            this.dlgSelectSourceFile.Title = "請選取要回復的檔案";
            // 
            // chkCompress
            // 
            this.chkCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCompress.AutoSize = true;
            this.chkCompress.Location = new System.Drawing.Point(3, 72);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Size = new System.Drawing.Size(94, 16);
            this.chkCompress.TabIndex = 8;
            this.chkCompress.Text = "產生壓縮檔";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 136);
            this.Controls.Add(this.tbcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Base64 File Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbcMain.ResumeLayout(false);
            this.tpgEncode.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpgDecode.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tpgEncode;
        private System.Windows.Forms.TabPage tpgDecode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labTransferFileName;
        private System.Windows.Forms.Label txtTransferFileName;
        private System.Windows.Forms.Label labTransferSavePath;
        private System.Windows.Forms.Label txtTransferSavePath;
        private System.Windows.Forms.Label txtTransferError;
        private System.Windows.Forms.Button btnSelectTransferFile;
        private System.Windows.Forms.Button btnSelectTransferSavePath;
        private System.Windows.Forms.Button btnExecuteEncode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labSourceFileName;
        private System.Windows.Forms.Label txtSourceFileName;
        private System.Windows.Forms.Label labSavePath;
        private System.Windows.Forms.Label txtSavePath;
        private System.Windows.Forms.Label txtDecodeError;
        private System.Windows.Forms.Button btnSelectSourceFIle;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Button btnExecuteDecode;
        private System.Windows.Forms.OpenFileDialog dlgSelectTransferFile;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectPath;
        private System.Windows.Forms.OpenFileDialog dlgSelectSourceFile;
        private System.Windows.Forms.CheckBox chkCompress;

    }
}

