using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, m = 0, PrimeIndicator = 0;
            Console.Write("Please enter the number to check for Primality: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (a = 2; a <= m; a++)
            {
                if (n % a == 0)
                {
                    Console.Write("The entered number is not  a Prime number .");
                    PrimeIndicator = 1;
                    break;
                }
            }
            if (PrimeIndicator == 0)
                Console.Write("The entered number is a Prime number . ");
        }
    }
}
