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
            var s = Console.ReadLine().Trim();

            if(s[a] == '-'){
                var x = s.Substring(0, a);
                var y = s.Substring(a + 1, b);

                var o = 0;
                if(int.TryParse(x, out o) && int.TryParse(y, out o)){
                    Console.WriteLine("Yes");
                }else{
                    Console.WriteLine("No");
                }
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
