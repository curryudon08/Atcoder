using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var minVal = int.MaxValue;
            for(var i = 0; i <= s.Length - 3; i++){
                var x = int.Parse(s.Substring(i, 3));
                minVal = Math.Min(minVal, Math.Abs(x - 753));
            }

            Console.WriteLine(minVal);
        }
    }
}
