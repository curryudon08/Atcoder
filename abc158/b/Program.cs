using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
            var n = s[0];
            var a = s[1];
            var b = s[2];

            var d =  n  / (a + b);
        
            var r = n % (a + b);
            if(r >= a){
                r = a;
            }

            Console.WriteLine(d * a + r);
        }
    }
}
