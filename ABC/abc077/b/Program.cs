using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var maxV = int.MinValue;
            for(var i = 1; i * i <= n; i++){
                maxV = Math.Max(maxV, i * i);
            }
            Console.WriteLine(maxV);
        }
    }
}
