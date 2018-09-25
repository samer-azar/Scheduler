using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace Scheduler.DataAccessLayer.Common
{
    /// Scheduler DAO
    public class SchedulerDao
    {
        /// Get user information from the DB
        public DataSet GetUserInformation(string Username, string Password, int EntityType, string SessionId)
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();
            DataSet dsSettings = null;

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("sp_PIO_Login", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters and assign them to values
                command.Parameters.Add("sUserName", OracleDbType.Varchar2).Value = Username;
                command.Parameters.Add("sPassword", OracleDbType.Varchar2).Value = Password;
                command.Parameters.Add("lEntityType", OracleDbType.Int32).Value = EntityType;
                command.Parameters.Add("sSessionID", OracleDbType.Varchar2).Value = SessionId;

                // Cursor returned
                command.Parameters.Add("oRefCursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                dataAdapter = new OracleDataAdapter(command);
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSettings = new DataSet();
                dataAdapter.Fill(dsSettings);
            }
            catch (Exception ex)
            {
                dsSettings = null;
            }
            return dsSettings;
        }






    }
}
