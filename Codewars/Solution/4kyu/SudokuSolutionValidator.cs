using System.Linq;

namespace Codewars.Solution._4kyu
{
    public class SudokuSolutionValidator
    {
        public static bool ValidateSolution(int[][] board)
        {
            var sudokuNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            return Enumerable.Range(0, 9).Select(i => board[i].Intersect(sudokuNumbers).Count() == 9).All(j => j == true)
                && Enumerable.Range(0, 9).Select(k => board.Select(m => m[k])).Select(n => n.Intersect(sudokuNumbers).Count() == 9).All(p => p == true)
                && Enumerable.Range(0, 3).Select(q => board[q].Take(3)).SelectMany(x => x).Intersect(sudokuNumbers).Count() == 9;
        }
    }
}
