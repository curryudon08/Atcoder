using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());            
            var a = new List<int>();

            var maxVal = 0;
            for(var i = 0; i < n; i++){
                var t = int.Parse(Console.ReadLine());
                a.Add(t);
                maxVal = Math.Max(maxVal, t);
            }
            var secondMax = a.OrderByDescending(i => i).ElementAt(1);

            foreach(var x in a){
                if(x == maxVal){
                    Console.WriteLine(secondMax);
                }else{
                    Console.WriteLine(maxVal);
                }
            }
        }
    }
}
