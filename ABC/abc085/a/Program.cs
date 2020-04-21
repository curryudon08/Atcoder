using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var newStr = "2018" + s.Substring(4,6); 
            Console.WriteLine(newStr);
        }
    }
}
