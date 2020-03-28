using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var r = int.Parse(_[0]);
            var d = int.Parse(_[1]);
            var x = int.Parse(_[2]);

            var ary = new int[10];
            ary[0] = r * x - d;
            for(var i = 1; i < 10; i++){
                ary[i] = r * ary[i-1] - d;
            }

            foreach(var i in ary){
                Console.WriteLine(i);
            }
        }
    }
}
