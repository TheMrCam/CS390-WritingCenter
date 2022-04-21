using System;
using System.Collections.Generic;
using System.Linq;


namespace WritingCenterForms
{
    internal class ScheduleBuilder
    {
        private AccountDatabase accounts;
        private int TOLERANCE = 4;

        public ScheduleBuilder(AccountDatabase accounts)
        {
            this.accounts = accounts;
        }

        // ********************************************************************************************************************************************************************************
        // MAIN FUNCTION
        //    Takes in an already initialized schedule and number of consecutive hours allowed
        //    Returns a schedule which attempts to meet settings of the input schedule
        // ********************************************************************************************************************************************************************************


        public Schedule buildSchedule(Schedule currentSched, int N)
        {
            Schedule newSched = new Schedule(accounts, currentSched.sView);
            string[] workerList = accounts.AccountNamesList();
            List<string> settings = currentSched.settings;
            foreach(string i in settings) { Console.WriteLine(i); }
            foreach(string s in workerList) { accounts.GetAccount(s, true).currentWorkedHours = 0; }
            
            for (int currentday = 0; currentday < currentSched.Days.Count() - 1; currentday++)
            {
                for (int currentHour = 0; currentHour < currentSched.Days[currentday].Hours.Count() - 1; currentHour++)
                {
                    if (currentSched.Days[currentday].Hours[currentHour].Availible)                        // if the writing center is open this hour
                    {
                        List<Account> possibleWorkers = new List<Account>();
                        List<string> availibleWorkers = new List<string>();

                        foreach (string worker in workerList)
                        {
                            Account acctViewing = accounts.GetAccount(worker, true);

                            if (acctViewing.hasAvail && acctViewing.Availability(currentday).GetHour(currentHour).Availible) // if acct availibility is not null and user is availible,
                            {
                                availibleWorkers.Add(worker);
                                if (previousShiftsWorked(acctViewing, newSched, currentday, currentHour) < N && acctViewing.currentWorkedHours-acctViewing.RequestedHours<TOLERANCE)
                                { possibleWorkers.Add(acctViewing); }
                                
                            }                                                          // add into possible workers for the shift
                        }

                        List<Account> zeroHoursWorked = new List<Account>();
                        List<Account> nonZeroHoursWorked = new List<Account>();

                        foreach(Account account in possibleWorkers)
                        {
                            if (account.currentWorkedHours == 0) { zeroHoursWorked.Add(account); }
                            else { nonZeroHoursWorked.Add(account);}
                        }

                        possibleWorkers.Clear();
                        
                        while (zeroHoursWorked.Count + nonZeroHoursWorked.Count > currentSched.Days[currentday].Hours[currentHour].maxWorkers && currentSched.Days[currentday].Hours[currentHour].maxWorkers > 0)
                        {
                            if (nonZeroHoursWorked.Count < 1 && zeroHoursWorked.Count > 0)
                            { zeroHoursWorked.RemoveAt(zeroHoursWorked.Count - 1); }

                            else if (nonZeroHoursWorked.Count != 0)
                            { 
                                nonZeroHoursWorked = removeAWorker_WorkedLastShift(nonZeroHoursWorked,currentday,currentHour,currentSched); 
                            }

                            else { break; }
                        }
                        
                        if (zeroHoursWorked.Count > 0 | nonZeroHoursWorked.Count > 0)
                        {
                            possibleWorkers.AddRange(zeroHoursWorked);
                            possibleWorkers.AddRange(nonZeroHoursWorked);
                        }

                        possibleWorkers = alphebetiseAccounts(possibleWorkers);
                        
                        string[] namesToAdd = new string[possibleWorkers.Count];                    // initialize collection of strings for final list of names
                        int i = 0;                                                                  // current index of list
                        foreach (Account worker in possibleWorkers)
                        { 
                            worker.currentWorkedHours++;                                            // add hour to the worker's current worked hours
                            namesToAdd.SetValue(worker.Name, i);                                    // add to list of names to add
                            i++;      
                        }

                        newSched.editDays(currentday, currentHour, namesToAdd); // set names of workers to the availible workers we found
                    }
                }
            }

            List<string> zeroHours = new List<string>();
            List<string> underReqHours = new List<string>();
            List<string> overReqHours = new List<string>();
            foreach(String A in workerList)
            {
                Account temp = accounts.GetAccount(A, true);
                if (temp != null && !temp.RequestedHours.Equals(temp.currentWorkedHours) && temp.RequestedHours > temp.currentWorkedHours)
                {
                    if (temp.currentWorkedHours == 0) { zeroHours.Add(A); }
                    else { underReqHours.Add(A); }
                }
                else { overReqHours.Add(A); }
            }

            newSched.settings = settings;
            newSched.settings.Add("ZERO");
            newSched.settings.AddRange(zeroHours);
            newSched.settings.Add("UNDER");
            newSched.settings.AddRange(underReqHours);
            newSched.settings.Add("OVER");
            newSched.settings.AddRange(overReqHours);

            return (newSched);
        }


