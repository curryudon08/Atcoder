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
            var c = int.Parse(_[2]);
            var k = int.Parse(Console.ReadLine());

            var maxV = Math.Max(Math.Max(a,b),c);

            var v = maxV;
            for(var i = 0; i < k; i++){
                v *= 2;
            }

            Console.WriteLine(a + b + c - maxV + v);
        }
    }
}
