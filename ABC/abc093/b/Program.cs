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
            var k = int.Parse(_[2]);

            for(var i = a; i <= b; i++){
                if(i < a + k || i > b - k){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
