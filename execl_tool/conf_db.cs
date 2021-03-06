﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace execl_tool
{
    class conf_db
    {
        static string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=execl_tool.accdb;Persist Security Info=False";
        public static DataTable relation_table()
        {
            string sql = "SELECT ID,table_name,table_show_name FROM table_relation";
            DataTable dt = new DataTable();
            dt = Db_connect.getdata(sql);
            return dt;
        }

        public static List<string> GetTableNameList()
        {
            List<string> list = new List<string>();
            OleDbConnection Conn = new OleDbConnection(conStr);
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                DataTable dt = Conn.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    if (row[3].ToString() == "TABLE")
                        list.Add(row[2].ToString());
                }
                return list;
            }
            catch (Exception e)
            { throw e; }
            finally { if (Conn.State == ConnectionState.Open) Conn.Close(); Conn.Dispose(); }
        }

        public static void insertrelation(string table, string show_name)
        {
            
            //对数据库进添加一个用户操作
            string sql = "insert into table_relation(table_name,table_show_name)values(@table_name,@table_show_name)";
            OleDbParameter[] para = {
                             new OleDbParameter("@table_name",OleDbType.VarChar),
                             new OleDbParameter("@table_show_name",OleDbType.VarChar),
                             /*
                              * 我不知道这样写有什么区别，除了更简单还有什么好处
                                new OleDbParameter("@age",age)
                              */
                         };
            para[0].Value = table;
            para[1].Value = show_name;

            Db_connect.runsql(sql, para);
        }
        public static bool have_relation(string table)
        {
            string sql_search = "SELECT ID,table_name,table_show_name FROM table_relation WHERE table_name ='" + table+"'";
            return Db_connect.have_line(sql_search);
        }

        public static void delrelation(int ID)
        {

            //对数据库进添加一个用户操作
            string sql = "DELETE FROM table_relation WHERE ID = @ID";
            OleDbParameter[] para = {
                             new OleDbParameter("@ID",OleDbType.Integer),
                             /*
                              * 我不知道这样写有什么区别，除了更简单还有什么好处
                                new OleDbParameter("@age",age)
                              */
                         };
            para[0].Value = ID;

            Db_connect.runsql(sql, para);
        }

        public static void updaterelation(int ID, string table, string show_name)
        {

            //对数据库进添加一个用户操作
            string sql = "UPDATE table_relation SET table_name = @table_name,table_show_name=@table_show_name WHERE ID = @ID";
            OleDbParameter[] para = {
                             new OleDbParameter("@table_name",OleDbType.VarChar),
                             new OleDbParameter("@table_show_name",OleDbType.VarChar),
                             new OleDbParameter("@ID",OleDbType.Integer),
                             /*
                              * 我不知道这样写有什么区别，除了更简单还有什么好处
                                new OleDbParameter("@age",age)
                              */
                         };
            para[0].Value = table;
            para[1].Value = show_name;
            para[2].Value = ID;

            Db_connect.runsql(sql, para);
        }
    }
}
