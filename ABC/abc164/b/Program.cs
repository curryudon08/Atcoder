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
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var c = int.Parse(_[2]);
            var d = int.Parse(_[3]);

            var i = 1;
            while(true){
                if(i % 2 != 0){
                    c -= b;
                }else{
                    a -= d;
                }

                if(a <= 0){
                    Console.WriteLine("No");
                    break;
                }else if(c <= 0){
                    Console.WriteLine("Yes");
                    break;
                }

                i++;
            }
        }
    }
}
