using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var count = 0;
            for(var i = a; i <= b; i++){
                var s1 = i.ToString();
                var s2 =  string.Join("",s1.Reverse());
                if(s1.Equals(s2)){
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
