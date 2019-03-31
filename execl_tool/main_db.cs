﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace execl_tool
{
    class main_db
    {
        static string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=execl_tool.accdb;Persist Security Info=False";

        public static List<string> get_table_show_name()
        {
            List<string> list = new List<string>();
            string sql = "SELECT ID,table_name,table_show_name FROM table_relation";
            DataTable dt = new DataTable();
            dt = db_connect.getdata(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[2].ToString());
            }
            return list;
        }

        public static string get_table_name(string show_name)
        {
            string sql = "SELECT table_name FROM table_relation where table_show_name = '"+ show_name + "'";
            string table_name = "";
            DataTable dt = new DataTable();
            dt = db_connect.getdata(sql);
            if (dt.Rows.Count != 1)
            {
                throw new MyException("存在多条重复数据");
            }
            else
            {
                table_name=dt.Rows[0][0].ToString();
            }
            return table_name;
        }

        public static DataTable show_table(string show_name)
        {
           string table_name = get_table_name(show_name);
           string sql = "SELECT * FROM "+ table_name;
           DataTable dt = new DataTable();
           dt = db_connect.getdata(sql);
           return dt;
        }


        public static List<string> show_table_name()
        {
            List<string> list = new List<string>();
            string sql = "SELECT ID,table_name,table_show_name FROM table_relation";
            DataTable dt = new DataTable();
            dt = db_connect.getdata(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[2].ToString());
            }
            return list;
        }
    }
}
