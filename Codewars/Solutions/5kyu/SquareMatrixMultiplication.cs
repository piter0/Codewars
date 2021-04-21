namespace Codewars.Solutions._5kyu
{
    public class SquareMatrixMultiplication
    {
        public static int[,] MatrixMultiplication(int[,] a, int[,] b)
        {
            var len = a.GetLength(0);
            var c = new int[len, len];

            for (var i = 0; i < len; i++)
            {
                for (var j = 0; j < len; j++)
                {
                    for (var k = 0; k < len; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }
    }
}
