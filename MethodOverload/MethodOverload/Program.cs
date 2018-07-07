using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine()); 
        
           DivideBy2 divide = new DivideBy2();
            divide.Numbers(userInput);

        }
    }
}
