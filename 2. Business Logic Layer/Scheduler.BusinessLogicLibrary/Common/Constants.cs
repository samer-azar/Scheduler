using Scheduler.LoggerLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// Constants
    public class Constants 
    {
        

    }

    /// Enumerations
    public class Enumerations
    {
        public enum RecurrenceFrequency
        {
            OneTime = 1,
            Daily = 2,
            Weekly = 3,
            Monthly = 4
        }

        public enum Month
        {
            NotSet = 0,
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        public enum PartnerType
        {
            Bank = 1,
            Payer = 2,
            Sprovider = 3,
            NApplicable = 4,
            Distributor = 5,
            Reinsurer = 6,
            HealthProvider = 7
        }

        public enum ActionType
        {
            Push = 1,
            Pull = 2,
            Inbound = 3,
            Outbound = 4
        }

        public enum ExecutionStatus
        {
            Scheduled = 1,
            Sending = 2,
            Completed = 3,
            Cancelled = 4,
            Failed = 5
        }

        public enum RecordActionStatus
        {
            Keep = 1,
            Insert = 2,
            Update = 3,
            Delete = 4
        }

    }
}
