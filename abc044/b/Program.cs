using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();
            var h = new HashSet<char>(s);

            var flag = true;
            foreach(var c in h){
                var count = s.Count(x => x == c);
                if(count % 2 != 0){
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
