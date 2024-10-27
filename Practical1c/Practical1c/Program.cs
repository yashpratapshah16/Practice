using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Practical1c
{
    internal class Program
    {

        static int fib(int n)
        {
            if (n == 0 || n==1) return n;
            return fib(n - 1)+fib(n-2);
        }

        static bool is_prime(int n)
        {
            if (n <= 1) return false;
            if(n <= 2) return true;
            for (int i = 3; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            for(int i  = 0; i < 7; i++)
            {
                Console.Write(fib(i)+",");
            }
            Console.WriteLine("\n7 is prime number:" + is_prime(7));
            Console.ReadKey();
        }
    }
}
