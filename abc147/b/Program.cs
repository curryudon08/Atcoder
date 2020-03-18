    using System;

    namespace b
    {
        class Program
        {
            static void Main(string[] args)
            {
                var s = Console.ReadLine().Trim();
                var n = s.Length;

                var count = 0;
                for(var i = 0; i < n / 2; i++){
                    if(s[i] != s[n - i - 1]){
                        count += 1;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
