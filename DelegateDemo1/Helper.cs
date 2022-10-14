using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo1
{
    public class Helper
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        public static void DisplayName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
