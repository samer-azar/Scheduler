using System;

namespace Scheduler.BusinessLogicLibrary.Common
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
        /// Occurs every x hours
        public int HourlyRecurrence { get; set; }
        /// Occurs every x days
        public int DailyRecurrence { get; set; }
        /// Occurs every x weeks
        public int WeeklyRecurrence { get; set; }
        /// Day of week to be selected
        public int SelectedDayOfWeek { get; set; }
        /// Months to be selected
        public int SelectedMonth { get; set; }
        /// Day of month to be selected(1,2,...31,Last Day)
        public int SelectedDayOfMonth { get; set; }
    }

}
