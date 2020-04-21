using System;
using System.Collections.Generic;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var total = 0;
            for(var i = 0; i < 2; i++){
                if(a > b){
                    total += a;
                    a--;
                }else{
                    total += b;
                    b--;
                }
            }

            Console.WriteLine(total);
        }
    }
}
