using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
    public void add(int num1)
    {
        outValue = num1 + Userinput;

    }
    public void subtract(double num1, double num2)
    {
        
        outValue = Convert.ToInt32(num1 - num2);
        
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

