using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var total = a.Sum();
            if((n - total) >= 0){
                Console.WriteLine(n - total);
            }else{
                Console.WriteLine(-1);
            }
        }
    }
}
