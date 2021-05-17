using System;
using System.Linq;

namespace Codewars.Solutions._4kyu
{
    class ValidateSudokuNxN
    {
        public int[][] SudokuData { get; set; }
        public ValidateSudokuNxN(int[][] sudokuData)
        {
            SudokuData = sudokuData;
        }

        public bool IsValid()
        {
            var arrayLength = SudokuData[0].Length;
            var sudokuNumbers = Enumerable.Range(1, arrayLength).Select(n => n).ToArray();
            return Enumerable.Range(0, arrayLength).Select(i => SudokuData[i].Intersect(sudokuNumbers).Count() == arrayLength).All(j => j == true)
                && Enumerable.Range(0, arrayLength).Select(k => SudokuData.Select(m => m[k])).Select(n => n.Intersect(sudokuNumbers).Count() == arrayLength).All(p => p == true)
                && Enumerable.Range(0, (int)Math.Sqrt(arrayLength)).Select(q => SudokuData[q].Take((int)Math.Sqrt(arrayLength))).SelectMany(x => x).Intersect(sudokuNumbers).Count() == arrayLength;
        }
    }
}
