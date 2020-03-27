using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = double.Parse(Console.ReadLine());
            var x = l / 3;
            var y = l - x - x;
            var z = l - x - x;

            Console.WriteLine(string.Format("{0:f12}",x * y * z));

        }
    }
}
