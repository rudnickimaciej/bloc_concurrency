using System;
using System.Threading;

namespace concurrency
{
    class Program
    {
        static void Main(string[] args)
        {

            var t = new Thread(Function);
            t.Start();




            for (int i = 0; i < 100; i++)
            {
                Console.Write("0");
            }

            Console.ReadKey();
        }

        private static void Function()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("1");
            }
        }
    }
}
