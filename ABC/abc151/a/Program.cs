using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Convert.ToChar(Console.ReadLine().Trim());

            var n = Convert.ToInt32(c);
            n += 1;

            Console.WriteLine(Convert.ToChar(n));
        }
    }
}
