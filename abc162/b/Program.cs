using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var total = new BigInteger(0);
            for(var i = 1; i <= n; i++){
                if(i % 3 != 0 && i % 5 != 0){
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
