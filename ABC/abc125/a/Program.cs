using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var t = int.Parse(_[2]);

            var count = 0;
            for(var i = 1; i * a <= t; i++){
                count += b;
            }

            Console.WriteLine(count);
        }
    }
}
