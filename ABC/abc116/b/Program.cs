using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = int.Parse(Console.ReadLine());

            var l = new List<int>();
            l.Add(s);

            while(true){
                var x = l.Last();
                var y = x % 2 == 0 ? x / 2 : x * 3 + 1;

                if(l.IndexOf(y) != -1){
                    Console.WriteLine(l.Count() + 1);
                    break;
                }
                l.Add(y);
            }
        }
    }
}
