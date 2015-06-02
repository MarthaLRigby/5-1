using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
