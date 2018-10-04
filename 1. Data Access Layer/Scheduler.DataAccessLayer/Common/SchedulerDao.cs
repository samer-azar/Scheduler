using Oracle.DataAccess.Client;
using Scheduler.DataAccessLayer.Model;
using Scheduler.LoggerLibrary.Common;
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
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulers = new DataSet();
                dataAdapter.Fill(dsSchedulers);
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                dsSchedulers = null;
            }
            return dsSchedulers;
        }

        public static DataSet GetJobScheduler(int iSchedulerId)
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();
            DataSet dsScheduler = null;

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_GetJobScheduler", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters and assign them to values
                command.Parameters.Add("iSchedulerId", OracleDbType.Int32).Value = iSchedulerId;

                // Cursor returned
                command.Parameters.Add("oRefCursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsScheduler = new DataSet();
                dataAdapter.Fill(dsScheduler);
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                dsScheduler = null;
            }
            return dsScheduler;
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
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulerSettings = new DataSet();
                dataAdapter.Fill(dsSchedulerSettings);
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
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
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulerSettings = new DataSet();
                dataAdapter.Fill(dsSchedulerSettings);
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                dsSchedulerSettings = null;
            }
            return dsSchedulerSettings;
        }

        /// <summary>
        /// Get latest execution logs grouped by SchedulerSettingsId
        /// </summary>
        /// <returns>Dataset</returns>
        public static DataSet GetLatestExecutionLogs()
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();
            DataSet dsSchedulerExecutionLogs = null;

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_GetLastExecutionLogs", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Cursor returned
                command.Parameters.Add("oRefCursor", OracleDbType.RefCursor, ParameterDirection.InputOutput);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                command.ExecuteNonQuery();

                // Fill dataset
                dataAdapter = new OracleDataAdapter(command);
                dsSchedulerExecutionLogs = new DataSet();
                dataAdapter.Fill(dsSchedulerExecutionLogs);
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                dsSchedulerExecutionLogs = null;
            }
            return dsSchedulerExecutionLogs;
        }

        /// Disable scheduler
        public static bool SetSchedulerState(int schedulerId, bool enabled)
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleCommand command = new OracleCommand();

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_SetSchedulerState", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters and assign them to values
                command.Parameters.Add("iSchedulerId", OracleDbType.Int32).Value = schedulerId;
                command.Parameters.Add("bEnabled", OracleDbType.Int32).Value = enabled;

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                return false;
            }
        }

        /// Disable scheduler settings
        public static bool SetSchedulerSettingState(int schedulerSettingsId, bool enabled)
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleCommand command = new OracleCommand();

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_SetSchdlrStgsState", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters and assign them to values
                command.Parameters.Add("iSchedulerSettingsId", OracleDbType.Int32).Value = schedulerSettingsId;
                command.Parameters.Add("bEnabled", OracleDbType.Int32).Value = enabled;

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                return false;
            }
        }

        /// Create a new execution record
        public static int AddExecution(ISchedulerExecution schedulerExecution)
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_AddExecution", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters and assign them to values
                command.Parameters.Add("iSchedulerSettingsId", OracleDbType.Int32).Value = schedulerExecution.SchedulerSettingsId;
                command.Parameters.Add("dExecutionTimestamp", OracleDbType.Date).Value = schedulerExecution.ExecutionTimeStamp;
                command.Parameters.Add("iStatus", OracleDbType.Int32).Value = schedulerExecution.Status;

                // object returned
                command.Parameters.Add("iSchedulerExecutionId", OracleDbType.Int32, ParameterDirection.Output);
                int.TryParse(command.Parameters["iSchedulerExecutionId"].Value.ToString(), out int iSchedulerExecutionId);

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                command.ExecuteNonQuery();

                return iSchedulerExecutionId;
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        /// Update execution
        public static bool UpdateExecution(int iSchedulerExecutionId, DateTime? dExecutionTimeStamp, int iStatus)
        {
            OracleDbAccess dbAccess = new OracleDbAccess();
            OracleConnection oracleConnection;
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            OracleCommand command = new OracleCommand();

            try
            {
                // Get the connection
                oracleConnection = dbAccess.GetConnection();

                // Set the procedure name
                command = new OracleCommand("CPIO.SP_PIO_UpdateExecution", oracleConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters and assign them to values
                command.Parameters.Add("iSchedulerExecutionId", OracleDbType.Int32).Value = iSchedulerExecutionId;
                command.Parameters.Add("dExecutionTimeStamp", OracleDbType.Date).Value = dExecutionTimeStamp;
                command.Parameters.Add("iStatus", OracleDbType.Int32).Value = iStatus;

                // Open the connection
                dbAccess.OpenConnection(oracleConnection);

                // Execute procedure
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                return false;
            }
        }




    }
}
