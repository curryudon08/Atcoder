using System;
using System.Collections.Generic;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var o = s.ToCharArray().OrderBy(c => c).ToArray();

            if((o.Count(c => c == o[0]) == 2) && (o.Count(c => c == o[2]) == 2)){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
