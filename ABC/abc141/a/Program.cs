using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var weathers = new string[]{"Sunny", "Cloudy", "Rainy", "Sunny"};
            var w = Console.ReadLine().Trim();
            var i = Array.FindIndex(weathers, s => s.Equals(w));

            Console.WriteLine(weathers[i+1]);
        }
    }
}
