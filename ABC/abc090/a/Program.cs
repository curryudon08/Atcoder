using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            var s3 = Console.ReadLine();

            Console.WriteLine(s1[0].ToString() + s2[1].ToString() + s3[2].ToString());
        }
    }
}
