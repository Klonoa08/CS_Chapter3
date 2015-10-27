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
            if (payRate < 5.65 || payRate > 49.99)
        }
    }
}
