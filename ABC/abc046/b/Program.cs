using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);

            var ans = 1L;
            for(var i = 0; i < n; i++){
                if(i == 0){
                    ans *= k;
                }else{
                    ans *= (k - 1);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
