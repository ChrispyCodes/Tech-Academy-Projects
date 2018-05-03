using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> stringList = new List<string>(5);
        stringList.Add("Alex");
        stringList.Add("John");
        stringList.Add("Mason");
        stringList.Add("Joe");
        stringList.Add("Tianna");



        Console.WriteLine("Enter a number <= 4");
        int userInput = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < stringList.Count; i++)
        {
            if (userInput == i)
            {
                Console.WriteLine(stringList[i]);
                Console.ReadLine();
            }

        }


        //--------ARRAY OF INTEGERS THAT IS USER INDEXABLE--------
        //int[] numArray = new int[5];
        //numArray[0] = 63;
        //numArray[1] = 94;
        //numArray[2] = 6;
        //numArray[3] = 1000;
        //numArray[4] = 106;


        //Console.WriteLine("Enter a number <= 4");
        //int userInput = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < numArray.Length; i++)
        //{
        //    if (userInput == i)
        //    {
        //        Console.WriteLine(numArray[i]);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Oops! That number doesn't exist in the array!");
        //        Console.ReadLine();
        //    }

        //}



        //----------ARRAY OF STRINGS THAT IS USER INDEXABLE----------
        //string[] numArray = new string[5];
        //numArray[0] = "Alex";
        //numArray[1] = "John";
        //numArray[2] = "Mason";
        //numArray[3] = "Joe";
        //numArray[4] = "Tianna";



        //Console.WriteLine("Enter a number <= 4");
        //int userInput = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < numArray.Length; i++)
        //{
        //    if (userInput == i)
        //    {
        //        Console.WriteLine(numArray[i]);
        //        Console.ReadLine();
        //    }

        //}


        //
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}


