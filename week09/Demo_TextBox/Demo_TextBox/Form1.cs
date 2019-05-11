using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demo_TextBox
{
    public partial class Form1 : Form
    {
        private string _FileName = "";//文件名
        private bool _IsSaved = true;//是否已保存

        private void SaveTextFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(textBox1.Text);
            sw.Flush();//文件流
            sw.Close();//最后要关闭写入状态
            _IsSaved = true;
            this.Text = _FileName;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void GetRowColInfo()
        {            
            int index = textBox1.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
            int row = textBox1.GetLineFromCharIndex(index) + 1;//得到当前行的行号,从0开始，习惯是从1开始，所以+1.
            int col = textBox1.SelectionStart - index + 1;//.SelectionStart得到光标所在位置的索引 减去 当前行第一个字符的索引 = 光标所在的列数（从0开始) 

            statusBar_Row.Text = row.ToString() + " 行";
            statusBar_Col.Text = col.ToString() + " 列";
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            GetRowColInfo();
        }

        private void mi_AutoLine_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            textBox1.WordWrap = ((ToolStripMenuItem)sender).Checked;
        }

        private void mi_StatusStrip_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            this.statusStrip1.Visible = ((ToolStripMenuItem)sender).Checked;
        }
        private void mi_NewFile_Click(object sender, EventArgs e)
        {
            DialogResult dResult;
            if (!_IsSaved)
            {
                dResult = MessageBox.Show("当前文档已修改，要保存吗？", "保存提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (this.textBox1.Text == "文本文档")
                    {
                        mi_SaveAs_Click(sender, e);
                    }
                    else
                    {
                        mi_SaveFile_Click(sender, e);
                    }
                }
                else if (dResult == DialogResult.No)
                {
                    _FileName = "";
                    _IsSaved = true;
                    textBox1.Clear();
                    this.Text = "新建文本文档";
                    textBox1.Focus();
                }
            }
            else
            {
                _FileName = "";
                _IsSaved = true;
                textBox1.Clear();
                this.Text = "新建文本文档";
                textBox1.Focus();
            }
        }
     

        private void mi_FontSetup_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void mi_OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr;
                sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                _FileName = openFileDialog1.FileName;
                this.Text = _FileName;
                _IsSaved = true;
            }
        }
        private void mi_SaveFile_Click(object sender, EventArgs e)
        {
            if (_FileName == "")
            {
                mi_SaveAs_Click(sender, e);
            }
            else
            {
                SaveTextFile(_FileName);
            }
        }

        private void mi_SaveAs_Click(object sender, EventArgs e)
        {
            if (_FileName == "")
                _FileName = this.Text;

            saveFileDialog1.FileName = _FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _FileName = saveFileDialog1.FileName;
                SaveTextFile(_FileName);
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            _IsSaved = false;
        }

        private void mi_Exit_Click(object sender, EventArgs e)
        {
            if (!_IsSaved)
            {
                DialogResult dr = MessageBox.Show("文档内容已修改，要保存吗？", "保存提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.Yes:
                        mi_SaveFile_Click(sender, e);
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    default:
                        textBox1.Focus();
                        break;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void mi_PageSetup_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document.DefaultPageSettings = pageSetupDialog1.Document.DefaultPageSettings;
            }
        }

        private void mi_Print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                //printDialog1.Document.ToString() = textBox1.Text;
                printDialog1.Document.Print();
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(textBox1, new Point(e.X, e.Y));
            }

            GetRowColInfo();
        }

        private void mi_Edit_Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void mi_Edit_Cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void mi_Edit_Paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void mi_Edit_Undo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void mi_Edit_DropDownOpened(object sender, EventArgs e)
        {
            mi_Edit_Undo.Enabled = textBox1.CanUndo;

            mi_Edit_Copy.Enabled = textBox1.SelectionLength > 0;
            mi_Edit_Cut.Enabled = mi_Copy.Enabled;

            mi_Copy.Enabled = textBox1.SelectionLength > 0;
            mi_Cut.Enabled = mi_Copy.Enabled;

            mi_Paste.Enabled = Clipboard.ContainsText();
            mi_Edit_Paste.Enabled = mi_Paste.Enabled;
        }
        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            mi_Edit_DropDownOpened(sender, e);
        }

        private void mi_About_Click(object sender, EventArgs e)
        {
           // (new AboutBox()).ShowDialog();
        }
    }
}
