using Scheduler.DataAccessLayer.Model;
using System;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// Scheduler that contains the upcoming schedulers to be executed
    public class SchedulerExecution : ISchedulerExecution
    {
        #region CONSTRUCTORS
        // Default constructor
        public SchedulerExecution() { }

        // Parameterized constructor
        public SchedulerExecution(int iSchedulerSettingsId, DateTime? dExecutionTimeStamp, int iStatus)
        {
            SchedulerSettingsId = iSchedulerSettingsId;
            ExecutionTimeStamp = dExecutionTimeStamp;
            Status = iStatus;
        }

        // Parameterized constructor
        public SchedulerExecution(int iSchedulerExecutionId, int iSchedulerSettingsId, DateTime? dExecutionTimeStamp, int iStatus)
        {
            SchedulerExecutionId = iSchedulerExecutionId;
            SchedulerSettingsId = iSchedulerSettingsId;
            ExecutionTimeStamp = dExecutionTimeStamp;
            Status = iStatus;
        }
        #endregion

        #region PROPERTIES
        /// Unique Id
        public int SchedulerExecutionId { get; set; }
        /// FK: TSchedulerSettings
        public int SchedulerSettingsId { get; set; }
        /// Date/Time a task should execute
        public DateTime? ExecutionTimeStamp { get; set; }
        /// Pending, executing, accomplished...
        public int Status { get; set; }
        #endregion
    }
}
