using AsyncAwaitDemoExample;
using System;

namespace AsyncAwaitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();

            demo.DoSynchronousWork();
            var someTask = demo.DoSomeWorkAsync();
            demo.DoSynchronousWorkAfterAwait();
            someTask.Wait(); //this is a blocking call, use it only on Main method
            Console.ReadLine();
        }
    }
}
