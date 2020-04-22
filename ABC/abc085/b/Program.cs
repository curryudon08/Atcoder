using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var d = new int[n];
            for(var i = 0; i < n; i++){
                d[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(d);

            var count = 1;
            var val = d[0];
            for(var i = 1; i < n; i++){
                if(val < d[i]){
                    val = d[i];
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
