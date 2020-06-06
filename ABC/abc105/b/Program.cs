    using System;

    namespace b
    {
        class Program
        {
            static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());

                var f = false;
                for(var i = 0; i <= n / 4; i++){
                    for(var j = 0; j <= n / 7; j++){
                        if(4 * i + 7 * j == n){
                            f = true;
                        }
                    }
                }

                Console.WriteLine(f ? "Yes" : "No");
            }
        }
    }
