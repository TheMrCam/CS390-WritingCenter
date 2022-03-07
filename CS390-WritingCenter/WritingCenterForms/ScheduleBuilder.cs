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

            string[] workerList = accounts.AccountNamesList(); // list of worker names
            
            // subtractive method
            // add all workers to all shifts theyve marked availible until they hit their number of requested hours, then remove based on difference between requested hours and currently scheduled hours

            int currentDay = 0;
            foreach (Day day in schedule.Days)
            {
                int currentHour = 0;
                foreach (Day.Hour hour in day.Hours)
                {
                    if (hour.Availible) // if open that hour on that day
                    {
                        List<Account> availibleWorkers = new List<Account>(); // initialize list of workers marked as availible
                        foreach (string worker in workerList)
                        {
                            Account accountViewing = accounts.GetAccount(worker, true); // find account using name from workerList

                            if (accountViewing.Availability(currentDay).GetHour(currentHour).Availible && accountViewing.currentWorkedHours<accountViewing.RequestedHours) // If marked as avaible and not at limit of hours 
                            {
                                availibleWorkers.Add(accountViewing);   // add to list of workers who can work shift
                                accounts.setCurrentWorkedHours(worker, accounts.getCurrentWorkedHours(worker) + 1); // increase number of hours worker is working
                                
                            }
                      
                        }

                        while (schedule.Days[currentDay].GetHour(currentHour).maxWorkers < availibleWorkers.Count) // While # of workers in list is greater than max num of workers
                        {
                            availibleWorkers = removeAWorkerReqCurrent(availibleWorkers); // remove a worker based on lowest difference between requested and current hours
                                                                                          // those with more hours requested but less scheduled will be prioritized
                        }

                        string[] availibleWorkersNames = (string[])(from worker in availibleWorkers select worker.Name);    // fetch names of avalible workers

                        hour.setNames(availibleWorkersNames);    // set list of names for that hour to the list of availible people

                    }
                    currentHour += 1;   // Increment Hour Index for finding hour in availibility

                }

                currentDay += 1;    // Increment Day Index for finding day in availibility

            }



        }

        private List<Account> removeAWorkerReqCurrent(List<Account> unsortedAcctList)
        {
            List<Account> sortedAcctList= new List<Account>();

            sortedAcctList = (List<Account>)unsortedAcctList.OrderByDescending(a => a.RequestedHours - a.currentWorkedHours).Take(unsortedAcctList.Count- 1);

            return sortedAcctList;
        }

    }
}
