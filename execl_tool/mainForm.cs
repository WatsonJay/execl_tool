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
            try
            {
                string show_name = table_list.Text;
                string table_name = main_db.get_table_name(show_name);
                DataTable reader = new DataTable();
                reader = main_db.show_table(table_name);
                show_dataView.DataSource = reader;
                show_dataView.Columns[0].Visible = false;
                List<string> name = main_db.GetTableFieldNameList(table_name);
                for (int i=show_dataView.ColumnCount; i>=1; i--){
                    show_dataView.Columns[i - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    show_dataView.Columns[i - 1].HeaderCell.Value = name[i-1];
                }
            }
            catch
            {
                MessageBox.Show("数据加载异常，请联系管理员");
            }
        }
    }
}
