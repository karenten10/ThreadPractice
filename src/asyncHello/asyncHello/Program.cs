using System;
using System.Threading;
using System.Threading.Tasks;

namespace asyncHello
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int foo;
            foo = 168;

            int bar = await MyMethod();
            string bar2 = await MyMethodStr();

            foo = foo + bar;

            Console.WriteLine($"====> foo =>{foo}");
        }

        static Task<int> MyMethod()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 99;
            });
        }

        static Task<string> MyMethodStr()
        {
            return Task.FromResult("");
        }

        
    }
}
