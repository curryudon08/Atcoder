using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int[5];
            var min = int.MaxValue;
            var idx = -1;
            for(var i = 0; i < 5; i++){
                x[i] = int.Parse(Console.ReadLine());

                if(x[i] % 10 != 0){
                    if(min > x[i] % 10){
                        min = x[i] % 10;
                        idx = i;
                    }
                }
            }

            var t = 0;
            for(var i = 0; i < 5; i++){
                if(i != idx){
                    t += x[i] % 10 == 0 ? x[i] : (x[i] / 10 + 1) * 10;
                }
            }
            t += idx != -1 ? x[idx] : 0;

            Console.WriteLine(t);
        }
    }
}
