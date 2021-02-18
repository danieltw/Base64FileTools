using System;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms;
using System.Linq;


namespace Base64FileTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string EncodeFileName { get; set; }
        private byte[] bytEncodeFileContent { get; set; }

        private string DecodeFileName { get; set; }
        private byte[] bytDecodeFileContent { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.BICON;
        }

        #region File Encode
        private void btnSelectEncodeFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectEncodeFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtEncodeFileName.Text = dlgSelectEncodeFile.FileName;
                LoadEncodeFile();
            }
            catch (Exception ex)
            {
                txtEncodeMessage.Text = string.Format("Error : {0}", ex.Message);
            }
        }

        private void btnSelectEncodeOutputPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectOutputPath.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtEncodeMessage.Text = "";
                txtEncodeOutputPath.Text = dlgSelectOutputPath.SelectedPath;
            }
            catch (Exception ex)
            {
                txtEncodeMessage.Text = string.Format("Error : {0}", ex.Message);
            }
        }

        private void btnExecuteEncode_Click(object sender, EventArgs e)
        {
            if (txtEncodeFileName.Text == "" || txtEncodeOutputPath.Text == "") return;
            if (chkOutputSplit.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSplitSize.Text) || (Convert.ToInt32(txtSplitSize.Text.Trim()) < 5) || (Convert.ToInt32(txtSplitSize.Text.Trim()) > 5000))
                {
                    MessageBox.Show("Split Size MUST between 5 and 5000.");
                    return;
                }
            }

            btnExecuteEncode.Enabled = false;
            Thread trdEncode = new Thread(() => ConvertToBase64(chkOutputArchivedFile.Checked, chkOutputSplit.Checked));
            trdEncode.Start();
        }

        private void tpgEncode_DragDrop(object sender, DragEventArgs e)
        {
            var _files = e.Data.GetData("FileDrop");

            if ((_files as string[]).Length > 1)
            {
                UpdateEncodeMessageText("Error : only allow one file at one time!");
                return;
            }
            else if ((_files as string[]).Length < 1)
            {
                return;
            }
            txtEncodeFileName.Text = (_files as string[])[0];
            LoadEncodeFile();
        }

        private void tpgEncode_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LoadEncodeFile()
        {
            try
            {
                txtEncodeMessage.Text = "";
                FileInfo tmpFI = new FileInfo(txtEncodeFileName.Text);
                EncodeFileName = tmpFI.Name;
                using (FileStream tmpFS = new FileStream(txtEncodeFileName.Text, FileMode.Open, FileAccess.Read))
                {
                    bytEncodeFileContent = new byte[tmpFS.Length];
                    tmpFS.Read(bytEncodeFileContent, 0, (int)tmpFS.Length);
                }
                txtEncodeMessage.Text = "Info : Read file finish!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ConvertToBase64(bool OutputZip, bool OutputSplit)
        {
            int splitSize = 5;
            if (OutputSplit)
            {
                Int32.TryParse(txtSplitSize.Text, out splitSize);
                if (splitSize < 5) splitSize = 5;
                if (splitSize > 5000) splitSize = 5000;
            }

            try
            {
                UpdateEncodeMessageText("");
                string _TargetContentText = Convert.ToBase64String(bytEncodeFileContent) + Environment.NewLine + Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(EncodeFileName));

                if (OutputZip)
                {
                    string _TargetFileName = txtEncodeOutputPath.Text + (txtEncodeOutputPath.Text.EndsWith("\\") ? "" : "\\") + EncodeFileName + ".zip";
                    using (MemoryStream _ms = new MemoryStream())
                    {
                        using (ZipArchive tmpZipFile = new ZipArchive(_ms, ZipArchiveMode.Create))
                        {
                            if (OutputSplit)
                            {
                                byte[] _bufferData = System.Text.Encoding.ASCII.GetBytes(_TargetContentText);
                                int _loadSize = splitSize * 1024;

                                int _totalFileCount = _bufferData.Length / _loadSize + (_bufferData.Length % _loadSize > 0 ? 1 : 0);

                                string _fillText = "";
                                for (int i = 0; i < _totalFileCount.ToString().Length; i++) { _fillText += "0"; }

                                int _CT = 0;
                                int _LeftLength = _bufferData.Length;
                                while (_LeftLength > 0)
                                {
                                    ZipArchiveEntry tmpEntry = tmpZipFile.CreateEntry(EncodeFileName + "_" + _CT.ToString(_fillText) + ".txt");
                                    using (Stream _stm = tmpEntry.Open())
                                    {
                                        if (_loadSize > _LeftLength)
                                            _stm.Write(_bufferData.Skip(_CT * _loadSize).Take(_LeftLength).ToArray(), 0, _LeftLength);
                                        else
                                            _stm.Write(_bufferData.Skip(_CT * _loadSize).Take(_loadSize).ToArray(), 0, _loadSize);

                                        _LeftLength -= _loadSize;
                                        _CT++;
                                    }
                                }
                            }
                            else
                            {
                                ZipArchiveEntry tmpEntry = tmpZipFile.CreateEntry(EncodeFileName + ".txt");
                                using (Stream _stm = tmpEntry.Open())
                                {
                                    byte[] _bufferData = System.Text.Encoding.ASCII.GetBytes(_TargetContentText);
                                    _stm.Write(_bufferData, 0, _bufferData.Length);
                                }
                            }
                        }
                        System.IO.File.WriteAllBytes(_TargetFileName, _ms.ToArray());
                    }
                }
                else
                {
                    if (OutputSplit)
                    {
                        byte[] _bufferData = System.Text.Encoding.ASCII.GetBytes(_TargetContentText);
                        int _loadSize = splitSize * 1024;
                        int _totalFileCount = _bufferData.Length / _loadSize + (_bufferData.Length % _loadSize > 0 ? 1 : 0);

                        string _fillText = "";
                        for (int i = 0; i < _totalFileCount.ToString().Length; i++) { _fillText += "0"; }

                        int _CT = 0;
                        int _LeftLength = _bufferData.Length;
                        while (_LeftLength > 0)
                        {
                            string _tmpFileName = txtEncodeOutputPath.Text + (txtEncodeOutputPath.Text.EndsWith("\\") ? "" : "\\") + EncodeFileName + "_" + _CT.ToString(_fillText) + ".txt";

                            if (_loadSize > _LeftLength)
                                System.IO.File.WriteAllBytes(_tmpFileName, _bufferData.Skip(_CT * _loadSize).Take(_LeftLength).ToArray());
                            else
                                System.IO.File.WriteAllBytes(_tmpFileName, _bufferData.Skip(_CT * _loadSize).Take(_loadSize).ToArray());

                            _LeftLength -= _loadSize;
                            _CT++;
                        }
                    }
                    else
                    {
                        string _TargetFileName = txtEncodeOutputPath.Text + (txtEncodeOutputPath.Text.EndsWith("\\") ? "" : "\\") + EncodeFileName + ".txt";
                        byte[] _Buffer = System.Text.Encoding.ASCII.GetBytes(_TargetContentText);
                        System.IO.File.WriteAllBytes(_TargetFileName, _Buffer);
                    }
                }
                UpdateEncodeMessageText("Info : Encode Successfull.");
            }
            catch (Exception ex)
            {
                UpdateEncodeMessageText(string.Format("Error : {0}", ex.Message));
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

        private void UpdateEncodeMessageText(string text)
        {
            if (this.InvokeRequired)
            {
                Action action = () => { txtEncodeMessage.Text = text; };
                this.Invoke(action);
            }
            else
            {
                txtEncodeMessage.Text = text;
            }
        }
        #endregion

        #region File Decode
        private void btnSelectDecodeFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectDecodeFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtDecodeFileName.Text = dlgSelectDecodeFile.FileName;
                LoadDecodeFile();
            }
            catch (Exception ex)
            {
                txtDecodeMessage.Text = string.Format("Error : {0}", ex.Message);
            }
        }

        private void btnSelectDecodeOutputPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSelectOutputPath.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                txtDecodeMessage.Text = "";
                txtDecodeOutputPath.Text = dlgSelectOutputPath.SelectedPath;
            }
            catch (Exception ex)
            {
                txtDecodeMessage.Text = string.Format("Error : {0}", ex.Message);
            }
        }

        private void btnExecuteDecode_Click(object sender, EventArgs e)
        {
            if (txtDecodeFileName.Text == "" || txtDecodeOutputPath.Text == "") return;
            btnExecuteDecode.Enabled = false;
            Thread trdDecode = new Thread(() => ConvertFromBase64());
            trdDecode.Start();
        }

        private void tpgDecode_DragDrop(object sender, DragEventArgs e)
        {
            var _files = e.Data.GetData("FileDrop");

            if ((_files as string[]).Length > 1)
            {
                UpdateEncodeMessageText("Error : only allow one file at one time!");
                return;
            }
            else if ((_files as string[]).Length < 1)
            {
                return;
            }
            txtDecodeFileName.Text = (_files as string[])[0];
            LoadDecodeFile();
        }

        private void tpgDecode_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LoadDecodeFile()
        {
            try
            {
                txtDecodeMessage.Text = "";
                FileInfo tmpFI = new FileInfo(txtDecodeFileName.Text);
                DecodeFileName = tmpFI.Name;
                using (FileStream tmpFS = new FileStream(txtDecodeFileName.Text, FileMode.Open, FileAccess.Read))
                {
                    bytDecodeFileContent = new byte[tmpFS.Length];
                    tmpFS.Read(bytDecodeFileContent, 0, (int)tmpFS.Length);
                }
                txtDecodeMessage.Text = "Info : Read file finish!";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ConvertFromBase64()
        {
            try
            {
                UpdateDecodeMessageText("");
                string _TargetContentText = System.Text.Encoding.ASCII.GetString(bytDecodeFileContent);
                string _TargetFileName = "";
                if (_TargetContentText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length == 1)
                {
                    _TargetFileName = DecodeFileName.Substring(0, DecodeFileName.Length - 4);
                }
                else
                {
                    _TargetFileName = _TargetContentText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[1];
                    _TargetContentText = _TargetContentText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
                }

                _TargetFileName = txtDecodeOutputPath.Text + (txtDecodeOutputPath.Text.EndsWith("\\") ? "" : "\\") + System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(_TargetFileName));
                using (FileStream tmpFS = new FileStream(_TargetFileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] _Buffer = Convert.FromBase64String(_TargetContentText);
                    tmpFS.Write(_Buffer, 0, _Buffer.Length);
                }

                UpdateDecodeMessageText("Info : Decode Successfull.");
            }
            catch (Exception ex)
            {
                UpdateDecodeMessageText(string.Format("Error : {0}", ex.Message));
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

        private void UpdateDecodeMessageText(string text)
        {
            if (this.InvokeRequired)
            {
                Action action = () => { txtDecodeMessage.Text = text; };
                this.Invoke(action);
            }
            else
            {
                txtDecodeMessage.Text = text;
            }
        }
        #endregion

        private void chkOutputSplit_CheckedChanged(object sender, EventArgs e)
        {
            txtSplitSize.Text = "";
            txtSplitSize.Enabled = chkOutputSplit.Checked;
        }

        private void txtSplitSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar > 47) && (e.KeyChar < 58)) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
