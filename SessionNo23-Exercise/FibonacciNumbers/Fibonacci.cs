using System;

namespace FibonacciNumbers
{
    public class Fibonacci : IFibonacciCalculator
    {
        public long FibonacciSeries(long n)
        {
            if (n < 0) throw new ArgumentException("Invalid Input", nameof(n));
            if (n > 90) throw new ArgumentException("Fibonacci result number too big", nameof(n));
            if (n == 0) return 0;
            if (n == 1) return 1;
            long[] Fib = new long[n + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[n];       
        }
    }
}
