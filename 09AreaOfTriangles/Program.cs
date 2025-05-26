using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangles
{
    /*
     * ask user for width and height, store them
     * create function to calculate the area
     * function should calculate the area using: (width * height) / 2
     * call in main and print out the area of triangle
     */
    class Program
    {
        static void Main(string[] args)
        {
            int width = readInt("Enter a width");
            int height = readInt("Enter a height");
            int result = calcArea(width, height);

            Console.WriteLine($"The area is: {result} cm^2");

            Console.ReadLine();
        }

        static int readInt(string prompt = "Enter a number")
        {
            Console.Write($"{prompt}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int calcArea(int width, int height)
        {
            return (width * height) / 2;
        }
    }
}
