using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    public class Day
    {
        private const int Slots = 24;
        public enum daynames
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        };
        public struct Hour
        //Keeps the open bool and parameter string[] linked together in array of Hours[]
        {
            private bool availible;
            private string[] names;
            public int minWorkers, maxWorkers;
            public bool Availible { get { return availible; } set { availible = value; } }
            public string[] Names { get { return names; } set { names = value; } }
            public Hour(bool available, string[] workers = null)
            {
                this.availible = available;
                if (available)
                {
                    minWorkers = 1;
                    maxWorkers = 4;
                }
                else { minWorkers = 0; maxWorkers = 0; }
                this.names = workers;
            }
            public string[] getNames()
            {
                return names;
            }
            public void setNames(string[] newNames)
            {
                this.names = newNames;
            }

            public void setNames(List<string> newNames)
            {
                string[] addedNames = new string[newNames.Count];
                for (int i = 0; i < newNames.Count; i++)
                {
                    addedNames[i] = newNames[i];
                }
                this.names = addedNames;
            }
        }
        //public static int SlotSize { get { return SlotSize; } set { if (value == 15 || value == 20 || value == 30 || value == 60) { SlotSize = value; } else { SlotSize = 60; } } } //15, 20, 30, or 60 minute slots; default: 60
        private Hour[] hours;
        public Hour[] Hours { get { return hours; } set { hours = value;} }
        public Day()
        {
            Hours = new Hour[Slots];
        }
        public Day(int open, int close)
        //Constructs day based on opening to closing hours (24 hour time, midnight = 0)
        {
            Hours = new Hour[Slots];
            for(int i = 0;i<Hours.Length;i++)
            {
                if(i >= open && i < close)
                {
                    Hours[i] = new Hour(true); //open hours
                } 
                else
                {
                    Hours[i] = new Hour(false); //closed hours
                }
            }
        }
        public Day(bool[] available, string[][] names)
        {
            if(available.Length != Slots || names.Length != Slots) //For now, hardcoded 1 hour time slots
            {
                throw new ArgumentException();
            }
            else
            {
                Hours = new Hour[Slots];
                for(int i = 0;i<Hours.Length;i++)
                {
                    Hours[i] = new Hour(available[i],names[i]);
                }
            }
        }

        public Hour GetHour(int whichOne) { return hours[whichOne]; }

        public void EditHour(int hour, bool available, string[] names)
        {
            Hours[hour].Availible = available;
            Hours[hour].Names = names;
        }

        public string PrintableDay()
        {
            string daystring = "[ ";
            for(int i = 0; i < Slots; i++)
            {
                daystring += Hours[i].Availible ? "1" : "0";
                daystring += ": ";
                if (Hours[i].Names != null)
                {
                    foreach (string name in Hours[i].Names)
                    {
                        daystring += name + " ";
                    }
                    daystring += " | ";
                }
            }
            daystring += "]";
            return daystring;
        }
    
    }
}
