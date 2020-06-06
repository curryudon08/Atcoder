using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var d = 0.0;
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().Split();
                if(s[1].Equals("JPY")){
                    d += double.Parse(s[0]);
                }else{
                    d += (double.Parse(s[0]) * 380000);
                }
            }

            Console.WriteLine(string.Format("{0:F10}",d));
        }
    }
}
