using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());

            var q = new Queue<BigInteger>();
            for(var i = 1; i < 10; i++){
                q.Enqueue(i);
            }

            var count = 0;
            BigInteger n = 0;
            while(count < k){
                n = q.Dequeue();
                var mod = n % 10;

                if(mod != 0){
                    q.Enqueue((n * 10) + (mod - 1));
                }

                q.Enqueue((n * 10) + mod);

                if(mod != 9){
                    q.Enqueue((n * 10) + (mod + 1));
                }

                count++;
            }

            Console.WriteLine(n);
        }
    }
}
