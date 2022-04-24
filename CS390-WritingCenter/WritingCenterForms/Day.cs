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
        private Hour[] hours;
        public Hour[] Hours { get { return hours; } set { hours = value;} }
        
        //
        //*********************************************************************************************************
        // HOUR STRUCT
        //*********************************************************************************************************
        //
        public struct Hour
        //Keeps the open bool and parameter string[] linked together in array of Hours[]
        {
            private bool availible;
            private string[] names;
            public int minWorkers, maxWorkers;
            public bool Busy;

            public bool Availible { get { return availible; } set { availible = value; } }
            public string[] Names { get { return names; } set { names = value; } }

            //
            // Constructs an hour based on if it is open (availible) and a string of workers
            //
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
                this.Busy = false;
            }

            //
            // Constructs hour based on if it is open(availible), minimum and maxmimum workers, busy indicator, and initializes blank names.
            //
            public Hour(bool open, int min, int max, bool busy)
            {
                this.availible=open;
                this.minWorkers = min;
                this.maxWorkers = max;
                this.Busy = busy;
                this.names = null;
            }

            //
            // Overwrites hour settings based on input without overwriting names
            //
            public void overwriteSettings(bool open,int min,int max,bool busy)
            {
                this.availible = open;
                this.minWorkers = min;
                this.maxWorkers = max;
                this.Busy = busy;
            }
        
        }


        //
        //*********************************************************************************************************
        // Day Main Constructor
        //*********************************************************************************************************
        //

        //
        // Constructs day based on opening to closing hours (24 hour time, midnight = 0)
        //
        public Day(int open, int close)
        {
            Hours = new Hour[Slots];
            for(int i = 0;i<Hours.Length;i++)
            {
                if (i >= open && i < close)
                { Hours[i] = new Hour(true); } //open hours

                else
                { Hours[i] = new Hour(false); } //closed hours 
            }
        }

        //
        // Constructs a day based on when it is open (Availible)
        //
        public Day(bool[] available)
        {
            if (available.Length != Slots) //For now, hardcoded 1 hour time slots
            {
                throw new ArgumentException();
            }
            else
            {
                Hours = new Hour[Slots];
                for (int i = 0; i < Hours.Length; i++)
                {
                    Hours[i] = new Hour(available[i]);
                }
            }
        }

        //
        // Constructs a new Day, with empty names
        //
        public Day(bool[] openHours, int[] minWorkers, int[] maxWorkers, bool[] busyHours)
        
        {
            if (openHours.Length != Slots) //For now, hardcoded 1 hour time slots
            {
                throw new ArgumentException();
            }
            else
            {
                Hours = new Hour[Slots];
                for (int i = 0; i < Hours.Length; i++)
                {
                    Hours[i] = new Hour(openHours[i],minWorkers[i],maxWorkers[i],busyHours[i]);
                }
            }
        }

        //
        // Overwrites settings without clearing names
        //
        public void overwriteDaySettings(bool[] openHours, int[] minWorkers, int[] maxWorkers, bool[] busyHours)
        {
            if (openHours.Length != Slots) //For now, hardcoded 1 hour time slots
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i < Hours.Length; i++)
                {
                    Hours[i].overwriteSettings(openHours[i], minWorkers[i], maxWorkers[i], busyHours[i]);
                }
            }
        }

        //
        // Returns an hour based on an index
        //
        public Hour GetHour(int whichOne) { return hours[whichOne]; }

        //
        // Changes an hour based on index, overwrites availibility and names for that shift
        //
        public void EditHour(int hour, bool available, string[] names)
        {
            Hours[hour].Availible = available;
            Hours[hour].Names = names;
        }


    }
}
