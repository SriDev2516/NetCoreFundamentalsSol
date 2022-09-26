using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemoExample
{
    public class AsyncAwaitDemo
    {
        private const string URL = "https://docs.microsoft.com/en-us/dotnet/csharp/csharp";
        public void DoSynchronousWork()
        {
            // You can do whatever work is needed here
            Console.WriteLine("1. Doing some work synchronously");
        }

        public async Task DoSomeWorkAsync()
        {
            Console.WriteLine($"2.Async task has started...");
            await GetStringLengthAsync(URL);
        }

        private async Task GetStringLengthAsync(string uRL)
        {
            using (var httpClient = new HttpClient())
            {
                Console.WriteLine("3. Awaiting the result of GetStringAsync of Http Client...");
                string result = await httpClient.GetStringAsync(URL);

                Console.WriteLine("4. The awaited task has completed. Let's get the content length...");
                Console.WriteLine($"5. The length of http Get for {URL}");
                Console.WriteLine($"6. {result.Length} character");
            }
        }

        public void DoSynchronousWorkAfterAwait()
        {
            //This is the work we can do while waiting for the awaited Async Task to complete
            Console.WriteLine("7. While waiting for the async task to finish, we can do some unrelated work...");
            for (var i = 0; i <= 5; i++)
            {
                for (var j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