        //********************************************************************************************************************************************************************************
        // END OF MAIN FUNCTION
        //********************************************************************************************************************************************************************************

        //------------------------
        // HELPER FUNCTIONS 
        //------------------------


        //
        // Takes in an account list of length n, an integer for the current day, an integer for the current hour, and a schedule object
        // Returns an account list which has length n-1, with the removed object a worker who did not work on the previous shift if
        //         possible, and the last worker added if impossible.
        //
        private List<Account> removeAWorker_WorkedLastShift(List<Account> unsortedAcctList, int currentDay, int currentHour, Schedule schedule)
        {
            if (unsortedAcctList.Count > 1)
            { 
                List<Account> sortedAcctList = new List<Account>(); // initialize list to return 


                foreach( Account account in unsortedAcctList)
                {
                    if (workedLastShift(account,schedule,currentDay,currentHour)) 
                    {
                        sortedAcctList = sortedAcctList.Prepend(account).ToList(); // if account worked during the last shift, add to front of list
                    }
                    else { sortedAcctList = sortedAcctList.Append(account).ToList(); } // if account did not work previous shift, add to end of list
                }
                sortedAcctList.RemoveAt(sortedAcctList.Count - 1);
                return sortedAcctList; // return the whole list except the last element
            }
            return unsortedAcctList;
            
        }


        //
        // Takes in an account, an integer for the current day, an integer for the current hour, and a schedule object
        // Returns a boolean representing if the worker in account worked the previous shift
        //
        private bool workedLastShift(Account account, Schedule schedule,int currentDay, int currentHour)
        {
            if (currentHour >= 1 && schedule.getWorkers(currentHour - 1, currentDay) != null)
            {
                string[] workers = schedule.getWorkers(currentHour - 1, currentDay);
                foreach (string name in workers)
                {
                    if (account.Name == name){ return true; } 
                }
                                          // check if it is the name of the account, if so return true
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


        //
        // Takes in an unsorted account list
        // Returns list sorted based on name
        //

        private List<Account> alphebetiseAccounts( List<Account> unsortedAcctList)
        {
            List<Account> sortedAcctOrderedList = unsortedAcctList.OrderBy(x => x.Name).ToList();
            List<Account> sortedAcctList = new List<Account>();

            foreach(Account account in sortedAcctOrderedList)
            { sortedAcctList.Add(account); }

            return sortedAcctList;
        }

        //
        // Takes in unsorted list of accounts
        // Returns list of accounts minus one account
        // removes highest non-duplicate account
        // Removes highest duplicate unless would put out of ratio
        //

        private List<Account> removeAWorker_ExpMix(List<Account> oldList)
        {
            List<IGrouping<int, Account>> dictExp = oldList.GroupBy(x => x.Semesters).ToList();
            foreach(IGrouping<int, Account> group in dictExp)
            {
                foreach(Account a in group)
                {
                    Console.WriteLine(a.Name, a.Semesters);
                }
            }
            return oldList;
        }
    }
}
