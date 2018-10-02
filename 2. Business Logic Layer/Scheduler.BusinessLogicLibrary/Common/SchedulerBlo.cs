
using Scheduler.BusinessLogicLibrary.Common;
using Scheduler.BusinessLogicLibrary.Model;
using Scheduler.DataAccessLayer.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// Logic related to the scheduler service
    public static class SchedulerBlo
    {
        public static List<JobScheduler> GetDetailedActiveSchedulers()
        {
            List<JobScheduler> schedulerList = GetActiveSchedulers();
            List<SchedulerSettings> schedulerSettingsList = GetActiveSchedulerSettings();

            // Join the two lists using LINQ to get all the active schedulers and their corresponding settings
            schedulerList = schedulerList.GroupJoin(schedulerSettingsList,
            c => c.SchedulerId,
            b => b.SchedulerId,
            (c, b) =>
            {
                c.Settings = b.ToList();
                return c;
            }).ToList();

            return schedulerList;
        }

        public static List<JobScheduler> GetActiveSchedulers()
        {
            JobScheduler scheduler;
            List<JobScheduler> schedulers = null;
            DataSet dsSchedulers = SchedulerDao.GetActiveSchedulers();

            if (dsSchedulers != null)
            {
                if (dsSchedulers.Tables[0].Rows.Count > 0)
                {
                    schedulers = new List<JobScheduler>();
                    foreach (DataRow dr in dsSchedulers.Tables[0].Rows)
                    {
                        scheduler = new JobScheduler();

                        int.TryParse(dr["SchedulerId"].ToString(), out int iSchedulerId);
                        scheduler.SchedulerId = iSchedulerId;
                        scheduler.Name = dr["Name"].ToString();
                        scheduler.Description = dr["description"].ToString();
                        int.TryParse(dr["Actiontype"].ToString(), out int iActionTye);
                        scheduler.ActionTye = iActionTye;
                        int.TryParse(dr["TransactionType"].ToString(), out int iTransactionType);
                        scheduler.TransactionType = iTransactionType;
                        int.TryParse(dr["PartnerType"].ToString(), out int iPartnerType);
                        scheduler.PartnerType = iPartnerType;
                        int.TryParse(dr["PartnerId"].ToString(), out int iPartnerId);
                        scheduler.PartnerId = iPartnerId;
                        DateTime.TryParse(dr["CreationDate"].ToString(), out DateTime dCreationDate);
                        scheduler.CreationDate = dCreationDate;
                        DateTime.TryParse(dr["StartDate"].ToString(), out DateTime dStartDate);
                        scheduler.StartDate = dStartDate;
                        DateTime.TryParse(dr["EndDate"].ToString(), out DateTime dEndDate);
                        scheduler.EndDate = dEndDate;
                        int.TryParse(dr["RecurrenceFrequency"].ToString(), out int iRecurrenceFrequency);
                        scheduler.RecurrenceFrequency = iRecurrenceFrequency;
                        bool.TryParse(dr["Enabled"].ToString(), out bool bEnabled);
                        scheduler.Enabled = bEnabled;

                        // Add scheduler to the list
                        schedulers.Add(scheduler);
                    }
                }
            }
            return schedulers;
        }

        public static List<SchedulerSettings> GetActiveSchedulerSettings()
        {
            SchedulerSettings schedulerSettings;
            List<SchedulerSettings> schedulerSettingsList = null;
            DataSet dsSchedulerSettings = SchedulerDao.GetActiveSchedulerSettings();

            if (dsSchedulerSettings != null)
            {
                if (dsSchedulerSettings.Tables[0].Rows.Count > 0)
                {
                    schedulerSettingsList = new List<SchedulerSettings>();
                    foreach (DataRow dr in dsSchedulerSettings.Tables[0].Rows)
                    {
                        schedulerSettings = new SchedulerSettings();

                        int.TryParse(dr["SchedulerSettingsId"].ToString(), out int iSchedulerSettingsId);
                        schedulerSettings.SchedulerSettingsId = iSchedulerSettingsId;
                        int.TryParse(dr["SchedulerId"].ToString(), out int iSchedulerId);
                        schedulerSettings.SchedulerId = iSchedulerId;
                        DateTime.TryParse(dr["ExecutionTimeStamp"].ToString(), out DateTime dExecutionTime);
                        schedulerSettings.ExecutionTime = dExecutionTime;
                        int.TryParse(dr["HourlyRecurrence"].ToString(), out int iHourlyRecurrence);
                        schedulerSettings.HourlyRecurrence = iHourlyRecurrence;
                        int.TryParse(dr["DailyRecurrence"].ToString(), out int iDailyRecurrence);
                        schedulerSettings.DailyRecurrence = iDailyRecurrence;
                        int.TryParse(dr["WeeklyRecurrence"].ToString(), out int iWeeklyRecurrence);
                        schedulerSettings.WeeklyRecurrence = iWeeklyRecurrence;
                        int.TryParse(dr["SelectedDayOfWeek"].ToString(), out int iSelectedDayOfWeek);
                        schedulerSettings.SelectedDayOfWeek = iSelectedDayOfWeek;
                        int.TryParse(dr["SelectedMonth"].ToString(), out int iSelectedMonth);
                        schedulerSettings.SelectedMonth = iSelectedMonth;
                        int.TryParse(dr["SelectedDayOfMonth"].ToString(), out int iSelectedDayOfMonth);
                        schedulerSettings.SelectedDayOfMonth = iSelectedDayOfMonth;
                        bool.TryParse(dr["Enabled"].ToString(), out bool bEnabled);
                        schedulerSettings.Enabled = bEnabled;

                        // Add scheduler settings to the list
                        schedulerSettingsList.Add(schedulerSettings);
                    }
                }
            }
            return schedulerSettingsList;
        }

        public static bool SetSchedulerState(JobScheduler jobScheduler)
        {
            return SchedulerDao.SetSchedulerState(jobScheduler.SchedulerId, jobScheduler.Enabled);
        }

        public static bool SetSchedulerSettingState(SchedulerSettings settings)
        {
            return SchedulerDao.SetSchedulerSettingState(settings.SchedulerSettingsId, settings.Enabled);
        }

        public static List<SchedulerExecution> GetCurrentExecutions()
        {
            SchedulerExecution schedulerExecution;
            List<SchedulerExecution> schedulerExecutionList = null;
            DataSet dsSchedulerExecutions = SchedulerDao.GetCurrentExecutions();

            if (dsSchedulerExecutions != null)
            {
                if (dsSchedulerExecutions.Tables[0].Rows.Count > 0)
                {
                    schedulerExecutionList = new List<SchedulerExecution>();
                    foreach (DataRow dr in dsSchedulerExecutions.Tables[0].Rows)
                    {
                        schedulerExecution = new SchedulerExecution();

                        int.TryParse(dr["SchedulerExecutionId"].ToString(), out int iSchedulerExecutionId);
                        schedulerExecution.SchedulerExecutionId = iSchedulerExecutionId;
                        int.TryParse(dr["SchedulerSettingsId"].ToString(), out int iSchedulerSettingsId);
                        schedulerExecution.SchedulerSettingsId = iSchedulerSettingsId;

                        DateTime.TryParse(dr["ExecutionTimeStamp"].ToString(), out DateTime dExecutionTimeStamp);
                        schedulerExecution.ExecutionTimeStamp = dExecutionTimeStamp;
                        int.TryParse(dr["Status"].ToString(), out int iStatus);
                        schedulerExecution.Status = iStatus;

                        // Add scheduler settings to the list
                        schedulerExecutionList.Add(schedulerExecution);
                    }
                }
            }
            return schedulerExecutionList;
        }

        public static List<SchedulerLog> GetLatestExecutionLogs()
        {
            SchedulerLog schedulerExecutionLog;
            List<SchedulerLog> schedulerExecutionLogs = null;
            DataSet dsSchedulerExecutionLogs = SchedulerDao.GetLatestExecutionLogs();

            if (dsSchedulerExecutionLogs != null)
            {
                if (dsSchedulerExecutionLogs.Tables[0].Rows.Count > 0)
                {
                    schedulerExecutionLogs = new List<SchedulerLog>();
                    foreach (DataRow dr in dsSchedulerExecutionLogs.Tables[0].Rows)
                    {
                        schedulerExecutionLog = new SchedulerLog();

                        int.TryParse(dr["SchedulerLogId"].ToString(), out int iSchedulerLogId);
                        schedulerExecutionLog.SchedulerLogId = iSchedulerLogId;
                        int.TryParse(dr["SchedulerExecutionId"].ToString(), out int iSchedulerExecutionId);
                        schedulerExecutionLog.SchedulerExecutionId = iSchedulerExecutionId;
                        int.TryParse(dr["SchedulerSettingsId"].ToString(), out int iSchedulerSettingsId);
                        schedulerExecutionLog.SchedulerSettingsId = iSchedulerSettingsId;
                        int.TryParse(dr["SchedulerId"].ToString(), out int iSchedulerId);
                        schedulerExecutionLog.SchedulerId = iSchedulerId;
                        schedulerExecutionLog.Name = dr["Name"].ToString();
                        int.TryParse(dr["ActionTye"].ToString(), out int iActionTye);
                        schedulerExecutionLog.ActionTye = iActionTye;
                        int.TryParse(dr["TransactionType"].ToString(), out int iTransactionType);
                        schedulerExecutionLog.TransactionType = iTransactionType;
                        int.TryParse(dr["PartnerType"].ToString(), out int iPartnerType);
                        schedulerExecutionLog.PartnerType = iPartnerType;
                        int.TryParse(dr["PartnerId"].ToString(), out int iPartnerId);
                        schedulerExecutionLog.PartnerId = iPartnerId;
                        DateTime.TryParse(dr["ExecutionTimeStamp"].ToString(), out DateTime dExecutionTimeStamp);
                        schedulerExecutionLog.ExecutionTimeStamp = dExecutionTimeStamp;
                        schedulerExecutionLog.Content = dr["Content"].ToString();
                        int.TryParse(dr["Status"].ToString(), out int iStatus);
                        schedulerExecutionLog.Status = iStatus;

                        // Add log to the list
                        schedulerExecutionLogs.Add(schedulerExecutionLog);
                    }
                }
            }
            return schedulerExecutionLogs;
        }


        /// <summary>
        /// Get upcoming scheduler execution
        /// </summary>
        /// <param name="iRecurrenceFrequency"></param>
        /// <param name="dLastExecution"></param>
        /// <param name="dLastLoggedExecution"></param>
        /// <param name="oSchedulerSettings"></param>
        /// <param name="iRecordActionStatus"></param>
        /// <returns></returns>
        public static DateTime? GetUpcomingSchedulerExecution(int iRecurrenceFrequency, ref SchedulerExecution oExecution, DateTime? dLastLoggedExecution,
                                                              ref SchedulerSettings oSchedulerSettings, ref int iRecordActionStatus)
        {
            DateTime? dtReturnValue = null;
            TimeSpan settingExecutionTime = oSchedulerSettings.ExecutionTime.TimeOfDay;
            switch (iRecurrenceFrequency)
            {
                case (int)Enumerations.RecurrenceFrequency.OneTime:
                    #region commented
                    /*if (DateTime.Now < oSchedulerSettings.ExecutionTime)
                        dtReturnValue = oSchedulerSettings.ExecutionTime;
                    else
                    {
                        oSchedulerSettings.Enabled = false;
                        return null;
                    }*/
                    #endregion
                    break;

                case (int)Enumerations.RecurrenceFrequency.Daily:

                    int dailyRecurrence = oSchedulerSettings.DailyRecurrence;
                    if (oExecution.ExecutionTimeStamp != null)
                    {
                        // If last execution > now then it is pending
                        if (oExecution.ExecutionTimeStamp > DateTime.Now)
                        {
                            // Flag that indicates that no new execution should be inserted in TPioSchedulerExecution
                            iRecordActionStatus = (int)Enumerations.RecordActionStatus.Keep;

                            dtReturnValue = oExecution.ExecutionTimeStamp;
                        }
                        else
                        {
                            // If the execution is completed update the execution time, else keep
                            if (oExecution.Status == (int)Enumerations.Status.Completed)
                            {
                                // Flag that indicates that a new execution should replace the old one in TPioSchedulerExecution
                                iRecordActionStatus = (int)Enumerations.RecordActionStatus.Update;

                                // Add daily recurrence to the last execution
                                dtReturnValue = oExecution.ExecutionTimeStamp.Value.AddDays(dailyRecurrence);
                                // If dtReturnValue > now return it, else calculate the nearest timestamp
                                if (dtReturnValue < DateTime.Now)
                                {
                                    if (DateTime.Now.TimeOfDay < settingExecutionTime)
                                        dtReturnValue = DateTime.Today.Add(settingExecutionTime);
                                    else
                                        dtReturnValue = DateTime.Today.AddDays(1).Add(settingExecutionTime);
                                }
                            }
                            else
                            {
                                iRecordActionStatus = (int)Enumerations.RecordActionStatus.Keep;
                            }
                        }
                    }
                    else
                    {
                        // Flag that indicates that a new execution should be inserted in TPioSchedulerExecution
                        iRecordActionStatus = (int)Enumerations.RecordActionStatus.Insert;

                        // If no execution found, refer to the log
                        if (dLastLoggedExecution != null)
                        {
                            dtReturnValue = dLastLoggedExecution.Value.AddDays(dailyRecurrence);
                            // If dtReturnValue > now return it, else calculate the nearest timestamp
                            if (dtReturnValue < DateTime.Now)
                            {
                                if (DateTime.Now.TimeOfDay < settingExecutionTime)
                                    dtReturnValue = DateTime.Today.Add(settingExecutionTime);
                                else
                                    dtReturnValue = DateTime.Today.AddDays(1).Add(settingExecutionTime);
                            }
                        }
                        else
                        {
                            // No past execution found, calculate the nearest timestamp
                            if (DateTime.Now.TimeOfDay < settingExecutionTime)
                                dtReturnValue = DateTime.Today.Add(settingExecutionTime);
                            else
                                dtReturnValue = DateTime.Today.AddDays(1).Add(settingExecutionTime);
                        }
                    }
                    break;

                case (int)Enumerations.RecurrenceFrequency.Weekly:
                    break;

                case (int)Enumerations.RecurrenceFrequency.Monthly:
                    break;

                default:
                    break;
            }


            return dtReturnValue;
        }

        public static bool CreateExecution(ref SchedulerExecution execution)
        {
            int iSchedulerExecutionId = SchedulerDao.AddExecution(execution);

            if (iSchedulerExecutionId != 0)
            {
                execution.SchedulerExecutionId = iSchedulerExecutionId;
                return true;
            }
            else
                return false;
        }

        public static bool UpdateExecution(SchedulerExecution execution)
        {
            return SchedulerDao.UpdateExecution(execution.SchedulerExecutionId, execution.ExecutionTimeStamp, execution.Status);
        }

    }
}