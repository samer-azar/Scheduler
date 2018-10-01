using System;
using System.Collections.Generic;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// Main scheduler
    public class JobScheduler
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
        /// Scheduler settings
        public List<SchedulerSettings> Settings { get; set; }
    }
}
