using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BusinessLogicLibrary.Model
{
    /// Scheduler class joined with SchedulerSettings class
    public class Scheduler
    {
        /// Unique Id
        public int SchedulerId { get; set; }
        /// Scheduler name
        public string Name { get; set; }
        /// Scheduler description
        public string Description { get; set; }
        /// can be push, pull, inbound or outbound
        public int ActionTye { get; set; }
        /// This is used to relate to specific modules, example referrals in PIO
        public int TransactionType { get; set; }
        /// Is it a payer, a Bank, a distributor...
        public int PartnerType { get; set; }
        /// If it is a payer what is the PayerId...
        public int PartnerId { get; set; }
        /// Date & time the scheduler is created
        public DateTime CreationDate { get; set; }
        /// Date & time the scheduler should start
        public DateTime StartDate { get; set; }
        /// Date & time the scheduler should end
        public DateTime EndDate { get; set; }
        /// Recurrence frequency(one time, daily, weekly...)
        public int RecurrenceFrequency { get; set; }
        /// If the scheduler is enabled or not
        public bool Enabled { get; set; }
        
        /// Unique Scheduler settings Id
        public int SchedulerSettingsId { get; set; }
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
