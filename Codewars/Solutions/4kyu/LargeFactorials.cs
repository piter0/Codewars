using System;
using System.Linq;

namespace Codewars.Solutions._4kyu
{
    public class LargeFactorials
    {
        public string Factorial(int n)
        {
            var p = 0.0;

            for (int j = 2; j <= n; j++)
            {
                p += Math.Log10(j);
            }

            var d = (int)p + 1;
            var a = new int[d];

            for (int i = 1; i < d; i++)
            {
                a[i] = 0;
            }

            a[0] = 1;
            p = 0.0;

            for (int k = 2; k <= n; k++)
            {
                var q = 0;
                p += Math.Log10(k);
                var z = (int)p + 1;

                for (int l = 0; l < z; l++)
                {
                    var t = (a[l] * k) + q;
                    q = t / 10;
                    a[l] = (char)(t % 10);
                }
            }

            return string.Join("", a.Reverse());
        }
    }
}
