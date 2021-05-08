using System.Linq;

namespace Codewars.Solutions._6kyu
{
    public class DecipherThis
    {
        public string Decipher(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return string.Join(" ",
                        s.Split(' ').Select(x => x.Length < 3
                            ? ((char)int.Parse(x)).ToString()
                            : int.TryParse(x.Substring(0, 3), out int r)
                                ? (char)r + (x.Length >= 5
                                    ? x.Last() + x[4..^1] + x[3]
                                    : x.Length > 3
                                        ? x.Last().ToString()
                                        : string.Empty)
                                : ((char)int.Parse(x.Substring(0, 2)) + (x.Length >= 4
                                    ? x.Last() + x[3..^1] + x[2]
                                    : x.Last().ToString()))));
        }
    }
}
