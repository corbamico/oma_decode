namespace oma_decode_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._txtSource = new System.Windows.Forms.TextBox();
            this._btnAction = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._lbSource = new System.Windows.Forms.Label();
            this._radioDecode = new System.Windows.Forms.RadioButton();
            this._radioEncode = new System.Windows.Forms.RadioButton();
            this._txtSave = new System.Windows.Forms.TextBox();
            this._lbSave = new System.Windows.Forms.Label();
            this._btnSrcFile = new System.Windows.Forms.Button();
            this._btnSaveFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._lbMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtSource
            // 
            this._txtSource.Location = new System.Drawing.Point(72, 47);
            this._txtSource.Name = "_txtSource";
            this._txtSource.ReadOnly = true;
            this._txtSource.Size = new System.Drawing.Size(357, 21);
            this._txtSource.TabIndex = 0;
            // 
            // _btnAction
            // 
            this._btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnAction.Location = new System.Drawing.Point(307, 122);
            this._btnAction.Name = "_btnAction";
            this._btnAction.Size = new System.Drawing.Size(75, 23);
            this._btnAction.TabIndex = 2;
            this._btnAction.Text = "文件处理";
            this._btnAction.UseVisualStyleBackColor = true;
            this._btnAction.Click += new System.EventHandler(this._btnAction_Click);
            // 
            // _btnExit
            // 
            this._btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnExit.Location = new System.Drawing.Point(388, 122);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 3;
            this._btnExit.Text = "退出";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _lbSource
            // 
            this._lbSource.AutoSize = true;
            this._lbSource.Location = new System.Drawing.Point(17, 49);
            this._lbSource.Name = "_lbSource";
            this._lbSource.Size = new System.Drawing.Size(47, 12);
            this._lbSource.TabIndex = 4;
            this._lbSource.Text = "源文件:";
            // 
            // _radioDecode
            // 
            this._radioDecode.AutoSize = true;
            this._radioDecode.Checked = true;
            this._radioDecode.Location = new System.Drawing.Point(18, 14);
            this._radioDecode.Name = "_radioDecode";
            this._radioDecode.Size = new System.Drawing.Size(89, 16);
            this._radioDecode.TabIndex = 5;
            this._radioDecode.TabStop = true;
            this._radioDecode.Text = "解密OMA文件";
            this._radioDecode.UseVisualStyleBackColor = true;
            this._radioDecode.CheckedChanged += new System.EventHandler(this._radio_CheckedChanged);
            // 
            // _radioEncode
            // 
            this._radioEncode.AutoSize = true;
            this._radioEncode.Location = new System.Drawing.Point(123, 14);
            this._radioEncode.Name = "_radioEncode";
            this._radioEncode.Size = new System.Drawing.Size(89, 16);
            this._radioEncode.TabIndex = 6;
            this._radioEncode.Text = "生成OMA文件";
            this._radioEncode.UseVisualStyleBackColor = true;
            this._radioEncode.CheckedChanged += new System.EventHandler(this._radio_CheckedChanged);
            // 
            // _txtSave
            // 
            this._txtSave.Location = new System.Drawing.Point(72, 87);
            this._txtSave.Name = "_txtSave";
            this._txtSave.ReadOnly = true;
            this._txtSave.Size = new System.Drawing.Size(357, 21);
            this._txtSave.TabIndex = 0;
            // 
            // _lbSave
            // 
            this._lbSave.AutoSize = true;
            this._lbSave.Location = new System.Drawing.Point(5, 87);
            this._lbSave.Name = "_lbSave";
            this._lbSave.Size = new System.Drawing.Size(59, 12);
            this._lbSave.TabIndex = 4;
            this._lbSave.Text = "目标文件:";
            // 
            // _btnSrcFile
            // 
            this._btnSrcFile.Image = ((System.Drawing.Image)(resources.GetObject("folderopen.png")));
            this._btnSrcFile.Location = new System.Drawing.Point(435, 45);
            this._btnSrcFile.Name = "_btnSrcFile";
            this._btnSrcFile.Size = new System.Drawing.Size(28, 23);
            this._btnSrcFile.TabIndex = 7;
            this._btnSrcFile.UseVisualStyleBackColor = true;
            this._btnSrcFile.Click += new System.EventHandler(this._btnSrcFile_Click);
            // 
            // _btnSaveFile
            // 
            this._btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("folderopen.png")));
            this._btnSaveFile.Location = new System.Drawing.Point(435, 87);
            this._btnSaveFile.Name = "_btnSaveFile";
            this._btnSaveFile.Size = new System.Drawing.Size(28, 23);
            this._btnSaveFile.TabIndex = 7;
            this._btnSaveFile.UseVisualStyleBackColor = true;
            this._btnSaveFile.Click += new System.EventHandler(this._btnSaveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._radioEncode);
            this.groupBox1.Controls.Add(this._radioDecode);
            this.groupBox1.Location = new System.Drawing.Point(72, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 37);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "oma file(*.oma)|*.oma";
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.ShowReadOnly = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "omf file(*.omf)|*.omf";
            // 
            // _lbMessage
            // 
            this._lbMessage.AutoSize = true;
            this._lbMessage.ForeColor = System.Drawing.Color.Crimson;
            this._lbMessage.Location = new System.Drawing.Point(73, 122);
            this._lbMessage.Name = "_lbMessage";
            this._lbMessage.Size = new System.Drawing.Size(0, 12);
            this._lbMessage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 157);
            this.Controls.Add(this._lbMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnSaveFile);
            this.Controls.Add(this._btnSrcFile);
            this.Controls.Add(this._lbSave);
            this.Controls.Add(this._lbSource);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnAction);
            this.Controls.Add(this._txtSave);
            this.Controls.Add(this._txtSource);
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "hyperpost oma解密/加密";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtSource;
        private System.Windows.Forms.Button _btnAction;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Label _lbSource;
        private System.Windows.Forms.RadioButton _radioDecode;
        private System.Windows.Forms.RadioButton _radioEncode;
        private System.Windows.Forms.TextBox _txtSave;
        private System.Windows.Forms.Label _lbSave;
        private System.Windows.Forms.Button _btnSrcFile;
        private System.Windows.Forms.Button _btnSaveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label _lbMessage;
    }
}

