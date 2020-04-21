using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
            var a = s[0];
            var b = s[1];

            var flag = true;
            foreach(var i in Enumerable.Range(1, 1000)){
                var ap = i * 8 / 100;
                var bp = i * 10 / 100;
                if(a == ap && b == bp){
                    Console.WriteLine(i);
                    flag = false;
                    break;
                }
            }
            if(flag){
                Console.WriteLine(-1);
            }
        }
    }
}
