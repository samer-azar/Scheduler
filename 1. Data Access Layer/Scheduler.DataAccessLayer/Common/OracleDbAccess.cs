using Microsoft.Win32;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.DataAccessLayer
{
    /// DB Access to Oracle
    public class OracleDbAccess
    {
        #region GLOBAL_VARIABLES
        public static string DBServerName = string.Empty;
        public static string DBUserName = string.Empty;
        public static string DBPassword = string.Empty;
        public const string DBConnectKey = "18CD-EYF3-28DC-CJPO";
        public static string sConnStringPooling = string.Empty;
        public OracleTransaction transaction;
        private OracleConnection oConnection;
        #endregion

        /// Get connection
        public OracleConnection GetConnection()
        {
            try
            {
                GetConnectionDetails();
                string connectionString = string.Format("Data Source={0}; User Id={1}; Password={2};", DBServerName, DBUserName, DBPassword);
                connectionString = connectionString + sConnStringPooling;
                oConnection = new OracleConnection(connectionString);
                return oConnection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// Get connection details
        private void GetConnectionDetails()
        {
            DBConnector.DBConnector reg = new DBConnector.DBConnector();

            if (DBServerName == string.Empty)
                DBServerName = reg.GetDBServerName(0);
            if (DBUserName == string.Empty)
                DBUserName = reg.GetDBUserName(0);
            if (DBPassword == string.Empty)
                DBPassword = reg.GetDBPassword(0);

            if (DBServerName == string.Empty | DBUserName == string.Empty | DBPassword == string.Empty)
                throw new Exception("Setup Error, Please contact NEXtCARE.");
        }

        /// Open connection to Oracle
        public void OpenConnection(OracleConnection connection)
        {
            if (connection != null)
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
            }
        }

        /// Close connection to Oracle
        public void CloseConnection(OracleConnection connection)
        {
            if (connection != null)
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        /// Get ref cursor
        public OracleParameter GetRefCursor()
        {
            OracleParameter User_RefCursor = new OracleParameter();
            User_RefCursor.OracleDbType = OracleDbType.RefCursor;
            User_RefCursor.Direction = System.Data.ParameterDirection.Output;
            return User_RefCursor;
        }

        /// Begin the transaction
        public void BeginTransaction() => transaction = oConnection.BeginTransaction();

        /// Commit the transaction
        public void CommitTransaction() => transaction.Commit();

        /// Rollback the transaction
        public void RollbackTransaction() => transaction.Rollback();

    }
}
