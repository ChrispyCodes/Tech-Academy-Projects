using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDayIsIt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("What day of the week is it? ");
                string userInput = Console.ReadLine();
                DayOfWeek dayValue = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput);

                var day = new Day();
                //day.DayOfWeek = (userInput);

                Console.WriteLine("Ahh...it's " + dayValue);
                Console.ReadLine();

            }
            catch (FormatException)
            {

                Console.WriteLine("Please enter a day of the week.");
                return;
                
            }
            finally
            {
                Console.ReadLine();
            }



            
        }

        }
}
