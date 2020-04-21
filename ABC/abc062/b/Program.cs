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
            var h = int.Parse(_[0]);
            var w = int.Parse(_[1]);

            var s = new string[h];
            for(var i = 0; i < h; i++){
                s[i] = Console.ReadLine().Trim();
            }

            Console.WriteLine(new string('#', w + 2));
            for(var i = 0; i < h; i++){
                Console.WriteLine("#" + s[i] + "#");
            }
            Console.WriteLine(new string('#', w + 2));
        }
    }
}
