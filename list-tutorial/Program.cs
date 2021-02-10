using System;
using System.Collections.Generic;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithStrings();
            
            WorkingWithVar();

            CountFibbonaciNumber(20);
        }

        static void WorkingWithStrings()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            Console.WriteLine($"The list has {names.Count} people in it");

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

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        static void WorkingWithVar()
        {
            var fibonacciNumbers = new List<int> {1, 1};

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

        static void CountFibbonaciNumber(int a) {
            var fibonacciNumbers = new List<int>();

            if (a == 1)
            {
                fibonacciNumbers.Add(1);
                Console.WriteLine(fibonacciNumbers[0]);
            }

            else if (a == 2) 
            {
                fibonacciNumbers.Add(1);
                fibonacciNumbers.Add(1);
                foreach (var item in fibonacciNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            
            else
            {
                fibonacciNumbers.Add(1);
                fibonacciNumbers.Add(1);

                int previous = 0;
                int previous2 = 0;

                for (int i = 0; i < (a - 2); i++)
                {
                    previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                    fibonacciNumbers.Add(previous + previous2);
                }

                int j = 1;
                foreach (var fib in fibonacciNumbers)
                {
                    Console.WriteLine(j + " " + fib);
                    j++;
                }
            }
        }
    }
}
