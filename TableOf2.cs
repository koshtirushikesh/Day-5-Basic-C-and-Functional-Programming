using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public class TableOf2
    {
        public static void Table_of_2()
        {
            Console.WriteLine("Enter The Power Value ");
            int N = Convert.ToInt32(Console.ReadLine());
            int Table = 1;
            Console.WriteLine(Table);

            for (int i = 0; i < N; i++)
            {
                Table = Table * 2;
                Console.WriteLine(Table);
            }

        }
    }
}
