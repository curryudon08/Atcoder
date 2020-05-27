using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var count = 0;
            for(var i = 1; i <= n; i++){
                var x = Divisor(i);
                if(i % 2 != 0 && x == 8){
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        static int Divisor(long n){
            var count = 0;
            for(var i = 1; i * i <= n; i++){
                if(n % i == 0){
                    count++;
                    if(i * i != n){
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
