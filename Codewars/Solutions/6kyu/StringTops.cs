using System;
using System.Linq;
using System.Text;

namespace Codewars.Solutions._6kyu
{
    public class StringTops
    {
        public string Tops(string msg)
        {
            var tops = new StringBuilder();
            int i = 1, j = 1;

            while (i < msg.Length)
            {
                tops.Append(msg[i]);
                i += 4 * j + 1;
                j++;
            }

            return string.Join("", tops.ToString().Reverse());
        }
    }
}
