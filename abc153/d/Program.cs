using System;
using System.Numerics;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(recFunc(h));
        }

        static BigInteger recFunc(BigInteger h){
            if(h == 1){
                return 1;
            }
            return recFunc(h / 2) * 2 + 1;
        }
    }
}
