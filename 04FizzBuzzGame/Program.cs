using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    /*
     * create a for loop from 1 to x (15)
     * 3 and 5 = FizzBuzz
     * 3 = Fizz
     * 5 = Buzz
     * else = number
    */
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int num = 0;
            bool threeDiv = false;
            bool fiveDiv = false;
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
            for (int i = 1; i <= num; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}