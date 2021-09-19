using System.Linq;

namespace Codewars.Solutions._6kyu
{
    public class PyramidArray
    {
        public int[][] Pyramid(int n)
        {
            return Enumerable.Range(1, n).Select(x => Enumerable.Repeat(1, x).ToArray()).ToArray();
        }
    }
}
