using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kavin_ShapeDrawing
{
    class Program
    {
        //Example: 
        // 4, *

        // * * * *
        // * * * *
        // * * * *
        // * * * *
         

        /*
            for each row
                for each col
                    draw a symbol
                move to next line
        */

       /*
          * * * * *
          *   *   *
          * * * * *
          *   *   *
          * * * * *
       */

        // Square(int size, char letter)
        // Hollow Square
        // Window
        // Right Triangle
        // Isosceles Triangle
        static void Square(int size, char letter)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(letter + " ");

                }
                Console.WriteLine();
            }
        }

        static void rtriangle(int size, char letter)
        {
            for (int j = 0; j < size; j++)
            {

                for (int i = 0; i < j; i++)
                {

                    Console.Write(letter);

                }
                Console.WriteLine();
            }
        }

        static void itriangle(int size, char letter)
        {
            for (int e = 0; e < size; e++)
            {
                for(int o = 0; o < e; o++)
                {
                    Console.Write(" ", letter);
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            //ask the user for a size
            //ask the user for a symbol
            //ask the user for a shape
            Console.WriteLine("Type in the size that you want your shape");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in the symbol that you want your square to be drawn in");
            char letter = Console.ReadLine()[0];
            Console.WriteLine("Type the symbol that you want your shape in- for square type 'square', for a right triangle type 'rtriangle' , for an isosceles triangle type 'itriangle' ");
            string shape = Console.ReadLine();
            if(shape == "square")
            {
                Square(size, letter);
            }
           if(shape == "rtriangle")
            {
                rtriangle(size, letter);
            }
           if(shape == "itriangle")
                {
                itriangle(size, letter);
            }
                
           

           
            Console.ReadKey(true);
        }
    }
}
