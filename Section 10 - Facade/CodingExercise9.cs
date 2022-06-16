using System;
using System.Collections.Generic;

namespace Section10Facade
{
    internal class CodingExercise9
    {
        static void Main(string[] args)
        {
            MagicSquareGenerator magicSquareGenerator = new MagicSquareGenerator();

            List<List<int>> magicSquare = magicSquareGenerator.Generate(2);

            foreach (List<int> row in magicSquare)
            {
                foreach (int item in row)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
