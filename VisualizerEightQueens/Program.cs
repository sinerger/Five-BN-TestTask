using System;
using Five_BN_TestTask;

namespace VisualizerEightQueens
{
    class Program
    {
        private const string _defaultValue = "-";
        private const string _queenValue = "Q";

        static void Main(string[] args)
        {
            var countQueen = 8;
            var solutionsEightQueens = new EightQueens().FindAllSolutions(countQueen);
            var field = new object[countQueen, countQueen];
            for (int i = 0; i < solutionsEightQueens.Count; i++)
            {
                SetDoubleArrayDefaultValues(field, _defaultValue);

                SetQueensPositions(field, solutionsEightQueens[i], _queenValue);

                Console.WriteLine($"\nSolution #{i + 1}");
                PrintDoubleArray(field);
            }

            Console.WriteLine($"\nNumber of all solution options: {solutionsEightQueens.Count}");
            Console.ReadKey();
        }

        private static void SetQueensPositions(object[,] doubleArray, int[] queensPositions, string queenValue)
        {
            for (int i = 0; i < queensPositions.Length; i++)
            {
                doubleArray[i, queensPositions[i]] = queenValue;
            }
        }

        private static void SetDoubleArrayDefaultValues(object[,] doubleArray, string defaultValue)
        {
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    doubleArray[i, j] = defaultValue;
                }
            }
        }

        private static void PrintDoubleArray(object[,] doubleArray)
        {
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    Console.Write($"{doubleArray[i, j]}\t");
                }
            }
        }
    }
}