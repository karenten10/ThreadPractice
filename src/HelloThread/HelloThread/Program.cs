using System;
using System.Threading;

namespace HelloThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===> 1 " + DateTime.Now);
            Method1();
        }

        static void Method1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("===> 2 " + DateTime.Now);
        }
    }
}
