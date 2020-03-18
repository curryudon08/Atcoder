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
            var a = long.Parse(s[0]);
            var b = long.Parse(s[2]);

            if(s[1].Equals("+")){
                Console.WriteLine(a + b);
            }else{
                Console.WriteLine(a - b);
            }
        }
    }
}
