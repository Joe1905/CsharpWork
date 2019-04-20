using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_FormColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.LawnGreen;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(255, 0, 0);
        }

    }
}
