using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Data;

namespace Dal
{
    /// <summary>
    /// Common DB manipulation function.
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// Connection member
        /// </summary>
        private DbConnection cn;
        /// <summary>
        /// Command to be executed
        /// </summary>
        private DbCommand com;
        /// <summary>
        /// DB provider
        /// </summary>
        private DbProviderFactory factory;
        /// <summary>
        /// Create DB hlper instance for current thread
        /// </summary>
        public DBHelper(string conStrName)
        {
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\HPHelpCenter.accdb;Persist Security Info=True"; //ConfigurationManager.ConnectionStrings[conStrName].ConnectionString;
            string providerName = "System.Data.OleDb";// ConfigurationManager.ConnectionStrings[conStrName].ProviderName;
            
            factory = DbProviderFactories.GetFactory(providerName);
            cn = factory.CreateConnection();
            cn.ConnectionString = conStr;
            com = factory.CreateCommand();
            com.Connection = cn;
        }
        
        /// <summary>
        /// Open connection. Or use existing one when opened
        /// </summary>
        public void Open()
        {
            if (cn.State == ConnectionState.Open)
                return;

            cn.Open();
        }


        /// <summary>
        /// Begin transaction
        /// </summary>
        public void BeginTransaction()
        {
            Open();
            com.Transaction = cn.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        /// <summary>
        /// Commit transaction
        /// </summary>
        public void Commit()
        {
            try
            {
                if (com.Transaction != null)
                {
                    com.Transaction.Commit();
                }
            }
            catch
            {
                com.Transaction = null;
            }
            finally
            {
                com.Transaction = null;
            }
        }

        /// <summary>
        /// Rollback Transaction
        /// </summary>
        public void Rollback()
        {
            try
            {
                if (com.Transaction != null)
                    com.Transaction.Rollback();
            }
            catch
            {
                com.Transaction = null;
            }
            finally
            {
                com.Transaction = null;
            }
        }

        /// <summary>
        /// Execute store procedure.
        /// </summary>
        /// <param name="spName">SQL text</param>
        /// <param name="parameters">list of parameters</param>
        /// <returns>result</returns>
        public int ExecuteSPNonQuery(string spName, params DbParameter[] parameters)
        {
            try
            {
                Open();
                com.CommandText = spName;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddRange(parameters);
                return com.ExecuteNonQuery();
            }
            finally
            {
                com.CommandType = CommandType.Text;
                com.Parameters.Clear();
            }
        }

        /// <summary>
        /// Create new empty Parameter
        /// </summary>
        /// <returns>new empty Parameter</returns>
        public DbParameter GetParameter()
        {
            return factory.CreateParameter();
        }

        /// <summary>
        /// Create new parameter.
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <param name="value">paramater value</param>
        /// <returns>new parameter</returns>
        public DbParameter GetParameter(string name, object value)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            return p;
        }

        /// <summary>
        /// Create new parameter object value.
        /// </summary>
        /// <param name="name">parameter name</param>
        /// <param name="value">paramater value list</param>
        /// <returns>new parameter</returns>
        public DbParameter GetListParameter(string name, object value)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            p.DbType = DbType.Object;
            return p;
        }

        /// <summary>
        /// Execute query with parameters and fetch data.
        /// </summary>
        /// <param name="sql">Query to execute</param>
        /// <param name="parameters">query parameters</param>
        /// <returns>result</returns>
        public DbDataReader ExecuteReader(string sql, params DbParameter[] parameters)
        {
            try
            {
                Open();
                com.CommandText = sql;

                if (parameters != null)
                    com.Parameters.AddRange(parameters);

                return com.ExecuteReader();
            }
            finally
            {
                com.Parameters.Clear();
            }
        }

        /// <summary>
        /// Execute query without parameters and fetch data.
        /// </summary>
        /// <param name="sql">Query to execute</param>
        /// <returns>result</returns>
        public DbDataReader ExecuteReader(string sql)
        {
            Open();
            com.CommandText = sql;
            return com.ExecuteReader();
        }

        /// <summary>
        /// Execute query without parameters and fetch data.
        /// </summary>
        /// <param name="sql">Query to execute</param>
        /// <returns>result</returns>
        public object ExecuteScalar(string sql)
        {
            Open();
            com.CommandText = sql;
            return com.ExecuteScalar();
        }

        /// <summary>
        /// Execute update/insert query without parameters
        /// </summary>
        /// <param name="sql">sql query</param>
        /// <returns>records changed</returns>
        public int ExecuteNonQuery(string sql)
        {
            Open();
            com.CommandText = sql;
            return com.ExecuteNonQuery();
        }

        /// <summary>
        /// Execute update/insert query with parameters
        /// </summary>
        /// <param name="sql">sql query</param>
        /// <param name="parameters">parameters</param>
        /// <returns>records changed</returns>
        public int ExecuteNonQuery(string sql, params DbParameter[] parameters)
        {
            try
            {
                com.Parameters.AddRange(parameters);
                return ExecuteNonQuery(sql);
            }
            finally
            {
                com.Parameters.Clear();
            }
        }

        /// <summary>
        /// Close connection
        /// </summary>
        public void Close()
        {
            cn.Close();
        }

        /// <summary>
        /// Close result set after read.
        /// </summary>
        /// <param name="reader"></param>
        public void Close(DbDataReader reader)
        {
            if (reader != null)
                reader.Close();
        }
    }
}
