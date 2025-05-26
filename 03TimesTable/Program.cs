using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTable
{
    /*
     * ask the user for a number for the table
     * write a for loop to print x times table
    */
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int num = 0;
            while (loop)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Number invalid");
                    Console.WriteLine();
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, num, i * num);
            }

            Console.ReadLine();
        }
    }
}
