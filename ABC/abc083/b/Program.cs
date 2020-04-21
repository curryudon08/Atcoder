using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var a = int.Parse(_[1]);
            var b = int.Parse(_[2]);

            var total = 0;
            for(var i = 1; i <= n; i++){
                var s = i.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum();
                if(s >= a && s <= b){
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
