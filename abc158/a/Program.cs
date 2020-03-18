using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            if(s.Contains("AB") | s.Contains("BA")){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
