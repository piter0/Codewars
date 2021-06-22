using System.Linq;

namespace Codewars.Solutions._6kyu
{
    public class Dubstep
    {
        public string SongDecoder(string input)
        {
            if (input.IndexOf("WUB") == -1)
            {
                return input;
            }

            var rest = string.Empty;
            if (input.LastIndexOf("WUB") < input.Length)
            {
                rest += " " + input[(input.LastIndexOf("WUB") + 3)..];
            }

            var output = string.Empty;

            for (int i = 0; i <= input.LastIndexOf("WUB"); i++)
            {
                if (input.Substring(0, 3) == "WUB")
                {
                    output += " ";
                    input = input[3..];
                }
                else
                {
                    output += input[0];
                    input = input[1..];
                }

                i = 0;
            }

            output += rest;

            return string.Join(" ", output.Split(' ').Where(x => !string.IsNullOrEmpty(x)));
        }
    }
}
