using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace execl_tool
{
    class Db_connect
    {
        static string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=execl_tool.accdb;Persist Security Info=False";

        public static void runsql(string sql, OleDbParameter[] para)
        {
            int rows = 0;
            try
            {
                using (OleDbConnection connect = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, connect))
                    {
                        if (para != null && para.Length > 0) cmd.Parameters.AddRange(para);

                        if (connect.State == System.Data.ConnectionState.Closed) connect.Open();

                        rows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public static DataTable getdata(string sql)
        {
            DataTable dt = null;
            OleDbConnection connect = new OleDbConnection(conStr);
            try
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, connect))
                {
                    if (connect.State == System.Data.ConnectionState.Closed)
                        connect.Open();
                    cmd.CommandText = sql;
                    cmd.Connection = connect;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dt = ConvertOleDbReaderToDataTable(ref reader);
                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (connect.State != System.Data.ConnectionState.Closed)
                {
                    connect.Close();
                }
            }
            return dt;
        }

        private static DataTable ConvertOleDbReaderToDataTable(ref OleDbDataReader reader)
        {
            DataTable dt_tmp = null;
            DataRow dr = null;
            int data_column_count = 0;
            int i = 0;

            data_column_count = reader.FieldCount;
            dt_tmp = BuildAndInitDataTable(data_column_count);

            if (dt_tmp == null)
            {
                return null;
            }

            while (reader.Read())
            {
                dr = dt_tmp.NewRow();

                for (i = 0; i < data_column_count; ++i)
                {
                    dr[i] = reader[i];
                }

                dt_tmp.Rows.Add(dr);
            }

            return dt_tmp;
        }

        private static DataTable BuildAndInitDataTable(int Field_Count)
        {
            DataTable dt_tmp = null;
            DataColumn dc = null;
            int i = 0;

            if (Field_Count <= 0)
            {
                return null;
            }

            dt_tmp = new DataTable();

            for (i = 0; i < Field_Count; ++i)
            {
                dc = new DataColumn(i.ToString());
                dt_tmp.Columns.Add(dc);
            }

            return dt_tmp;
        }

        public static bool have_line(string sql)
        {
            DataTable dt = getdata(sql);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
