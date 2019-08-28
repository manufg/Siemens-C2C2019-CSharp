using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter sentence to split: ");
            var result = new WordFrequency().GetWordFrequency(Console.ReadLine());
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}