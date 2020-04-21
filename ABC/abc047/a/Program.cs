using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {            
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var a1 = s[0] + s[1] - s[2];
            var a2 = s[0] + s[2] - s[1];
            var a3 = s[1] + s[2] - s[0];

            if(a1 == 0 || a2 == 0 || a3 == 0){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
