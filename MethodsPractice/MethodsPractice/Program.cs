using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Enter a number: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            var domath = new myCalculator();
            domath.Add(100);
            domath.displayOutValue();
            domath.Subtract(10.5);
            domath.displayOutValue();
            domath.Add("10", "userInput");
            domath.displayOutValue();
        }
    }
}
