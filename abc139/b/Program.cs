    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace b
    {
        class Program
        {
            static void Main(string[] args)
            {
                var _ = Console.ReadLine().Split();
                var a = int.Parse(_[0]);
                var b = int.Parse(_[1]);

                var count = 0;
                var socket = 1;

                while(b > socket){
                    socket += a - 1;
                    count++;
                }

                Console.WriteLine(count);
            }
        }
    }
