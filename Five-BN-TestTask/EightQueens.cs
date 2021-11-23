using System;
using System.Collections.Generic;
using System.Linq;

namespace Five_BN_TestTask
{
    public class EightQueens
    {
        public IList<int[]> FindAllSolutions(int size)
        {
            var currentSolution = new int[size];
            var solutions = new List<int[]>();
            ArrangementQueens(solutions, currentSolution, 0, size);

            return solutions;
        }

        private void ArrangementQueens(List<int[]> solutions, int[] currentSolution, int row, int maxSize)
        {
            if (row == maxSize)
            {
                solutions.Add(currentSolution.ToArray());

                return;
            }

            for (int col = 0; col < currentSolution.Length; col++)
            {
                if (!IsUnderAttack(currentSolution, row, col))
                {
                    currentSolution[row] = col;
                    ArrangementQueens(solutions, currentSolution, row + 1, maxSize);
                }
            }
        }

        private bool IsUnderAttack(int[] currentSolution, int row, int col)
        {
            var result = false;
            for (int i = 0; i < row; i++)
            {
                if (currentSolution[i] == col || row - i == Math.Abs(col - currentSolution[i]))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}