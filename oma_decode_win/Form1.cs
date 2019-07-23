using System;
using System.Windows.Forms;
using oma_decode;
namespace oma_decode_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void _btnSrcFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if ((result = openFileDialog.ShowDialog()) == DialogResult.OK)
            {
                _txtSource.Text = openFileDialog.FileName;
            }
        }

        private void _btnSaveFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if ((result = saveFileDialog.ShowDialog()) == DialogResult.OK)
            {
                _txtSave.Text = saveFileDialog.FileName;
            }
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void _radio_CheckedChanged(object sender, EventArgs e)
        {
            _txtSource.Text = "";
            _txtSave.Text = "";
            _lbMessage.Text = "";
            _bDecode = _radioDecode.Checked;
            openFileDialog.Filter = _bDecode ? _strFilterOMA : _strFilterOMF;
            saveFileDialog.Filter = _bDecode ? _strFilterOMF : _strFilterOMA;
        }

        private void _btnAction_Click(object sender, EventArgs e)
        {
            bool result = false;
            string strMessage = "";
            if ((_txtSource.Text == "")
              || (_txtSave.Text == "")
              || (!System.IO.File.Exists(_txtSource.Text)))
            {
                strMessage = "请指定输入输出文件.";
            }
            else
            {
                result = _Do(_txtSource.Text, _txtSave.Text, _bDecode);
            }

            if (result)
            {
                _lbMessage.Text = "处理成功.";
                _lbMessage.ForeColor = System.Drawing.Color.Blue;

            }
            else
            {
                strMessage = "无效文件.";
                _lbMessage.Text = strMessage;
                _lbMessage.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        private bool _Do(string input, string output, bool bDecode)
        {
            bool result = false;
            try
            {
                result = bDecode ? oma_decode.Decoding.Decode(input, output) : oma_decode.Encoding.Encode(input, output);
            }
            catch (System.Exception)
            {
                ;
            }
            return result;
        }

        private bool _bDecode = true;
        private static string _strFilterOMA = "oma file(*.oma)|*.oma";
        private static string _strFilterOMF = "omf file(*.omf)|*.omf";
    }
}
