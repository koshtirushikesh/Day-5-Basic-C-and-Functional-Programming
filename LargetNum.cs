using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class LargetNum
    {
        public static void LargestOfthenum()
        {

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Enter The 1st Number");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The 2st Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The 3st Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("The 1st number is greatest among three");
                }else
                {
                    Console.WriteLine("The 3st number is greatest among three");
                }
                Console.WriteLine("The 2st number is greatest among three");
            }
            else if (num2 > num1) 
            {   if(num2>num3) 
                {
                    Console.WriteLine("The 2st number is greatest among three");
                }else
                {
                    Console.WriteLine("The 3st number is greatest among three");
                }

                Console.WriteLine("The 2st number is greatest among three");
            }else
            {
                Console.WriteLine("The 3st number is greatest among three");
            }


        }
            
            
    }
}
