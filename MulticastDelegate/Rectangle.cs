using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegate
{
    class Rectangle
    {
        public void GetArea(double height, double widht)
        {
            Console.WriteLine($"Area of Rectangle is {height * widht}");
        }

        public void GetPerimeter(double height, double widht)
        {
            Console.WriteLine($"Perimeter of Rectangle is {2 *(height + widht)}");
        }
    }
}
