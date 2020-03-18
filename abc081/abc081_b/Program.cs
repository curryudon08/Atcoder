using System;
using System.Linq;
using System.Collections.Generic;

namespace abc081_b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var i = 0;
            var len = a.Length;
            while(true){
                a = a.Where(x => x % 2 == 0).Select(x => x / 2).ToArray();
                if(len == a.Length){
                    i += 1;
                }else{
                    break;
                }
            }
            Console.WriteLine(i);
        }
    }
}
