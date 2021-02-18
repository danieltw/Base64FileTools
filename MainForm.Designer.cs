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
            this.tlpEncode = new System.Windows.Forms.TableLayoutPanel();
            this.labEncodeFileName = new System.Windows.Forms.Label();
            this.txtEncodeFileName = new System.Windows.Forms.Label();
            this.labEncodeOutputPath = new System.Windows.Forms.Label();
            this.txtEncodeOutputPath = new System.Windows.Forms.Label();
            this.txtEncodeMessage = new System.Windows.Forms.Label();
            this.btnSelectEncodeFile = new System.Windows.Forms.Button();
            this.btnSelectEncodeOutputPath = new System.Windows.Forms.Button();
            this.btnExecuteEncode = new System.Windows.Forms.Button();
            this.chkOutputArchivedFile = new System.Windows.Forms.CheckBox();
            this.tpgDecode = new System.Windows.Forms.TabPage();
            this.tlpDecode = new System.Windows.Forms.TableLayoutPanel();
            this.labDecodeFileName = new System.Windows.Forms.Label();
            this.txtDecodeFileName = new System.Windows.Forms.Label();
            this.labDecodeOutputPath = new System.Windows.Forms.Label();
            this.txtDecodeOutputPath = new System.Windows.Forms.Label();
            this.txtDecodeMessage = new System.Windows.Forms.Label();
            this.btnSelectDecodeFile = new System.Windows.Forms.Button();
            this.btnSelectDecodeOutputPath = new System.Windows.Forms.Button();
            this.btnExecuteDecode = new System.Windows.Forms.Button();
            this.dlgSelectEncodeFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSelectOutputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSelectDecodeFile = new System.Windows.Forms.OpenFileDialog();
            this.chkOutputSplit = new System.Windows.Forms.CheckBox();
            this.txtSplitSize = new System.Windows.Forms.TextBox();
            this.labSplitText = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tpgEncode.SuspendLayout();
            this.tlpEncode.SuspendLayout();
            this.tpgDecode.SuspendLayout();
            this.tlpDecode.SuspendLayout();
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
            this.tbcMain.Size = new System.Drawing.Size(564, 128);
            this.tbcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcMain.TabIndex = 0;
            // 
            // tpgEncode
            // 
            this.tpgEncode.AllowDrop = true;
            this.tpgEncode.Controls.Add(this.tlpEncode);
            this.tpgEncode.Location = new System.Drawing.Point(4, 26);
            this.tpgEncode.Name = "tpgEncode";
            this.tpgEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEncode.Size = new System.Drawing.Size(556, 98);
            this.tpgEncode.TabIndex = 0;
            this.tpgEncode.Text = "File Encode";
            this.tpgEncode.UseVisualStyleBackColor = true;
            this.tpgEncode.DragDrop += new System.Windows.Forms.DragEventHandler(this.tpgEncode_DragDrop);
            this.tpgEncode.DragOver += new System.Windows.Forms.DragEventHandler(this.tpgEncode_DragOver);
            // 
            // tlpEncode
            // 
            this.tlpEncode.ColumnCount = 6;
            this.tlpEncode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpEncode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpEncode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpEncode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpEncode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpEncode.Controls.Add(this.labEncodeFileName, 0, 0);
            this.tlpEncode.Controls.Add(this.labEncodeOutputPath, 0, 1);
            this.tlpEncode.Controls.Add(this.txtEncodeMessage, 4, 2);
            this.tlpEncode.Controls.Add(this.btnSelectEncodeFile, 5, 0);
            this.tlpEncode.Controls.Add(this.btnSelectEncodeOutputPath, 5, 1);
            this.tlpEncode.Controls.Add(this.btnExecuteEncode, 5, 2);
            this.tlpEncode.Controls.Add(this.chkOutputArchivedFile, 0, 2);
            this.tlpEncode.Controls.Add(this.txtEncodeOutputPath, 1, 1);
            this.tlpEncode.Controls.Add(this.txtEncodeFileName, 1, 0);
            this.tlpEncode.Controls.Add(this.chkOutputSplit, 1, 2);
            this.tlpEncode.Controls.Add(this.txtSplitSize, 2, 2);
            this.tlpEncode.Controls.Add(this.labSplitText, 3, 2);
            this.tlpEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncode.Location = new System.Drawing.Point(3, 3);
            this.tlpEncode.Name = "tlpEncode";
            this.tlpEncode.RowCount = 4;
            this.tlpEncode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEncode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEncode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEncode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEncode.Size = new System.Drawing.Size(550, 92);
            this.tlpEncode.TabIndex = 0;
            // 
            // labEncodeFileName
            // 
            this.labEncodeFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labEncodeFileName.AutoSize = true;
            this.labEncodeFileName.Location = new System.Drawing.Point(3, 9);
            this.labEncodeFileName.Name = "labEncodeFileName";
            this.labEncodeFileName.Size = new System.Drawing.Size(104, 12);
            this.labEncodeFileName.TabIndex = 0;
            this.labEncodeFileName.Text = "Encode File :";
            this.labEncodeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEncodeFileName
            // 
            this.txtEncodeFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncodeFileName.AutoEllipsis = true;
            this.txtEncodeFileName.AutoSize = true;
            this.tlpEncode.SetColumnSpan(this.txtEncodeFileName, 4);
            this.txtEncodeFileName.Location = new System.Drawing.Point(113, 9);
            this.txtEncodeFileName.Name = "txtEncodeFileName";
            this.txtEncodeFileName.Size = new System.Drawing.Size(354, 12);
            this.txtEncodeFileName.TabIndex = 1;
            this.txtEncodeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labEncodeOutputPath
            // 
            this.labEncodeOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labEncodeOutputPath.AutoSize = true;
            this.labEncodeOutputPath.Location = new System.Drawing.Point(3, 39);
            this.labEncodeOutputPath.Name = "labEncodeOutputPath";
            this.labEncodeOutputPath.Size = new System.Drawing.Size(104, 12);
            this.labEncodeOutputPath.TabIndex = 2;
            this.labEncodeOutputPath.Text = "Output Path :";
            this.labEncodeOutputPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEncodeOutputPath
            // 
            this.txtEncodeOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncodeOutputPath.AutoEllipsis = true;
            this.txtEncodeOutputPath.AutoSize = true;
            this.tlpEncode.SetColumnSpan(this.txtEncodeOutputPath, 4);
            this.txtEncodeOutputPath.Location = new System.Drawing.Point(113, 39);
            this.txtEncodeOutputPath.Name = "txtEncodeOutputPath";
            this.txtEncodeOutputPath.Size = new System.Drawing.Size(354, 12);
            this.txtEncodeOutputPath.TabIndex = 3;
            this.txtEncodeOutputPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEncodeMessage
            // 
            this.txtEncodeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncodeMessage.AutoSize = true;
            this.txtEncodeMessage.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEncodeMessage.Location = new System.Drawing.Point(288, 69);
            this.txtEncodeMessage.Name = "txtEncodeMessage";
            this.txtEncodeMessage.Size = new System.Drawing.Size(179, 12);
            this.txtEncodeMessage.TabIndex = 4;
            this.txtEncodeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSelectEncodeFile
            // 
            this.btnSelectEncodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectEncodeFile.Location = new System.Drawing.Point(473, 3);
            this.btnSelectEncodeFile.Name = "btnSelectEncodeFile";
            this.btnSelectEncodeFile.Size = new System.Drawing.Size(74, 23);
            this.btnSelectEncodeFile.TabIndex = 5;
            this.btnSelectEncodeFile.Text = "Select File";
            this.btnSelectEncodeFile.UseVisualStyleBackColor = true;
            this.btnSelectEncodeFile.Click += new System.EventHandler(this.btnSelectEncodeFile_Click);
            // 
            // btnSelectEncodeOutputPath
            // 
            this.btnSelectEncodeOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectEncodeOutputPath.Location = new System.Drawing.Point(473, 33);
            this.btnSelectEncodeOutputPath.Name = "btnSelectEncodeOutputPath";
            this.btnSelectEncodeOutputPath.Size = new System.Drawing.Size(74, 23);
            this.btnSelectEncodeOutputPath.TabIndex = 6;
            this.btnSelectEncodeOutputPath.Text = "Select Path";
            this.btnSelectEncodeOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectEncodeOutputPath.Click += new System.EventHandler(this.btnSelectEncodeOutputPath_Click);
            // 
            // btnExecuteEncode
            // 
            this.btnExecuteEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteEncode.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExecuteEncode.Location = new System.Drawing.Point(473, 63);
            this.btnExecuteEncode.Name = "btnExecuteEncode";
            this.btnExecuteEncode.Size = new System.Drawing.Size(74, 23);
            this.btnExecuteEncode.TabIndex = 7;
            this.btnExecuteEncode.Text = "ENCODE";
            this.btnExecuteEncode.UseVisualStyleBackColor = true;
            this.btnExecuteEncode.Click += new System.EventHandler(this.btnExecuteEncode_Click);
            // 
            // chkOutputArchivedFile
            // 
            this.chkOutputArchivedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOutputArchivedFile.AutoSize = true;
            this.chkOutputArchivedFile.Location = new System.Drawing.Point(3, 67);
            this.chkOutputArchivedFile.Name = "chkOutputArchivedFile";
            this.chkOutputArchivedFile.Size = new System.Drawing.Size(104, 16);
            this.chkOutputArchivedFile.TabIndex = 8;
            this.chkOutputArchivedFile.Text = "Output Archived";
            this.chkOutputArchivedFile.UseVisualStyleBackColor = true;
            // 
            // tpgDecode
            // 
            this.tpgDecode.AllowDrop = true;
            this.tpgDecode.Controls.Add(this.tlpDecode);
            this.tpgDecode.Location = new System.Drawing.Point(4, 26);
            this.tpgDecode.Name = "tpgDecode";
            this.tpgDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDecode.Size = new System.Drawing.Size(556, 98);
            this.tpgDecode.TabIndex = 1;
            this.tpgDecode.Text = "File Decode";
            this.tpgDecode.UseVisualStyleBackColor = true;
            this.tpgDecode.DragDrop += new System.Windows.Forms.DragEventHandler(this.tpgDecode_DragDrop);
            this.tpgDecode.DragOver += new System.Windows.Forms.DragEventHandler(this.tpgDecode_DragOver);
            // 
            // tlpDecode
            // 
            this.tlpDecode.ColumnCount = 3;
            this.tlpDecode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpDecode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDecode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpDecode.Controls.Add(this.labDecodeFileName, 0, 0);
            this.tlpDecode.Controls.Add(this.txtDecodeFileName, 1, 0);
            this.tlpDecode.Controls.Add(this.labDecodeOutputPath, 0, 1);
            this.tlpDecode.Controls.Add(this.txtDecodeOutputPath, 1, 1);
            this.tlpDecode.Controls.Add(this.txtDecodeMessage, 1, 2);
            this.tlpDecode.Controls.Add(this.btnSelectDecodeFile, 2, 0);
            this.tlpDecode.Controls.Add(this.btnSelectDecodeOutputPath, 2, 1);
            this.tlpDecode.Controls.Add(this.btnExecuteDecode, 2, 2);
            this.tlpDecode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDecode.Location = new System.Drawing.Point(3, 3);
            this.tlpDecode.Name = "tlpDecode";
            this.tlpDecode.RowCount = 4;
            this.tlpDecode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDecode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDecode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDecode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDecode.Size = new System.Drawing.Size(550, 92);
            this.tlpDecode.TabIndex = 1;
            // 
            // labDecodeFileName
            // 
            this.labDecodeFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labDecodeFileName.AutoSize = true;
            this.labDecodeFileName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labDecodeFileName.Location = new System.Drawing.Point(3, 9);
            this.labDecodeFileName.Name = "labDecodeFileName";
            this.labDecodeFileName.Size = new System.Drawing.Size(104, 12);
            this.labDecodeFileName.TabIndex = 0;
            this.labDecodeFileName.Text = "Decode File :";
            this.labDecodeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDecodeFileName
            // 
            this.txtDecodeFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecodeFileName.AutoEllipsis = true;
            this.txtDecodeFileName.AutoSize = true;
            this.txtDecodeFileName.Location = new System.Drawing.Point(113, 9);
            this.txtDecodeFileName.Name = "txtDecodeFileName";
            this.txtDecodeFileName.Size = new System.Drawing.Size(354, 12);
            this.txtDecodeFileName.TabIndex = 1;
            this.txtDecodeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDecodeOutputPath
            // 
            this.labDecodeOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labDecodeOutputPath.AutoSize = true;
            this.labDecodeOutputPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labDecodeOutputPath.Location = new System.Drawing.Point(3, 39);
            this.labDecodeOutputPath.Name = "labDecodeOutputPath";
            this.labDecodeOutputPath.Size = new System.Drawing.Size(104, 12);
            this.labDecodeOutputPath.TabIndex = 2;
            this.labDecodeOutputPath.Text = "Output Path :";
            this.labDecodeOutputPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDecodeOutputPath
            // 
            this.txtDecodeOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecodeOutputPath.AutoEllipsis = true;
            this.txtDecodeOutputPath.AutoSize = true;
            this.txtDecodeOutputPath.Location = new System.Drawing.Point(113, 39);
            this.txtDecodeOutputPath.Name = "txtDecodeOutputPath";
            this.txtDecodeOutputPath.Size = new System.Drawing.Size(354, 12);
            this.txtDecodeOutputPath.TabIndex = 3;
            this.txtDecodeOutputPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDecodeMessage
            // 
            this.txtDecodeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecodeMessage.AutoSize = true;
            this.txtDecodeMessage.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDecodeMessage.Location = new System.Drawing.Point(113, 69);
            this.txtDecodeMessage.Name = "txtDecodeMessage";
            this.txtDecodeMessage.Size = new System.Drawing.Size(354, 12);
            this.txtDecodeMessage.TabIndex = 4;
            this.txtDecodeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectDecodeFile
            // 
            this.btnSelectDecodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDecodeFile.Location = new System.Drawing.Point(473, 3);
            this.btnSelectDecodeFile.Name = "btnSelectDecodeFile";
            this.btnSelectDecodeFile.Size = new System.Drawing.Size(74, 23);
            this.btnSelectDecodeFile.TabIndex = 5;
            this.btnSelectDecodeFile.Text = "Select File";
            this.btnSelectDecodeFile.UseVisualStyleBackColor = true;
            this.btnSelectDecodeFile.Click += new System.EventHandler(this.btnSelectDecodeFile_Click);
            // 
            // btnSelectDecodeOutputPath
            // 
            this.btnSelectDecodeOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDecodeOutputPath.Location = new System.Drawing.Point(473, 33);
            this.btnSelectDecodeOutputPath.Name = "btnSelectDecodeOutputPath";
            this.btnSelectDecodeOutputPath.Size = new System.Drawing.Size(74, 23);
            this.btnSelectDecodeOutputPath.TabIndex = 6;
            this.btnSelectDecodeOutputPath.Text = "Select Path";
            this.btnSelectDecodeOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectDecodeOutputPath.Click += new System.EventHandler(this.btnSelectDecodeOutputPath_Click);
            // 
            // btnExecuteDecode
            // 
            this.btnExecuteDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteDecode.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExecuteDecode.Location = new System.Drawing.Point(473, 63);
            this.btnExecuteDecode.Name = "btnExecuteDecode";
            this.btnExecuteDecode.Size = new System.Drawing.Size(74, 23);
            this.btnExecuteDecode.TabIndex = 7;
            this.btnExecuteDecode.Text = "DECODE";
            this.btnExecuteDecode.UseVisualStyleBackColor = true;
            this.btnExecuteDecode.Click += new System.EventHandler(this.btnExecuteDecode_Click);
            // 
            // dlgSelectEncodeFile
            // 
            this.dlgSelectEncodeFile.Filter = "All files|*.*";
            this.dlgSelectEncodeFile.RestoreDirectory = true;
            this.dlgSelectEncodeFile.Title = "Please select file to encode";
            // 
            // dlgSelectOutputPath
            // 
            this.dlgSelectOutputPath.Description = "Please select output path";
            // 
            // dlgSelectDecodeFile
            // 
            this.dlgSelectDecodeFile.DefaultExt = "txt";
            this.dlgSelectDecodeFile.Filter = "Text files|*.txt";
            this.dlgSelectDecodeFile.SupportMultiDottedExtensions = true;
            this.dlgSelectDecodeFile.Title = "Please select file to decode";
            // 
            // chkOutputSplit
            // 
            this.chkOutputSplit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkOutputSplit.AutoSize = true;
            this.chkOutputSplit.Location = new System.Drawing.Point(127, 67);
            this.chkOutputSplit.Name = "chkOutputSplit";
            this.chkOutputSplit.Size = new System.Drawing.Size(80, 16);
            this.chkOutputSplit.TabIndex = 9;
            this.chkOutputSplit.Text = "Output Split";
            this.chkOutputSplit.UseVisualStyleBackColor = true;
            this.chkOutputSplit.CheckedChanged += new System.EventHandler(this.chkOutputSplit_CheckedChanged);
            // 
            // txtSplitSize
            // 
            this.txtSplitSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitSize.Enabled = false;
            this.txtSplitSize.Location = new System.Drawing.Point(213, 64);
            this.txtSplitSize.MaxLength = 4;
            this.txtSplitSize.Name = "txtSplitSize";
            this.txtSplitSize.Size = new System.Drawing.Size(42, 22);
            this.txtSplitSize.TabIndex = 10;
            this.txtSplitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSplitSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSplitSize_KeyPress);
            // 
            // labSplitText
            // 
            this.labSplitText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSplitText.AutoSize = true;
            this.labSplitText.Location = new System.Drawing.Point(261, 69);
            this.labSplitText.Name = "labSplitText";
            this.labSplitText.Size = new System.Drawing.Size(21, 12);
            this.labSplitText.TabIndex = 11;
            this.labSplitText.Text = "KB";
            this.labSplitText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 128);
            this.Controls.Add(this.tbcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Base64 File Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbcMain.ResumeLayout(false);
            this.tpgEncode.ResumeLayout(false);
            this.tlpEncode.ResumeLayout(false);
            this.tlpEncode.PerformLayout();
            this.tpgDecode.ResumeLayout(false);
            this.tlpDecode.ResumeLayout(false);
            this.tlpDecode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tpgEncode;
        private System.Windows.Forms.TabPage tpgDecode;
        private System.Windows.Forms.TableLayoutPanel tlpEncode;
        private System.Windows.Forms.Label labEncodeFileName;
        private System.Windows.Forms.Label txtEncodeFileName;
        private System.Windows.Forms.Label labEncodeOutputPath;
        private System.Windows.Forms.Label txtEncodeOutputPath;
        private System.Windows.Forms.Label txtEncodeMessage;
        private System.Windows.Forms.Button btnSelectEncodeFile;
        private System.Windows.Forms.Button btnSelectEncodeOutputPath;
        private System.Windows.Forms.Button btnExecuteEncode;
        private System.Windows.Forms.TableLayoutPanel tlpDecode;
        private System.Windows.Forms.Label labDecodeFileName;
        private System.Windows.Forms.Label txtDecodeFileName;
        private System.Windows.Forms.Label labDecodeOutputPath;
        private System.Windows.Forms.Label txtDecodeOutputPath;
        private System.Windows.Forms.Label txtDecodeMessage;
        private System.Windows.Forms.Button btnSelectDecodeFile;
        private System.Windows.Forms.Button btnSelectDecodeOutputPath;
        private System.Windows.Forms.Button btnExecuteDecode;
        private System.Windows.Forms.OpenFileDialog dlgSelectEncodeFile;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectOutputPath;
        private System.Windows.Forms.OpenFileDialog dlgSelectDecodeFile;
        private System.Windows.Forms.CheckBox chkOutputArchivedFile;
        private System.Windows.Forms.CheckBox chkOutputSplit;
        private System.Windows.Forms.TextBox txtSplitSize;
        private System.Windows.Forms.Label labSplitText;

    }
}

