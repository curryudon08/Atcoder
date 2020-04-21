using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var week = new string[]{"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
            var s = Console.ReadLine().Trim();

            foreach(var i in Enumerable.Range(0, 7)){
                if(week[i].Equals(s)){
                    Console.WriteLine(7 - i);
                    break;
                }
            }
        }
    }
}
