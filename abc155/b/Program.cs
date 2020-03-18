using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var flag = true;
            foreach(var x in a){
                if(x % 2 == 0){
                    if(x % 3 == 0 || x % 5 == 0){
                        continue;
                    }else{
                        flag = false;
                        break;
                    }
                }
            }

            Console.WriteLine(flag ? "APPROVED" : "DENIED");
        }
    }
}
