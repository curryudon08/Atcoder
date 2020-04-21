using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var l = new List<long>();
            var count = long.MaxValue;
            for(var i = 1; i < Math.Sqrt(n) + 1; i++){
                if(n % i == 0){
                    count = Math.Min(n / i + i - 2, count);
                }
            }
    
            Console.WriteLine(count);
        }
    }
}
