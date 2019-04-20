using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fontName = textBox2.Text;
            float fontSize = Convert.ToSingle(textBox1.Text);
            //label1.Font = new Font(textBox2.Text, fontSize);//此语句不会保留字体的Style属性
            label1.Font = new Font(textBox2.Text, fontSize,label1.Font.Style);//保留label1.Font.Style属性
        }

      


       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);//加粗效果
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Bold);//取消加粗
     
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);//倾斜效果
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Italic);//取消倾斜
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);//下划线效果
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Underline);//取消下划线
        }

        

        
    }
}
