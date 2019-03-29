using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace execl_tool
{
    public partial class confForm : Skin_Mac
    {
        public confForm()
        {
            InitializeComponent();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            string table = this.table_list.Text;
            string show_name = this.show_name.Text;
            if (!conf_db.have_relation(table))
            {
                MessageBox.Show("存在该表关系");
            }
            else
            {
                try
                {
                    conf_db.insertrelation(table, show_name);
                }
                catch
                {
                    MessageBox.Show("新增出现异常");
                }
                refresh();
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {

        }

        private void modify_Button_Click(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            table_list.DataSource = conf_db.GetTableNameList();
            DataTable reader = new DataTable();
            reader = conf_db.relation_table();
            show_table.DataSource = reader;
            show_table.Columns[1].Visible = false;
            show_table.Columns[2].HeaderCell.Value = "表名";
            show_table.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            show_table.Columns[3].HeaderCell.Value = "显示名称";
            show_table.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
