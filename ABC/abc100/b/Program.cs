using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var d = int.Parse(_[0]);
            var n = int.Parse(_[1]);

            var count = 0;
            var i = 1;
            while(true){
                var c = 0;
                var x = i;
                while(true){
                    if(x % 100 == 0 && x / 100 != 0){
                        x /= 100;
                        c++;
                    }else{
                        break;
                    }
                }

                if(c == d){
                    count++;
                }
                if(count == n){
                    break;
                }
                i++;
            }

            Console.WriteLine(i);
        }
    }
}
