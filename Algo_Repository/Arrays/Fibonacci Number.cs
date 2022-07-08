using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    /*The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
    such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
    F(0) = 0, F(1) = 1 
    F(n) = F(n - 1) + F(n - 2), for n > 1.Given n, calculate F(n).   */  
    internal class Fibonacci_Number
    {
        public static int fib(int n)
        {
            if(n == 0 || n ==1)
                return n;
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;
            for(int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1]+fib[i-2];
            }
            return fib[n - 2] + fib[n - 1];
        }

       /* public static void Main()
        {
            int n = 4;
            int val =fib(n);
            Console.WriteLine(val);
        }*/
    }
}