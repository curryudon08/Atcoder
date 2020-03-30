using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var c = int.Parse(_[2]);

            bool flag = false;
            for(var i = 1; i <= 100; i++){
                var n = a * i;
                if(n % b == c){
                    flag = true;
                    break;
                }
            }

            Console.WriteLine(flag ? "YES" : "NO");
        }
    }
}
