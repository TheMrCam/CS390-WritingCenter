using System;
using System.Collections;
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

            ArrayList workerList = accounts.GetDatabaseInformation();
            //Columns: String, Int, Int, String[], String[], Day, Day, Day, Day, Day, Day, Day

            //starting indexes within arraylist of accounts
            int NAME_INDEX = 0;
            int REQ_HR_INDEX = 1;
            int EXP_INDEX = 2;
            int MJRS_INDEX = 3;
            int MINR_INDEX = 4;
            int DAY_INDEX = 5;

            //subtractive
            foreach (Day day in schedule.Days)
            {
                int currentHour = 0;
                foreach (Day.Hour hour in day.Hours)
                {
                    if (hour.Open.Equals(true))
                    {
                        List<string> availibleWorkers = new List<string>();
                        foreach (ArrayList worker in workerList)
                        {
                            Day availibility = (Day)worker[DAY_INDEX];
                            if (availibility.GetHour(currentHour).Open)
                            {
                                availibleWorkers.Add((string)worker[NAME_INDEX]);
                            }
                        }

                        hour.setNames(availibleWorkers);
                    }

                    currentHour += 1;
                    
                }

                

            }

            //additive
            foreach (Day day in schedule.Days)
            {
                
            }




        }

    }
}
