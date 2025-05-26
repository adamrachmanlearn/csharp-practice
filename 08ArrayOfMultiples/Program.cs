using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    class Program
    {
        /*
         * define and init two int (num, length)
         * (7, 5) -> [7, 14, 21, 28, 35]
         * create an int array with size length
         * loop through and insert the (loop counter x num) into the array
         * print the final array
         */
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num * (i + 1);
            }

            Console.WriteLine("The value is: " + string.Join(", ", multiples));

            Console.ReadLine();
        }
    }
}
