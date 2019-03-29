using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace execl_tool
{
    public partial class mainForm : Skin_Mac
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confForm confForm = new confForm();
            confForm.ShowDialog();
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoForm infoForm = new infoForm();
            infoForm.ShowDialog();
        }
    }
}
