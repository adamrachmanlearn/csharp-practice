using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    /*
     * ask user to enter password, and store
     * ask user to enter password again, and store
     * check if they're both contain something
        * if so check if they're the same
            * if they're print "passwords match"
            * if they are not, print "passwords do not match"
        * if they're empty, print "please enter a password"
    */
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string pass = string.Empty;
            string passC = string.Empty;
            while (loop)
            {
                Console.Write("Enter a password: ");
                pass = Console.ReadLine();
                Console.Write("Enter it again: ");
                passC = Console.ReadLine();
                if (!string.IsNullOrEmpty(pass)) //first filter, check if password isnt empty
                {
                    if (!string.IsNullOrEmpty(passC)) // second filter, check if confirmation isnt empty
                    {
                        if (pass.Length >= 6 && passC.Length >= 6) //third, check if both >= 6 char
                        {
                            if (pass.Equals(passC))
                            {
                                Console.WriteLine("Passwords match");
                                loop = false;
                            }
                            else
                            {
                                Console.WriteLine("Passwords do not match");
                                loop = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Passwords must be 6 char or more!");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter the password confirmation!");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password!");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
