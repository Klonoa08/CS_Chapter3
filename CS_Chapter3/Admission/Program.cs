using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Grade Point Average");
            int Grade = Convert.ToInt32(Console.ReadLine());
            int Score = Convert.ToInt32(Console.ReadLine());
            if (Grade >= 3.0 || Score > 60)
                if (Grade < 3.0 || Score > 80) ;

            Console.WriteLine("Reject");
        }
    }
}
