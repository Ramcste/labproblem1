using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Upper and Lower limit of the Numbers:");
            int upperlimit = Convert.ToInt32(Console.ReadLine());
            int lowerlimit = Convert.ToInt32(Console.ReadLine());

            for (int i = lowerlimit+1; i <upperlimit ; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
