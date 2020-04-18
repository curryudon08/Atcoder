using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var count = 0;
            for(var i = 0; i < n; i++){
                var _ = Console.ReadLine().Split();
                var l = int.Parse(_[0]);
                var r = int.Parse(_[1]);

                count += (r - l + 1);
            }

            Console.WriteLine(count);
        }
    }
}
