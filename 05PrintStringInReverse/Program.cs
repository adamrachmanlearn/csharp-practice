using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStringInReverse
{
    /*
     * ask user to input a message
     * print in order
     * print in reverse
    */
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string msg = string.Empty;
            while (loop)
            {
                Console.Write("Enter a message: ");
                msg = Console.ReadLine();
                if (!string.IsNullOrEmpty(msg))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a message");
                    Console.WriteLine();
                }
            }
            Console.Write("Original: ");
            for (int i = 0; i < msg.Length; i++)
            {
                System.Threading.Thread.Sleep(100); //typewriter effect
                Console.Write(msg[i]);
            }

            Console.WriteLine();

            Console.Write("Reversed: ");
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(msg[i]);
            }

            Console.ReadLine();
        }
    }
}
