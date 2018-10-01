using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace Scheduler.DataAccessLayer.Common
{
    /// Scheduler Ddata access object
    public static class SchedulerDao
    {
        /// Get active schedulers from TScheduler table
        public static DataSet GetActiveSchedulers()
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();
            DataSet dsSchedulers = null;

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_GetActiveSchedulers", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Cursor returned
                command.Parameters.Add("oRefCursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                dataAdapter = new OracleDataAdapter(command);
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulers = new DataSet();
                dataAdapter.Fill(dsSchedulers);
            }
            catch (Exception ex)
            {
                dsSchedulers = null;
            }
            return dsSchedulers;
        }

        /// Get active schedulerSettings from TSchedulerSettings table
        public static DataSet GetActiveSchedulerSettings()
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();
            DataSet dsSchedulerSettings = null;

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_GetActiveSchedSettings", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Cursor returned
                command.Parameters.Add("oRefCursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                dataAdapter = new OracleDataAdapter(command);
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulerSettings = new DataSet();
                dataAdapter.Fill(dsSchedulerSettings);
            }
            catch (Exception ex)
            {
                dsSchedulerSettings = null;
            }
            return dsSchedulerSettings;
        }

        /// Get current executions from TSchedulerExecutions table
        public static DataSet GetCurrentExecutions()
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();
            DataSet dsSchedulerSettings = null;

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_GetCurrentSchedExe", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Cursor returned
                command.Parameters.Add("oRefCursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                dataAdapter = new OracleDataAdapter(command);
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulerSettings = new DataSet();
                dataAdapter.Fill(dsSchedulerSettings);
            }
            catch (Exception ex)
            {
                dsSchedulerSettings = null;
            }
            return dsSchedulerSettings;
        }



    }
}
