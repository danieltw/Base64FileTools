using System;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms;

namespace Base64FileTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string TransferFileName { get; set; }
        private byte[] bytTransferFileContent { get; set; }

        private string SourceFileName { get; set; }
        private byte[] bytSourceFileContent { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.BICON;
        }

        #region 檔案轉碼
        private void btnSelectTransferFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectTransferFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtTransferFileName.Text = dlgSelectTransferFile.FileName;
                txtTransferError.Text = "";
                FileInfo tmpFI = new FileInfo(txtTransferFileName.Text);
                TransferFileName = tmpFI.Name;
                using (FileStream tmpFS = new FileStream(txtTransferFileName.Text, FileMode.Open, FileAccess.Read))
                {
                    bytTransferFileContent = new byte[tmpFS.Length];
                    tmpFS.Read(bytTransferFileContent, 0, (int)tmpFS.Length);
                }
                txtTransferError.Text = "檔案讀取完成!";
            }
            catch (Exception ex)
            {
                txtTransferError.Text = ex.Message;
            }
        }

        private void btnSelectTransferSavePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectPath.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtTransferError.Text = "";
                txtTransferSavePath.Text = dlgSelectPath.SelectedPath;
            }
            catch (Exception ex)
            {
                txtTransferError.Text = ex.Message;
            }
        }

        private void btnExecuteEncode_Click(object sender, EventArgs e)
        {
            if (txtTransferFileName.Text == "" || txtTransferSavePath.Text == "") return;
            bool _OutputCompressFile = chkCompress.Checked;

            btnExecuteEncode.Enabled = false;
            Thread trdEncode = new Thread(() => ConvertToBase64(_OutputCompressFile));
            trdEncode.Start();
        }

        private void ConvertToBase64(bool OutputZip)
        {
            try
            {
                UpdateTransferText("");
                string _TargetContentText = Convert.ToBase64String(bytTransferFileContent) + Environment.NewLine + Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(TransferFileName));

                if (OutputZip)
                {
                    string _TargetFileName = txtTransferSavePath.Text + (txtTransferSavePath.Text.EndsWith("\\") ? "" : "\\") + TransferFileName + ".zip";
                    using (MemoryStream _ms = new MemoryStream())
                    {
                        using (ZipArchive tmpZipFile = new ZipArchive(_ms, ZipArchiveMode.Create))
                        {
                            ZipArchiveEntry tmpEntry = tmpZipFile.CreateEntry(TransferFileName + ".txt");
                            using (Stream _stm = tmpEntry.Open())
                            {
                                byte[] _bufferData = System.Text.Encoding.ASCII.GetBytes(_TargetContentText);
                                _stm.Write(_bufferData, 0, _bufferData.Length);
                            }
                        }
                        System.IO.File.WriteAllBytes(_TargetFileName, _ms.ToArray());
                    }
                }
                else
                {
                    string _TargetFileName = txtTransferSavePath.Text + (txtTransferSavePath.Text.EndsWith("\\") ? "" : "\\") + TransferFileName + ".txt";
                    byte[] _Buffer = System.Text.Encoding.ASCII.GetBytes(_TargetContentText);
                    System.IO.File.WriteAllBytes(_TargetFileName, _Buffer);
                }
                UpdateTransferText("檔案轉碼成功!");
            }
            catch (Exception ex)
            {
                UpdateTransferText(ex.Message);
            }
            finally
            {
                if (this.InvokeRequired)
                {
                    Action action = () => { btnExecuteEncode.Enabled = true; };
                    this.Invoke(action);
                }
                else
                {
                    btnExecuteEncode.Enabled = true;
                }
            }
        }

        private void UpdateTransferText(string text)
        {
            if (this.InvokeRequired)
            {
                Action action = () => { txtTransferError.Text = text; };
                this.Invoke(action);
            }
            else
            {
                txtTransferError.Text = text;
            }
        }
        #endregion

        #region 檔案回復
        private void btnSelectSourceFIle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectSourceFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtSourceFileName.Text = dlgSelectSourceFile.FileName;
                txtDecodeError.Text = "";
                FileInfo tmpFI = new FileInfo(txtSourceFileName.Text);
                SourceFileName = tmpFI.Name;
                using (FileStream tmpFS = new FileStream(txtSourceFileName.Text, FileMode.Open, FileAccess.Read))
                {
                    bytSourceFileContent = new byte[tmpFS.Length];
                    tmpFS.Read(bytSourceFileContent, 0, (int)tmpFS.Length);
                }
                txtDecodeError.Text = "檔案讀取完成!";
            }
            catch (Exception ex)
            {
                txtDecodeError.Text = ex.Message;
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectPath.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtDecodeError.Text = "";
                txtSavePath.Text = dlgSelectPath.SelectedPath;
            }
            catch (Exception ex)
            {
                txtDecodeError.Text = ex.Message;
            }
        }

        private void btnExecuteDecode_Click(object sender, EventArgs e)
        {
            if (txtSourceFileName.Text == "" || txtSavePath.Text == "") return;
            btnExecuteDecode.Enabled = false;
            Thread trdDecode = new Thread(() => ConvertFromBase64());
            trdDecode.Start();
        }

        private void ConvertFromBase64()
        {
            try
            {
                UpdateDecodeText("");
                string _TargetContentText = System.Text.Encoding.ASCII.GetString(bytSourceFileContent);
                string _TargetFileName = "";
                if (_TargetContentText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length == 1)
                {
                    _TargetFileName = SourceFileName.Substring(0, SourceFileName.Length - 4);
                }
                else
                {
                    _TargetFileName = _TargetContentText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[1];
                    _TargetContentText = _TargetContentText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
                }

                _TargetFileName = txtSavePath.Text + (txtSavePath.Text.EndsWith("\\") ? "" : "\\") + System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(_TargetFileName));
                using (FileStream tmpFS = new FileStream(_TargetFileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] _Buffer = Convert.FromBase64String(_TargetContentText);
                    tmpFS.Write(_Buffer, 0, _Buffer.Length);
                }

                UpdateDecodeText("檔案回復成功!");
            }
            catch (Exception ex)
            {
                UpdateDecodeText(ex.Message);
            }
            finally
            {
                if (this.InvokeRequired)
                {
                    Action action = () => { btnExecuteDecode.Enabled = true; };
                    this.Invoke(action);
                }
                else
                {
                    btnExecuteDecode.Enabled = true;
                }
            }
        }

        private void UpdateDecodeText(string text)
        {
            if (this.InvokeRequired)
            {
                Action action = () => { txtDecodeError.Text = text; };
                this.Invoke(action);
            }
            else
            {
                txtDecodeError.Text = text;
            }
        }
        #endregion
    }
}
