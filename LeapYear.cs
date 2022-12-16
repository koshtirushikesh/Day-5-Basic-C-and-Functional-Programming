using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public class LeapYear
    {
        public static void Leap_Year()
        {
            Console.WriteLine("enter the year");
            string year = (Console.ReadLine());
            int num = year.Length;


            int numyear = Convert.ToInt32(year);

            if (num == 4)
            {

                int x = numyear % 400;
                int y = numyear % 100;
                int z = numyear % 4;

                if ((numyear % 4 == 0 && numyear % 100 != 0) || numyear % 400 == 0)
                {
                    Console.WriteLine(numyear + " is a Leap Year");
                }
                else
                {
                    Console.WriteLine(numyear + " is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Please enter the 4 digit no for year");
            }

        }
    }
}
