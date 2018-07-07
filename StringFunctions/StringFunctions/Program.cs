using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Chris";
            //string quote = "The man said, \"Hello\", Chris. \n Hello on a new line. \n \t Hello on a tab.";


            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Hi, my name is Chris!");
            sb.AppendLine("I currently study at the tech academy.");
            sb.AppendLine("I am learning to code in c# right now.");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
