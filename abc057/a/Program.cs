using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var a = s[0];
            var b = s[1];

            var d = new DateTime(2020,1,1,a,0,0);
            var t = new TimeSpan(b,0,0);

            Console.WriteLine((d+t).Hour);
        }
    }
}
