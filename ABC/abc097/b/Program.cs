using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());

            var maxV = 1;
            for(var i = 2; i * i <= x; i++){
                var y = i * i;
                while(y <= x){
                    maxV = Math.Max(maxV, y);
                    y *= i;
                }
            }

            Console.WriteLine(maxV);
        }
    }
}
