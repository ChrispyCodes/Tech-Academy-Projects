using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDayIsIt
{
    public class Day
    {
        public string DayOfWeek { get; set; }

        
    }
    public enum DayOfWeek
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
