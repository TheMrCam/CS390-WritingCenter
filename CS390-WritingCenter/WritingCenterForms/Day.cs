using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    internal class Day
    {
        private const int Slots = 24;
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };
        public struct Hour
        //Keeps the open bool and parameter string[] linked together in array of Hours[]
        {
            private bool open;
            private string[] names;
            public bool Open { get { return open; } set { open = value; } }
            public string[] Names { get { return names; } set { names = value; } }
            public Hour(bool available, string[] workers = null)
            {
                this.open = available;
                this.names = workers;
            }
        }
        //public static int SlotSize { get { return SlotSize; } set { if (value == 15 || value == 20 || value == 30 || value == 60) { SlotSize = value; } else { SlotSize = 60; } } } //15, 20, 30, or 60 minute slots; default: 60
        private Hour[] hours;
        public Hour[] Hours { get { return hours; } set { hours = value;} }
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
    }
}
