using System;
using System.Numerics;

namespace Lab1ITH2020.Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BigInteger total = 0;

            Console.WriteLine("Please insert a string of characters");

            var userInput = Console.ReadLine();
            Console.WriteLine();

            for (var i = 0; i < userInput.Length; i++)
            {
                var counter = 0;
                for (var y = i + 1; y < userInput.Length; y++)
                    if (int.TryParse(userInput[y].ToString(), out var tryToParse))
                    {
                        counter++;

                        if (userInput[i] == userInput[y])
                        {
                            BigInteger coloredNumber = 0;
                            coloredNumber = BigInteger.Parse(userInput.Substring(i, counter + 1));
                            total = total + coloredNumber;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(userInput.Substring(0, i));
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(userInput.Substring(i, counter + 1));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(userInput.Substring(y + 1));
                            Console.WriteLine();
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
            }

            Console.WriteLine($"The total of the colored numbers put together equals the number {total}");
        }
    }
}
