using System;
using System.Linq;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            var k = long.Parse(Console.ReadLine());

            var n = 1;
            for(var i = 0; i < Math.Min(s.Length, k); i++){
                if(s[i] >= 2){
                    n = s[i];
                    break;
                }
            }

            Console.WriteLine(n);
        }
    }
}
