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
        static int id = 0;
        static string table_show_name = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confForm confForm = new confForm();
            if (confForm.ShowDialog() == DialogResult.OK)
            {
                refresh();
            }
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoForm infoForm = new infoForm();
            infoForm.ShowDialog();
        }

        private void refresh()
        {
            table_list.DataSource = main_db.show_table_name();
        }

        private void choose_table_Click(object sender, EventArgs e)
        {
            string show_name = table_list.Text;
            DataTable reader = new DataTable();
            reader = main_db.show_table(show_name);
            show_dataView.DataSource = reader;
            show_dataView.Columns[0].Visible = false;
            show_dataView.AutoSize = true;
        }
    }
}
