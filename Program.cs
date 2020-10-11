using System;
using System.Threading;

namespace bloc_concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("\nWątek się zakończył");
            });

            
            t.Start();
            //t.IsBackground = true;

            for (int i = 0; i < 500; i++)
            {
                Console.Write("1");
            }
        }
    }
}
