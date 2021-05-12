using System;
using System.Collections.Generic;

namespace Codewars.Solutions._5kyu
{
    public class DiophantineEquation
    {
        public string SolEquaStr(long n)
        {
            var div = new List<long>();
            var res = "[";
            var sqrtn = Math.Sqrt(n);

            for (var i = 1; i <= sqrtn; i++)
            {
                if (n % i == 0)
                {
                    div.Add(i);
                    div.Add(n / i);
                }
            }
            var divCount = div.Count - 1;

            for (var j = 0; j < divCount; j += 2)
            {
                if ((div[j] + div[j + 1]) % 2 == 0 && (div[j + 1] - div[j]) % 4 == 0)
                {
                    res += "[" + $"{(div[j] + div[j + 1]) / 2}, {(div[j + 1] - div[j]) / 4}" + "], ";
                }
            }

            return res.Length == 1 ? res + "]" : res[0..^2] + "]";
        }
    }
}
