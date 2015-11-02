using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose P for pine, O for oak, or M for mahogany");
            String wood = Console.ReadLine();
            int price = 0;

            if (wood == "P")
                price = 100;
            if (wood == "0")
                price = 225;
            if (wood == "M")
                price = 310;

            Console.WriteLine("The Price is ${0}.", price);
        }
    }
}
