using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var _ = Console.ReadLine().Split();
            var d = int.Parse(_[0]);
            var x = int.Parse(_[1]);

            var a = new int[n];
            for(var i = 0; i < n; i++){
                a[i] = int.Parse(Console.ReadLine());
            }

            var count = 0;
            foreach(var i in a){
                var idx = 0;
                while(idx * i + 1 <= d){
                    count++;
                    idx++;
                }
            }

            Console.WriteLine(x + count);
        }
    }
}
