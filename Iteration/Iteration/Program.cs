using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        //--------------------------------------------------PRACTICING ITERATION-----------------------------------------------------------

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test scores: " + testScores[i]);

        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel", "Adam" };

        //Console.WriteLine("Say hi");
        //string userinp = Convert.ToString(Console.ReadLine());
        //foreach (var name in names)
        //{
        //    Console.WriteLine(userinp + " " + name.ToString());
        //}

        //Console.WriteLine("Updated List: ");
        //int itemToSkip = 4;
        //foreach (var name in names.Where((name, index) => index != itemToSkip))
        //{
        //    Console.WriteLine(name.ToString());
        //}

        //Console.ReadKey();














        List<string> fromWhere = new List<string>() { "Westcoast", "Eastcoast", "Middle", "Outside the US" };

        for (int i = 0; i < fromWhere.Count; i++)
        {
            Console.WriteLine("Input what part of the US you are from: ");
            string userInput = Console.ReadLine();

            if (userInput == fromWhere[i])
            {
                Console.WriteLine("You are from: " + fromWhere[i]);
                Console.ReadLine();
                break;

            }
            else
            {
                Console.WriteLine("Oh im not familiar with that :(");
                Console.ReadLine();
                break;
            }

        }
    }
}
        


