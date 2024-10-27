using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2020;

            // boxing
            object obj = num;

            // value of num to be change
            num = 100;

            Console.WriteLine("Value - type value of num is :"+num);
            Console.WriteLine("Object - type value of obj is : "+obj);

            int num2 = 23;

            // boxing
            object obj2 = num2;

            // unboxing
            int i = (int)obj2;

            // Display result
            Console.WriteLine("Value of ob object is :"+obj2);
            Console.WriteLine("Value of i is :"+i);


            Console.ReadKey();
        }
    }
}
