using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //------MULTIPLYING BY 50------
            int myNumber = 50;
            int userInput;

            Console.WriteLine("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            int total = userInput * myNumber;

            Console.WriteLine("Your number * 50 is: " + total);
            Console.ReadLine();

            //-----ADDING 25 TO INPUT-------
            int myNumber1 = 25;
            int userInput1;
            Console.WriteLine("Enter a number: ");
            userInput1 = int.Parse(Console.ReadLine());
            int total1 = userInput1 + myNumber1;
            Console.WriteLine("Your number plus 25 is: " + total1);
            Console.ReadLine();


            //------DIVIDING BY 12.5-------
            double myNumber2 = 12.5;
            int userInput2;
            Console.WriteLine("Enter a number: ");
            userInput2 = int.Parse(Console.ReadLine());
            double total2 = userInput2 / myNumber2;
            Console.WriteLine("Your number divided by 12.5 is: " + total2);
            Console.ReadLine();

            //-------GREATER THAN 50------
            int myNumber3 = 50;
            int userInput3;
            Console.WriteLine("Enter a number: ");
            userInput3= int.Parse(Console.ReadLine());
            bool greaterThan = userInput3 >= myNumber3;
            Console.WriteLine(greaterThan);
            Console.ReadLine();

            //-------PRINTS REMAINDER-------
            int myNumber4 = 7;
            int userInput4;

            Console.WriteLine("Enter a number: ");
            userInput4 = int.Parse(Console.ReadLine());
            int remainder = userInput4 % myNumber4;
            Console.WriteLine(remainder);
            Console.ReadLine();







        }
    }
}
