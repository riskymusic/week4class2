using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"what symbol do you want to use? ");

            string char1 = Console.ReadLine();
            Console.WriteLine("what height would you like it to be? ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("what width would you like it to be? ");
            int width = int.Parse(Console.ReadLine());
            for (int counter = 0; counter < height; counter++)
            {
                for (int counter2 = 0; counter2 < width; counter2++)
                {
                    Console.Write(char1);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        } 
    }
}
