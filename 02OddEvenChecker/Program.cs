using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    /*
     * create and initializes two ints
     * make a variable to work out the remainder
     * output remainder to the screen
     * change the first int variable to another number
        * and recalculate the remainder
        * output new remainder to the screen
    */
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;

            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
