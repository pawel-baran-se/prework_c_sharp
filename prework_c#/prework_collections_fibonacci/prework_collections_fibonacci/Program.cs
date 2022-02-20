using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prework_collections_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //TutCollections();
            FibonacciNumbers();

            Console.ReadKey();
        }

        static void FibonacciNumbers()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for(int i = 0; i <= 17; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach(var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
        }


        static void TutCollections()
        {

            var names = new List<string> { "Pawel", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }
        }
    }
}
