using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Exercise_17
{
    class Program
    {
        static BigInteger MinCMultiple(int a, int b)
        {
            BigInteger max = a * b;
            for( int i = 1; i <= max; i++)
            {
                BigInteger multiplicatorA = a * i;
                for (int j = 1; j <= max; j++)
                {
                    BigInteger multiplicatorB = b * j;
                    if (multiplicatorA == multiplicatorB)
                    {
                        return multiplicatorA;
                    }

                }
              
            }
            return max;
        }

        static void Main(string[] args)
        {
            //Defining variables
            int m = 0, n = 0;
            BigInteger maxCDivider = 0;

            //Requesting the number of numbers 
            Console.Write(" Enter the first number: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Calculating
            maxCDivider = (m * n) / MinCMultiple(m, n);

            //Showing values
            Console.WriteLine(" The greatest common divisor of {0} and {1} is: ", m, n);
            Console.Write(" GDC = {0}",maxCDivider);

            Console.ReadKey();
        }
    }
}
