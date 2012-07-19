using System.Collections.Generic;
namespace Euler_Problems.Problem1_10
{
    public class Problem2
    {
        internal static int SumOfEvenFibonacci(int MaxFibonacciValue)
        {
            List<int> fibonaccis = ReturnListOfFibonacciWithMaximum(MaxFibonacciValue);
            int sumOfEvens = 0;

            foreach (var fibonacci in fibonaccis)
            {
                if (fibonacci % 2 == 0)
                {
                    sumOfEvens += fibonacci;
                }
            }

            return sumOfEvens;
        }

        private static List<int> ReturnListOfFibonacciWithMaximum(int MaxFibonacciValue)
        {
            List<int> fib = new List<int>();
            int oude_fibonacci = 0;
            int fibonacci = 1;

            while ((fibonacci + oude_fibonacci) <= MaxFibonacciValue)
            {
                int temp = oude_fibonacci;
                oude_fibonacci = fibonacci;
                fibonacci += temp;

                fib.Add(fibonacci);
            }

            return fib;
        }
    }
}
