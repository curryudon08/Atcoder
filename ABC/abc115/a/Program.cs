using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());

            if(d == 25){
                Console.WriteLine("Christmas");
            }

            if(d == 24){
                Console.WriteLine("Christmas Eve");
            }

            if(d == 23){
                Console.WriteLine("Christmas Eve Eve");
            }

            if(d == 22){
                Console.WriteLine("Christmas Eve Eve Eve");
            }
        }
    }
}
