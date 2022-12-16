using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class Swap
    {
         public static void SwapNum()
        {
            int a=5; int b=10;
            Console.WriteLine("Before swap a=" + a + " b=" + b);
            a = a * b;
            b = a / b;
            a=a/b;

            Console.WriteLine("After swap a= " + a + " b=" + b);
        }
    }
}
