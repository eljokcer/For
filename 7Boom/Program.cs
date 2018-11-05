using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Boom
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)

            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("Boom");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
