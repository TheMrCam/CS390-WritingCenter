using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal class ScheduleBuilder
    {
        private AccountDatabase accounts;

        public ScheduleBuilder(AccountDatabase accounts)
        {
            this.accounts = accounts;
        }
                                                       //not implemented,        not implemented,     not implemented,     not implemented
        public Schedule buildSchedule(Schedule schedule, bool shiftInRow = true, bool expMix = false, bool majMix = false, int hrReqMargErr = 2)
        {
            return schedule;
        }

    }
}
