using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.DataAccessLayer.Model
{
    public interface ISchedulerExecution
    {
        /// Unique Id
        int SchedulerExecutionId { get; set; }
        /// FK: TSchedulerSettings
        int SchedulerSettingsId { get; set; }
        /// Date/Time a task should execute
        DateTime? ExecutionTimeStamp { get; set; }
        /// Pending, executing, accomplished...
        int Status { get; set; }
    }
}
