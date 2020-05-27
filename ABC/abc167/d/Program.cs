using System;
using System.Linq;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var k = long.Parse(_[1]);
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var idxs = new int[n];
            var i = 1;
            var count = 1;
            while(true){  
                if(idxs[i-1] != 0){
                    break;
                }
                idxs[i-1] = count;
                count++;

                i = a[i-1];
            }
            count--;
            Console.WriteLine(count);

            k = k % count;
            var idx = 1;
            while(k > 0){
                Console.WriteLine(idx);

                idx = a[idx - 1];
                k--;
            }
            Console.WriteLine(idx);
        }
    }
}
