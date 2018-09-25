using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.ClassLibrary.Model
{
    /// Scheduler that contains the upcoming schedulers to be executed
    public class SchedulerExecution
    {
        /// Unique Id
        public int SchedulerExecutionId { get; set; }
        /// FK: TScheduler
        public int SchedulerId { get; set; }
        /// Date/Time a task should execute
        public DateTime ExecutionTime { get; set; }
        /// Pending, executing, accomplished...
        public int Status { get; set; }
    }
}
