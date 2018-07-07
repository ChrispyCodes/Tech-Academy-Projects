using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    public class myCalculator
    {
        private int outValue;

        public myCalculator()
        {
            outValue = 0;
        }

        public void displayOutValue()
        {
            Console.WriteLine("OutValue = {0}", outValue);
            Console.ReadLine();
        }
        public void Add(int num1)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            outValue = userInput + num1;

        }
        public void Subtract(double num1)
        {
            Console.WriteLine("Enter a number to subract: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            outValue = Convert.ToInt32(userInput2 - num1);

        }
        public void Multiply(string people, string cars)
        {

            int number1 = Convert.ToInt32(people);
            int number2 = Convert.ToInt32(cars);
            int.TryParse(people, out number1);
            int.TryParse(cars, out number2);

            outValue = Convert.ToInt32(number1 * number2);

        }

    }

}
