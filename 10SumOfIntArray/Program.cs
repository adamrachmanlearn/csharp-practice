using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntArray
{
    class Program
    {
        /*
         * create and init int array of numbers
         * create function sumOfNumbers with int return type
         * int array param
         * function should return total of all numbers
         * call in main and output the total
         * extra:
            * return -1 if array empty
            * check return in main and output message
            * do we need to return -1, how else can we make this?
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 225
            };

            if (sumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"The sum of int is {total}");
            }
            else
            {
                Console.WriteLine("Array is empty");
            }

            Console.ReadLine();
        }

        static bool sumOfNumbers(int[] numbers, out int total) // using bool and out int
        {
            total = 0;
            if (numbers.Length > 0)
            {
                foreach (var number in numbers)
                {
                    total += number;
                }
                return true;
            }
            return false;
        }
    }
}
