using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning; 

namespace Recursion
{
    class Program 
    {
        static void Main(string[] args)
        {
            double result = Methods.mult_rec(100, 10);
            Console.WriteLine(result);

            int fact_res = Methods.factorial(0);
            Console.WriteLine(fact_res);

            Methods.Towers(4,3,2,1);
            Console.WriteLine(Methods.fibonachiii(6));

            string mystr = "abccbaa";
            Console.WriteLine(Methods.Pallindrome(mystr));

            var integers = new int[] {10, 14, 15, 19, 29, 100};
            Console.WriteLine(Methods.BinarySearch(integers, 0, integers.Length-1, 29));
        }
    }
}
