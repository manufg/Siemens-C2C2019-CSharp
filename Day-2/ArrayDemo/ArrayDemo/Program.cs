using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {
            /*
            //Array
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter value at numbers[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nvalue from array\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"value at numbers[{i}]: {numbers[i]}");
            }
            
            int[,] numbers = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"enter value at numbers[{i},{j}]: ");
                    numbers[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nvalue from array\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"value at numbers[{i},{j}]: {numbers[i, j]}");
                }
            }
            */
            Console.Write("count: ");
            int count = int.Parse(Console.ReadLine());
            string[] places = new string[count];
            for (int i = 0; i < places.Length; i++)
            {
                Console.Write("name: ");
                places[i] = Console.ReadLine();
            }
            Console.WriteLine("\nvalue from array\n");
            for (int i = 0; i < places.Length; i++)
            {
                Console.WriteLine($"name at places[{i}]: {places[i]}");
            }
        }
    }
}
