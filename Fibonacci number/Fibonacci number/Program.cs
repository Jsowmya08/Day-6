using System;

namespace Fibonacci_number
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3, p4;
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide input value : ");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine(p1 + " " + p2);
            Fibonacci(count - 2);
        }
        private static void Fibonacci(int count)
        {
            if(count>0)
            {
                p3 = p1 + p2;
                Console.WriteLine(" " + p3);
                p4 = p3 * (p1 + p2);
                Console.WriteLine(" " + p4);
                Fibonacci(count - 1);
            }
        }

       
    }
}
