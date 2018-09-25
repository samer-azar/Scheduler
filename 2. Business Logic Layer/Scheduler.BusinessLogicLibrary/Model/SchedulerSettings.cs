using Scheduler.ClassLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.ClassLibrary.Model
{
    /// Detailed settings of a scheduler
    public class SchedulerSettings
    {
        /// Unique Id
        public int SchedulerSettingsId { get; set; }
        /// FK: TScheduler
        public int SchedulerId { get; set; }
        /// Execution time
        public DateTime ExecutionTime { get; set; }
    }

    /// Daily scheduler settings
    public class DailySchedulerSettings : SchedulerSettings
    {
        /// Occurs every x days
        public int DailyRecurrence { get; set; }
    }

    /// Weekly scheduler settings
    public class WeeklySchedulerSettings : SchedulerSettings
    {
        /// Occurs every x weeks
        public int WeeklyRecurrence { get; set; }
        /// Days of week to be selected
        public List<DayOfWeek> DaysOfWeek { get; set; }
    }

    /// Monthly scheduler settings
    public class MonthlySchedulerSettings : SchedulerSettings
    {
        /// Months to be selected
        public List<Enumerations.Month> Months { get; set; }
        /// Days of month to be selected(1,2,...31,Last Day)
        public List<object> DaysOfMonth { get; set; }
    }

}
