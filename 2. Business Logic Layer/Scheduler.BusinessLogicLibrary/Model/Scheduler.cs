using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.ClassLibrary.Model
{
    /// Main scheduler
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
        public int PartnerId { get; set; }
        /// If it is a payer what is the PayerId...
        public int RefID { get; set; }
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
        public SchedulerSettings Settings { get; set; }
    }
}
