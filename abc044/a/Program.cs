using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var s = 0;
            if(n >= k){
                s = k * x;
                s += ((n - k) * y);
            }else{
                s = n * x;
            }

            Console.WriteLine(s);
        }
    }
}
