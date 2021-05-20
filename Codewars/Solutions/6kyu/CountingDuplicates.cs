using System.Linq;

namespace Codewars.Solutions._6kyu
{
    public class CountingDuplicates
    {
        public int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
        }
    }
}
