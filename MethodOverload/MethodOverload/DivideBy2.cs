using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class DivideBy2
    {

        public void Numbers(int num1)
        {
            int Total = num1 / 2;
            Console.WriteLine(Total);
            Console.ReadLine();
        }
        public void getValue(out int x) 
        {
            int temp = 5;
            x = temp;
        }
        public void getValue(out int x, out int y)
        {
            int temp = 5;
            int temp2 = 10;
            x = temp;
            y = temp2;
        }


    }
   
    
}
