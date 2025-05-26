using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    class Program
    {
        /*
         * create an int and try to convert any string to an int
         * notice the error, write a try catch handler around it
         * catch the error and output the error message
         * without changing the code
         * 
         * why is this a bad situation and how can we know if its been converted
         * 
         * create a custom try parse function
         * find the real function and copy return type/params
         * read the tooltip it gives you, to give you ideas on what to do
         */
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();

                if (customTryParse(numInput, out int result))
                {
                    Console.WriteLine($"Your converted number is {result}");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Your number is invalid");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }

        static bool customTryParse(string input, out int result) // imitation of int.TryParse()
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
