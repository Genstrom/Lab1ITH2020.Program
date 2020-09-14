using System;
using System.Numerics;

namespace Lab1ITH2020.Program
{
    class Program
    {


        static void Main(string[] args)
        {

            BigInteger coloredNumber = 0;
            BigInteger total = 0;
            int counter = 0;
            Console.WriteLine("Please insert a string of characters");

            string userInput = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                counter = 0;
                for (int y = i + 1; y < userInput.Length; y++)
                {

                    if (int.TryParse(userInput[y].ToString(), out int tryToParse))
                    {

                        counter++;

                        if (userInput[i] == userInput[y])
                        {

                            coloredNumber = BigInteger.Parse(userInput.Substring(i, counter + 1));
                            total += coloredNumber;
                            Console.ForegroundColor = ConsoleColor.White; Console.Write(userInput.Substring(0, i));
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write(userInput.Substring(i, counter + 1));
                            Console.ForegroundColor = ConsoleColor.White; Console.Write(userInput.Substring(y + 1));
                            Console.WriteLine();
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"The total of the colored numbers put together equals the number {total}");
        }
    }
}
