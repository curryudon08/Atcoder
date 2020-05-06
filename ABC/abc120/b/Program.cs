using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var k = int.Parse(_[2]);

            var count = 0;
            for(var i = 100; i >= 1; i--){
                if(a % i == 0 && b % i == 0){
                    count++;

                    if(count == k){
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
