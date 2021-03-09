using System;
using System.Data.SqlClient;
using System.Data;

namespace SeleniumFramework.Helpers
{
    public static class DataHelperExtensions
    {

        // open the connection to db
        public static SqlConnection DBConnect(this SqlConnection sqlConnection, string connectionString)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch(Exception e)
            {
                LogHelpers.WriteLog("Error in connecting to db" + e.Message);
                return null;
            }
            
        }


        // closing the connection
        public static void DBClose(this SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Close();
            }
            catch(Exception e)
            {
                LogHelpers.WriteLog("Error in closing the DB connection" + e.Message);
            }
        }

        // Executing queries
        public static DataTable ExecuteQuery(this SqlConnection sqlConnection, string queryString)
        {
            DataSet dataSet;

            try
            {
                if(sqlConnection == null || (sqlConnection != null && (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken)))
                {
                    sqlConnection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(queryString, sqlConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "table");

            }
            catch(Exception e)
            {
                dataSet = null;
                sqlConnection.Close();
                LogHelpers.WriteLog("Error in running the query" + e.Message);
            }

            finally
            {
                sqlConnection.Close();
                dataSet = null;
            }

            return dataSet.Tables["table"];

        }

    }
}
    