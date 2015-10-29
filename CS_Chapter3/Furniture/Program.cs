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
            int P = 100;
            int O = 225;
            int M = 310;
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (P == 100)
                Console.WriteLine("Pine cost $100");
                else
                if (O == 225)
                    Console.WriteLine("Oak cost $225");
                else
                if (M ==310)
                Console.WriteLine("Mahogany cost $310");
                else
                Console.WriteLine("Error");

        }
    }
}
