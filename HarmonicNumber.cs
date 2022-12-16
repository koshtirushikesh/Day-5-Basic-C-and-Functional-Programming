using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public class HarmonicNumber
    {
        public static void Harmonic_Number()
        {
            Console.WriteLine("please enter the power of harmonic number :");
            int n = Convert.ToInt32(Console.ReadLine());

            double i, s = 0.0;

            for (i = 1; i <= n; i++)
            {
                s = s + 1 / i;
            }

            Console.WriteLine("the sum of " + s);

        }
    }
}
