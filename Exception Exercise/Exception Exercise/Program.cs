using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        try
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(200);
            numbers.Add(300);
            numbers.Add(400);
            numbers.Add(500);

            for (int i = 0; i < numbers.Count; i++)
            {

                Console.WriteLine("Pick a number.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing...");
                int total = numbers[i] / userNum;
                Console.WriteLine(userNum + " Divided by " + numbers[i] + " Equals " + total);
                Console.ReadLine();
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please dont divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
    
           


}


