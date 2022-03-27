using LibraryAutomation.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryAutomation
{
    
    class Database : Queries
    {
        private SqlConnection dbConnection;
        public Database(List<string> keys, List<string> values) : base(keys, values)
        {
            dbConnection = new SqlConnection("Data Source=AZIZ\\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True");
        }

        public Database() : base()
        {
            dbConnection = new SqlConnection("Data Source=AZIZ\\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True");
        }
        public int InsertData(string tableName)
        {
            SqlCommand sql = null;
            try
            {
                dbConnection.Open();
                sql = new SqlCommand(GetInsertQuery(tableName), dbConnection);
                return sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("InsertData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if(dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                    if(sql != null)
                    {
                        sql.Dispose();
                    }
                }
            }
            
        }

        public int UpdateData(string tableName, string fieldName, int id)
        {
            SqlCommand sql = null;
            try
            {
                dbConnection.Open();
                sql = new SqlCommand(GetUpdateQuery(tableName, fieldName, id), dbConnection);
                return sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                    if (sql != null)
                    {
                        sql.Dispose();
                    }
                }
            }
        }

        public int DeleteData(string tableName, string fieldName, int id)
        {
            SqlCommand sql = null;
            try
            {
                dbConnection.Open();
                sql = new SqlCommand(GetDeleteQuery(tableName, fieldName, id), dbConnection);
                return sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                    if (sql != null)
                    {
                        sql.Dispose();
                    }
                }
            }
        }

        public List<SqlDataReader> GetAllData(string tableName)
        {
            SqlCommand sql = null;
            List<SqlDataReader> dataReaders = new List<SqlDataReader>();
            try
            {
                dbConnection.Open();
                sql = new SqlCommand(GetAllDataQuery(tableName), dbConnection);
                SqlDataReader _reader = sql.ExecuteReader();
                while (_reader.Read())
                {
                    dataReaders.Add(_reader);
                }
                return dataReaders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    //dbConnection.Close();
                    //if (sql != null)
                    //{
                    //    sql.Dispose();
                    //}
                }
            }
        }

        public SqlDataReader GetData(string tableName, string fieldName, int id)
        {
            SqlCommand sql = null;
            try
            {
                dbConnection.Open();
                sql = new SqlCommand(GetDataQuery(tableName, fieldName, id), dbConnection);
                SqlDataReader _reader = sql.ExecuteReader();
                return _reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteData error: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    //dbConnection.Close();
                    //if (sql != null)
                    //{
                    //    sql.Dispose();
                    //}
                }
            }
        }
    }
}
