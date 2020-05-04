using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());

            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var flag = false;
            for(var i = a; i <= b; i++){
                flag = i % k == 0 ? true: false;

                if(flag){
                    break;
                }
            }

            Console.WriteLine(flag ? "OK" : "NG");
        }
    }
}
