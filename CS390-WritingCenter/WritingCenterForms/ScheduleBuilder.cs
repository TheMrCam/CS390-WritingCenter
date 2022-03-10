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


        //
        // Takes in an already initialized schedule, and an integer N representing the maximum number of shifts allowed in a row
        // Returns nothing, edits schedule passed in
        //
        public void buildSchedule(Schedule schedule,int N)
        {
            string[] workerList = accounts.AccountNamesList(); // a list of the names of all workers

            int currentDay = 0;                                // for indexing into days
            foreach(Day day in schedule.Days)
            {
                int currentHour = 0;                           // for indexing into hours
                foreach(Day.Hour hour in day.Hours)
                {
                    if (hour.Availible)                        // if the writing center is open this hour
                    {
                        List<Account> availibleWorkers = new List<Account>(); // initialize list of workers availible for shift 
                        
                        foreach(string worker in workerList)
                        {
                            Account acctViewing = accounts.GetAccount(worker,true);
                            
                            if (acctViewing != null && acctViewing.Availability(currentDay).GetHour(currentHour).Availible) // if acct is not null and user is availible,
                            { availibleWorkers.Add(acctViewing); }                                                          // add into possible workers for the shift

                        }

                        while (availibleWorkers.Count > hour.maxWorkers)                                                    //while there is more than the defined number of max workers per shift
                        {
                            List<Account> nonZeroHours = new List<Account>(availibleWorkers.Where(a => a.currentWorkedHours != 0)); // list of accounts who are working more than 0 hours (possible to remove)
                            List<Account> ZeroHours = new List<Account>(availibleWorkers.Where(a => a.currentWorkedHours == 0)); // list of accounts who are NOT working ANY hours (impossible to remove)
                            availibleWorkers.Clear();                                                       // reset availible workers
                            if (currentHour>0)                                                              // arrr, there be subtraction ahead. no negative hours allowed
                            {
                                foreach(Account acct in nonZeroHours)                                       // for all accounts currently working non-zero hours
                                {
                                    if (previousShiftsWorked(acct, schedule, currentDay, currentHour)>=N) { nonZeroHours.Remove(acct); } // if their shifts in a row exceed N, remove from the pool of possible workers
                                }
                                while(nonZeroHours.Count+ZeroHours.Count > hour.maxWorkers)                 // while the total number of workers is more than the max number of workers
                                {
                                    nonZeroHours = removeAWorker_WorkedLastShift(nonZeroHours,currentDay,currentHour,schedule); // remove a worker if they did not work last shift
                                }
                            }
                            availibleWorkers.AddRange(ZeroHours);                                           // re add workers to availible workers 
                            availibleWorkers.AddRange(nonZeroHours);
                        }
                        string[] namesToAdd = new string[availibleWorkers.Count];                           // initialize collection of strings for final list of names
                        int i = 0;                                                                  // current index of list
                        foreach(Account worker in availibleWorkers)
                        {
                            worker.currentWorkedHours = worker.currentWorkedHours + 1;          // add hour to the worker's current worked hours
                            namesToAdd.SetValue(worker.Name, i);                                    // add to list of names to add
                            i++;                                                         // increment index
                        }
                        hour.setNames(namesToAdd); // set names of workers to the availible workers we found 
                    }
                    currentHour++;               // move on to the next hour 
                }
                currentDay++;         //move on to the next day 
            }

            List<string> noHours = new List<string>();
            foreach(string name in workerList)      // checking if all workers are scheduled for at least one shift
            {
                if (accounts.getCurrentWorkedHours(name) == 0)
                {
                    noHours.Add(name);
                }
            }
            if (noHours.Count > 0)
            {
                throw new Exception(noHours.Count() + "worker(s) have no scheduled hours");
            }
        }


        //********************************************************************************************************************************************************************************
        // END OF MAIN FUNCTION
        //********************************************************************************************************************************************************************************


        // HELPER FUNCTIONS 


        //
        // Takes in an account list of length n, an integer for the current day, an integer for the current hour, and a schedule object
        // Returns an account list which has length n-1, with the removed object a worker who did not work on the previous shift if
        //         possible, and the last worker added if impossible.
        //
        private List<Account> removeAWorker_WorkedLastShift(List<Account> unsortedAcctList, int currentDay, int currentHour, Schedule schedule)
        {
            
            List<Account> sortedAcctList = new List<Account>(); // initialize list to return 


            foreach( Account account in unsortedAcctList)
            {
                if (workedLastShift(account,schedule,currentDay,currentHour)) 
                {
                    sortedAcctList.Prepend(account); // if account worked during the last shift, add to front of list
                }
                else { sortedAcctList.Append(account); } // if account did not work previous shift, add to end of list

            }
            
            return ((List<Account>)sortedAcctList.Take(sortedAcctList.Count-1)); // return the whole list except the last element
        }


        //
        // Takes in an account, an integer for the current day, an integer for the current hour, and a schedule object
        // Returns a boolean representing if the worker in account worked the previous shift
        //
        private bool workedLastShift(Account account, Schedule schedule,int currentDay, int currentHour)
        {

            foreach(string name in schedule.getWorkers(currentHour - 1, currentDay)) // for all names in the list of names who worked last hour
            {
                if (account.Name == name){ return true; }                           // check if it is the name of the account, if so return true
            }
            return false;                                                           // else return false
        }


        //
        // Takes in an account, an integer for the current day, an integer for the current hour, and a schedule object
        // Returns an integer representing the number of previous consecutive hours worked 
        //
        private int previousShiftsWorked(Account acct, Schedule schedule, int currentDay, int currentHour)
        {
            int shiftsWorked = 0;
            int localHour = currentHour;  // done to prevent any accidental editing of currenthour 

            while (localHour>0 && workedLastShift(acct, schedule, currentDay, currentHour)) // while local hour is > 0 and the worker worked the last shift
            { shiftsWorked++; localHour--; } // add one to previous shifts worked and check the shift before it by going back an hour locally

            return shiftsWorked; // return integer of previous consecutive hours worked
        }
    }
}
