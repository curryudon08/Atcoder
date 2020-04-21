using System;
using System.Collections.Generic;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var n = int.Parse(s[0]);
            var r = int.Parse(s[1]);

            if(n >= 10){
                Console.WriteLine(r);
            }else{
                var x = r + (100 * (10 - n));
                Console.WriteLine(x);
            }
        }
    }
}
