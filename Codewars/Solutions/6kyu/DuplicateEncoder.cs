using System.Linq;

namespace Codewars.Solutions._6kyu
{
    public class DuplicateEncoder
    {
        public string DuplicateEncode(string word)
        {
            return string.Join("",
                word.ToLower()
                    .Select(x => string.Join("", word.ToLower()
                                                     .GroupBy(y => y)
                                                     .Where(c => c.Key == x)
                    .Select(t => t.Count() > 1 ? ")" : "("))));
        }
    }
}
