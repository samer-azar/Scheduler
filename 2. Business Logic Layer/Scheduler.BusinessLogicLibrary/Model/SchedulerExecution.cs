using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// Scheduler that contains the upcoming schedulers to be executed
    public class SchedulerExecution
    {
        // Default constructor
        public SchedulerExecution() { }

        // Parameterized constructor
        public SchedulerExecution(int iSchedulerSettingsId, DateTime dExecutionTimeStamp, int iStatus)
        {
            SchedulerSettingsId = iSchedulerSettingsId;
            ExecutionTimeStamp = dExecutionTimeStamp;
            Status = iStatus;
        }

        // Parameterized constructor
        public SchedulerExecution(int iSchedulerExecutionId, int iSchedulerSettingsId, DateTime dExecutionTimeStamp, int iStatus)
        {
            SchedulerExecutionId = iSchedulerExecutionId;
            SchedulerSettingsId = iSchedulerSettingsId;
            ExecutionTimeStamp = dExecutionTimeStamp;
            Status = iStatus;
        }

        /// Unique Id
        public int SchedulerExecutionId { get; set; }
        /// FK: TSchedulerSettings
        public int SchedulerSettingsId { get; set; }
        /// Date/Time a task should execute
        public DateTime ExecutionTimeStamp { get; set; }
        /// Pending, executing, accomplished...
        public int Status { get; set; }
    }
}
