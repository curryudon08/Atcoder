using System;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = BigInteger.Parse(Console.ReadLine());
            var b = BigInteger.Parse(Console.ReadLine());

            if(a > b){
                Console.WriteLine("GREATER");
            }else if(a < b){
                Console.WriteLine("LESS");
            }else{
                Console.WriteLine("EQUAL");
            }
        }
    }
}
