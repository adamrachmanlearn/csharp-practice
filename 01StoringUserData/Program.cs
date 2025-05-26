using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserData
{
    class Program
    {
        /*
         * define a variable to hold your name
         * define a variable to hold your phone number
         * define a variable to hold your age
         * print variables line-by-line to the screen
         * extra: define variables using the var keyword
        */
        static void Main(string[] args)
        {
            var name = "John";
            var phone = "0888555666";
            var age = 23;

            Console.WriteLine(name);
            Console.WriteLine(phone);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
