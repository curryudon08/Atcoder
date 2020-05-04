using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.Pow(10,20));
        
            /**
            var s = Console.ReadLine().ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();

            var count = 0;
            for(var i = 0; i < s.Length - 3; i++){
                var t = (s[i] * 1000) + (s[i+1] * 100) + (s[i+2] * 10) + s[i+3];
                if(t % 2019 == 0){
                    count++;
                }
            }
            */
        }
    }
}
