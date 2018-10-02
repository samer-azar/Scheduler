using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// Log model
    public class SchedulerLog
    {
        /// PK: Unique Id
        public int SchedulerLogId { get; set; }
        /// FK: TSchedulerExecution
        public int SchedulerExecutionId { get; set; }
        /// FK: TSchedulerSettings
        public int SchedulerSettingsId { get; set; }
        /// FK: TScheduler
        public int SchedulerId { get; set; }
        /// Scheduler name
        public string Name { get; set; }
        /// can be push, pull, inbound or outbound
        public int ActionTye { get; set; }
        /// This is used to relate to specific modules, example referrals in PIO
        public int TransactionType { get; set; }
        /// Is it a payer, a Bank, a distributor...
        public int PartnerType { get; set; }
        /// If it is a payer what is the PayerId...
        public int PartnerId { get; set; }
        /// Timestamp
        public DateTime ExecutionTimeStamp { get; set; }
        /// Content(CLOB in DB)
        public object Content { get; set; }
        /// Status
        public int Status { get; set; }
    }
}
