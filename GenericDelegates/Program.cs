using System;

namespace GenericDelegates
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Func<int, double, float, double> delegate1 = (x, y, z) =>  (x + y + z); ;
          
            Action<int, double, float> delegate2 =  ( x,  y,  z) => Console.WriteLine(x + y + z);
            
            Predicate<string>isValidDelegate =  (str) =>
            {
                if (str.Length > 5)
                {
                    return true;
                }

                return false;
            };

            double result =  delegate1(2, 12, 12.3f);
            Console.WriteLine(result);
            delegate2(2, 12, 12.3f);
            Console.WriteLine(isValidDelegate("Srinivas"));
        }

       
    }
}
