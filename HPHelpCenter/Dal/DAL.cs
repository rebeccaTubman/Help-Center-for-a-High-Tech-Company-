using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;


namespace HPHelpCenter
{
    class DAL
    {
        private static DAL instance;
        private OleDbConnection con;
        private DataSet ds;
        private Hashtable adapters;

        private DAL(string connectionString)
        {
            con = new OleDbConnection(connectionString);
            ds = new DataSet();
            adapters = new Hashtable();
        }

        public static DAL GetInstance()
        {

            if (instance == null)
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                // F:\c#\יב\DemoProject\bin\Debug
                int x = path.IndexOf("\\bin");
                path = path.Substring(0, x) + "\\DATA\\פרויקטדמה.accdb";
                //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DATA\פרויקטדמה.accdb
                path = "D:\\HPHelpCenter.accdb";
                Console.WriteLine(path);
                instance = new DAL(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
            }  
            return instance;
        }
        /// <summary>
        /// פעולה המוסיפה טבלה ל- Dataset
        /// ומכינה את האדפטר לביצוע כל פעולות העידכון
        /// </summary>
        /// <param name="tableName">שם הטבלה</param>
        /// <param name="sqlStat">שאילתת שליפה</param>
        public bool AddTable(string tableName, string sqlStat)
        {
            if (!ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStat, con);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.Fill(ds, tableName);
                adapters.Add(tableName, adapter);
                return true;
            }
            return false;
        }
        public bool AddTable(string tableName)
        {
            return AddTable(tableName, "Select * from " + tableName);
        }
        public DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }
        public bool RemoveTable(string tableName)
        {
            bool suceed = true;
            try
            {
                ds.Tables.Remove(tableName);
                adapters.Remove(tableName);
            }
            catch
            {
                suceed = false;
            }
            return suceed;
        }
        public int ExecuteNonQuery(string sqlQry)
        {
            OleDbCommand command = con.CreateCommand();
            command.CommandText = sqlQry;
            con.Open();
            int x = command.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public object ExecuteScalarQuery(string sqlStr)
        {
            OleDbCommand command = con.CreateCommand();
            command.CommandText = sqlStr;
            con.Open();
            object obj = command.ExecuteScalar();
            con.Close();
            return obj;

        }
        public void Update(string tableName)
        {
            OleDbDataAdapter adapter = (OleDbDataAdapter)adapters[tableName];
            adapter.Update(ds, tableName);
        }
        public void Update()
        {
            foreach (DataTable table in ds.Tables)
            {
                Update(table.TableName);
            }
        }
        public void AddRelation(string relName, DataColumn primaryKey, DataColumn foreignKey)
        {
            try
            {
                ds.Relations.Add(relName, primaryKey, foreignKey);
            }
            catch { }
        }
        public void RemoveRelation(string relName)
        {
            try
            {
                ds.Relations.Remove(relName);
            }
            catch { }
        }
        public DataTable GetDisplayTable(string name, string sqlStat)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(sqlStat, con);
            ad.Fill(dt);
            return dt;
        }

    }
}


