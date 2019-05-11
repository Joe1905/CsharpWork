namespace Demo_TextBox
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Col = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_PageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_AutoLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_FontSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_StatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_DisplayHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(859, 380);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.statusBar_Row,
            this.statusBar_Col});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(714, 17);
            this.statusBar.Spring = true;
            // 
            // statusBar_Row
            // 
            this.statusBar_Row.AutoSize = false;
            this.statusBar_Row.Name = "statusBar_Row";
            this.statusBar_Row.Size = new System.Drawing.Size(65, 17);
            this.statusBar_Row.Text = "1 行";
            // 
            // statusBar_Col
            // 
            this.statusBar_Col.AutoSize = false;
            this.statusBar_Col.Name = "statusBar_Col";
            this.statusBar_Col.Size = new System.Drawing.Size(65, 17);
            this.statusBar_Col.Text = "1 列";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File,
            this.mi_Edit,
            this.mi_Format,
            this.mi_Status,
            this.mi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_File
            // 
            this.mi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NewFile,
            this.mi_OpenFile,
            this.mi_SaveFile,
            this.mi_SaveAs,
            this.toolStripMenuItem1,
            this.mi_PageSetup,
            this.mi_Print,
            this.toolStripMenuItem2,
            this.mi_Exit});
            this.mi_File.Name = "mi_File";
            this.mi_File.Size = new System.Drawing.Size(58, 21);
            this.mi_File.Text = "文件(&F)";
            // 
            // mi_NewFile
            // 
            this.mi_NewFile.Name = "mi_NewFile";
            this.mi_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_NewFile.Size = new System.Drawing.Size(165, 22);
            this.mi_NewFile.Text = "新建(&N)";
            this.mi_NewFile.Click += new System.EventHandler(this.mi_NewFile_Click);
            // 
            // mi_OpenFile
            // 
            this.mi_OpenFile.Name = "mi_OpenFile";
            this.mi_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_OpenFile.Size = new System.Drawing.Size(165, 22);
            this.mi_OpenFile.Text = "打开(&O)";
            this.mi_OpenFile.Click += new System.EventHandler(this.mi_OpenFile_Click);
            // 
            // mi_SaveFile
            // 
            this.mi_SaveFile.Name = "mi_SaveFile";
            this.mi_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_SaveFile.Size = new System.Drawing.Size(165, 22);
            this.mi_SaveFile.Text = "保存(&S)";
            this.mi_SaveFile.Click += new System.EventHandler(this.mi_SaveFile_Click);
            // 
            // mi_SaveAs
            // 
            this.mi_SaveAs.Name = "mi_SaveAs";
            this.mi_SaveAs.Size = new System.Drawing.Size(165, 22);
            this.mi_SaveAs.Text = "另存为(&A)";
            this.mi_SaveAs.Click += new System.EventHandler(this.mi_SaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_PageSetup
            // 
            this.mi_PageSetup.Name = "mi_PageSetup";
            this.mi_PageSetup.Size = new System.Drawing.Size(165, 22);
            this.mi_PageSetup.Text = "页面设置(&U)";
            this.mi_PageSetup.Click += new System.EventHandler(this.mi_PageSetup_Click);
            // 
            // mi_Print
            // 
            this.mi_Print.Name = "mi_Print";
            this.mi_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mi_Print.Size = new System.Drawing.Size(165, 22);
            this.mi_Print.Text = "打印(&P)";
            this.mi_Print.Click += new System.EventHandler(this.mi_Print_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(165, 22);
            this.mi_Exit.Text = "退出(&X)";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // mi_Edit
            // 
            this.mi_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Edit_Undo,
            this.toolStripMenuItem3,
            this.mi_Edit_Copy,
            this.mi_Edit_Cut,
            this.mi_Edit_Paste});
            this.mi_Edit.Name = "mi_Edit";
            this.mi_Edit.Size = new System.Drawing.Size(59, 21);
            this.mi_Edit.Text = "编辑(&E)";
            this.mi_Edit.DropDownOpened += new System.EventHandler(this.mi_Edit_DropDownOpened);
            // 
            // mi_Edit_Undo
            // 
            this.mi_Edit_Undo.Name = "mi_Edit_Undo";
            this.mi_Edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mi_Edit_Undo.Size = new System.Drawing.Size(161, 22);
            this.mi_Edit_Undo.Text = "撤销(&U)";
            this.mi_Edit_Undo.Click += new System.EventHandler(this.mi_Edit_Undo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 6);
            // 
            // mi_Edit_Copy
            // 
            this.mi_Edit_Copy.Name = "mi_Edit_Copy";
            this.mi_Edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mi_Edit_Copy.Size = new System.Drawing.Size(161, 22);
            this.mi_Edit_Copy.Text = "复制(&C)";
            this.mi_Edit_Copy.Click += new System.EventHandler(this.mi_Edit_Copy_Click);
            // 
            // mi_Edit_Cut
            // 
            this.mi_Edit_Cut.Name = "mi_Edit_Cut";
            this.mi_Edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mi_Edit_Cut.Size = new System.Drawing.Size(161, 22);
            this.mi_Edit_Cut.Text = "剪切(&X)";
            this.mi_Edit_Cut.Click += new System.EventHandler(this.mi_Edit_Cut_Click);
            // 
            // mi_Edit_Paste
            // 
            this.mi_Edit_Paste.Name = "mi_Edit_Paste";
            this.mi_Edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mi_Edit_Paste.Size = new System.Drawing.Size(161, 22);
            this.mi_Edit_Paste.Text = "粘贴(&V)";
            this.mi_Edit_Paste.Click += new System.EventHandler(this.mi_Edit_Paste_Click);
            // 
            // mi_Format
            // 
            this.mi_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_AutoLine,
            this.mi_FontSetup});
            this.mi_Format.Name = "mi_Format";
            this.mi_Format.Size = new System.Drawing.Size(62, 21);
            this.mi_Format.Text = "格式(&O)";
            // 
            // mi_AutoLine
            // 
            this.mi_AutoLine.Checked = true;
            this.mi_AutoLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_AutoLine.Name = "mi_AutoLine";
            this.mi_AutoLine.Size = new System.Drawing.Size(144, 22);
            this.mi_AutoLine.Text = "自动换行(&W)";
            this.mi_AutoLine.Click += new System.EventHandler(this.mi_AutoLine_Click);
            // 
            // mi_FontSetup
            // 
            this.mi_FontSetup.Name = "mi_FontSetup";
            this.mi_FontSetup.Size = new System.Drawing.Size(144, 22);
            this.mi_FontSetup.Text = "字体(&F)";
            this.mi_FontSetup.Click += new System.EventHandler(this.mi_FontSetup_Click);
            // 
            // mi_Status
            // 
            this.mi_Status.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_StatusStrip});
            this.mi_Status.Name = "mi_Status";
            this.mi_Status.Size = new System.Drawing.Size(60, 21);
            this.mi_Status.Text = "查看(&V)";
            // 
            // mi_StatusStrip
            // 
            this.mi_StatusStrip.Checked = true;
            this.mi_StatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_StatusStrip.Name = "mi_StatusStrip";
            this.mi_StatusStrip.Size = new System.Drawing.Size(127, 22);
            this.mi_StatusStrip.Text = "状态栏(&S)";
            this.mi_StatusStrip.Click += new System.EventHandler(this.mi_StatusStrip_Click);
            // 
            // mi_Help
            // 
            this.mi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_DisplayHelp,
            this.mi_About});
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(61, 21);
            this.mi_Help.Text = "帮助(&H)";
            // 
            // mi_DisplayHelp
            // 
            this.mi_DisplayHelp.Name = "mi_DisplayHelp";
            this.mi_DisplayHelp.Size = new System.Drawing.Size(152, 22);
            this.mi_DisplayHelp.Text = "查看帮助(&H）";
            // 
            // mi_About
            // 
            this.mi_About.Name = "mi_About";
            this.mi_About.Size = new System.Drawing.Size(152, 22);
            this.mi_About.Text = "关于记事本(&A)";
            this.mi_About.Click += new System.EventHandler(this.mi_About_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 405);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "记事本";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Row;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Col;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_File;
        private System.Windows.Forms.ToolStripMenuItem mi_NewFile;
        private System.Windows.Forms.ToolStripMenuItem mi_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mi_PageSetup;
        private System.Windows.Forms.ToolStripMenuItem mi_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit;
        private System.Windows.Forms.ToolStripMenuItem mi_Format;
        private System.Windows.Forms.ToolStripMenuItem mi_Status;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem mi_AutoLine;
        private System.Windows.Forms.ToolStripMenuItem mi_FontSetup;
        private System.Windows.Forms.ToolStripMenuItem mi_StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem mi_DisplayHelp;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mi_Copy;
        private System.Windows.Forms.ToolStripMenuItem mi_Cut;
        private System.Windows.Forms.ToolStripMenuItem mi_Paste;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

