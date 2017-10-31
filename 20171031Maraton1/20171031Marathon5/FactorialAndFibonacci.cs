using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171031Marathon5
{
    class FactorialAndFibonacci
    {
        static void Main(string[] args)
        {

        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
