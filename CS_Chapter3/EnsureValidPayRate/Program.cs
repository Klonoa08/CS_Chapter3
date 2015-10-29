using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you hourly payrate?");
            int payrate = Convert.ToInt32(Console.ReadLine());
            if (payrate < 5.65 || payrate > 49.99)
                Console.WriteLine("Error!");
        }
    }
}
