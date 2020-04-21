using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().ToCharArray();

            var x = 0;
            var max = x;
            for(var i = 0; i < n; i++){
                if(s[i] == 'I'){
                    x++;
                }else{
                    x--;
                }
                max = Math.Max(max, x);
            }
            Console.WriteLine(max);
        }
    }
}
