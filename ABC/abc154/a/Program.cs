using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var fst = Console.ReadLine().Split();
            var s = fst[0];
            var t = fst[1];

            var scd = Console.ReadLine().Split();
            var a = int.Parse(scd[0]);
            var b = int.Parse(scd[1]);

            var u = Console.ReadLine().Trim();

            if(u.Equals(s)){
                a -= 1;
            }else if(u.Equals(t)){
                b -= 1;
            }

            Console.WriteLine(string.Format("{0} {1}",a,b));
        }
    }
}
