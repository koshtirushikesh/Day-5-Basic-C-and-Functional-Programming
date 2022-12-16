using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class OddOrEven
    {
        public static void NumberOddOrEven()
        {
            Console.WriteLine("enter the number :");
            int num =Convert.ToInt32(Console.ReadLine());

            int rem = num % 2;
            if (rem == 0) 
            { Console.WriteLine("the num :{0} is even",num); }
            else 
            { Console.WriteLine("the num :{0} is even",num); }
        }
    }
}
