using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class QuotientAndRemainder
    {
        public static void FindQutientAndRemainder()
        {
            int dividend = 210, divisor = 20;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend :{0} Divisor {1}",dividend,divisor);

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = "+ remainder);

        }

    }
}
