using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(i => long.Parse(i)).OrderBy(i => i).ToArray();
            var s = string.Join("", n.Select(i => i.ToString()));

            if(s.Equals("557")){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
