using System;
using System.Security.Cryptography.X509Certificates;

namespace DelegateDemo1
{
    public delegate void DelegateAdd(int x, int y);
    public delegate void DelegateDisplayName(string name);

    public class Program
    {
      

        static void Main(string[] args)
        {
            Helper helper = new Helper();
            DelegateAdd delegateAdd = helper.Add;
            DelegateDisplayName delegateDisplayName = Helper.DisplayName;

            delegateAdd(2, 3);
            delegateDisplayName("srinivas");
           
        }
    }
}
