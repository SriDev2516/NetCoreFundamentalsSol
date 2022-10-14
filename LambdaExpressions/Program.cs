using System;

namespace LambdaExpressions
{
    class Program
    {
        public delegate void GetDetailsDelegate(string name);
        static void Main(string[] args)
        {
            GetDetailsDelegate getDetailsDelegate = (string name) =>
            {
                Console.WriteLine($"The name is {name}");
            };
            getDetailsDelegate.Invoke("Srinivas");
        }
    }
}
