using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
            //Write a program that draws a rectangle. 
            //The width and a height of the rectangle and the inner symbol used to 
            //construct the rectangle can be pre-set using variables.
            //Example: Character:/symbol: $ Width: 3 Height: 4 
        {
            
            Console.WriteLine($"Please enter a symbol:  ");
            string char1 = Console.ReadLine(); //what ever symbol they add in turns into the Char1
            Console.WriteLine("how high would you like your rectangle to be? ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("how wide would you like your rectangle to be? ");
            int width = int.Parse(Console.ReadLine());
            for (int counter = 0; counter <= height; counter++)
            {
                for (int counter2 = 0; counter <= width; counter2++)
                {
                    Console.Write(char1);
                }
                Console.WriteLine();

                
                    
                  
            }
            
        }
    }
}
