
using System;
using System.Drawing;
namespace Demo_FormDesigner
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 25);//左上角的位置坐标Point(X,Y);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 12);//对象的大小Size(Width,Height);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hello,World!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "设置HelloWorld所在的标签居中显示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "用手写代码的方式创建一个显示Hello,World的文本标签，设计窗口中可见";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ww = this.Width;//窗口的宽度
            int w1 = Label1.Width;//标签Label1的宽度
            int x = (ww - w1) / 2;//计算Label1.X的值
            Label1.Location = new Point(x, Label1.Location.Y);
        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
    }
}

