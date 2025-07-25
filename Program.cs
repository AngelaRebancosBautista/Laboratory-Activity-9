using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's even or odd:");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }
        }
    }
}
         








