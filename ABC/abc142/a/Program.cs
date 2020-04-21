using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var odd = h % 2 == 0 ? h / 2 : h / 2 + 1;
            Console.WriteLine(string.Format("{0:f10}",(1.0 * odd) / h));
        }
    }
}
