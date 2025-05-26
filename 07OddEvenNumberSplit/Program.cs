using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumberSplit
{
    /*
     * create two lists with int data type, one for even numbers and another for odd numbers
     * loop from 0 - 20
        * if number is even, add to even list
        * if number is odd, add to odd list
     * print even list
     * print odd list
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Even: " + string.Join(", ", even));
            Console.WriteLine("Odd: " + string.Join(", ", odd));

            Console.ReadLine();
        }
    }
}
