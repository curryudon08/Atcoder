using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());

            var happy = ((x / 500) * 1000);
            x = x % 500;

            if(x > 0){
                happy += ((x / 5) * 5);
            }

            Console.WriteLine(happy);
        }
    }
}
