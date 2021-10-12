using System;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;

          
            Console.Write("Check whether a given number is perfect number or not:");
            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("The sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("So, the number is perfect.");
            else
                Console.Write("So, the number is not perfect.");
        }
    }
}
