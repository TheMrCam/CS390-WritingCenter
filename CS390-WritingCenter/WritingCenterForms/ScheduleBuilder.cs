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
        public void buildSchedule(Schedule schedule, bool shiftInRow = true, bool expMix = false, bool majMix = false, int hrReqMargErr = 2)
        {
            string[] workerList = accounts.AccountNamesList();
            //string[] workerList = new string[1];
            foreach (Day day in schedule.Days)
            {
                foreach (Day.Hour hour in day.Hours)
                {
                    hour.setNames(workerList);
                }
            }
        }

    }
}
