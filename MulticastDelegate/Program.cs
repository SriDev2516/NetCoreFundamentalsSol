using System;

namespace MulticastDelegate
{
    class Program
    {
        public delegate void GetDetails(double height, double widht);
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            GetDetails getDetails = rectangle.GetArea;
            getDetails += rectangle.GetPerimeter;

            getDetails.Invoke(10, 20);

        }
    }
}
