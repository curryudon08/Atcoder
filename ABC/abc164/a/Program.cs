using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _  = Console.ReadLine().Split();
            var s = int.Parse(_[0]);
            var w = int.Parse(_[1]);

            if(s <= w){
                Console.WriteLine("unsafe");
            }else{
                Console.WriteLine("safe");
            }
        }
    }
}
