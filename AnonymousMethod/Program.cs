using System;

namespace AnonymousMethod
{
    class Program
    {
        public delegate void PrintDelegate(string name);
        static void Main(string[] args)
        {
            PrintDelegate printDelegate = delegate (string name)
            {
                Console.WriteLine(name);
            };

            printDelegate.Invoke("Srinivas");
        }
    }
}
