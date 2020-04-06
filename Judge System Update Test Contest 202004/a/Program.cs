using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var l = int.Parse(_[1]);
            var r = int.Parse(_[2]);

            while(true){
                if(x >= l && x <= r){
                    break;
                }
                if(x < l){
                    x++;
                }else if(x > r){
                    x--;
                }
            }

            Console.WriteLine(x);
        }
    }
}
